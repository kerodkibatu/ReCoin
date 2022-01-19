using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Offline;
using Firebase.Database.Query;
using Newtonsoft.Json;


namespace ReCoin;
public static class BlockChain
{
    //_POW is the Proof of Work Difficultity
    //_MRW is the Miner Reward in RC
    public static readonly int _POW = 2;
    public static readonly float _MRW = 0.001f;

    public static List<Block> Chain;
    public static List<Transaction> TrxPool = new List<Transaction>();
    public static void Initialize()
    {
        Chain = GetBlocks();
    }
    public static void AddToPool(Transaction trxn)
    {
        TrxPool.Add(trxn);
        FBase.BlockChain.Child("Pool").PatchAsync(TrxPool);
    }
    public static void AddBlock(Block block)
    {
        //Chain.Add(block);
        FBase.BlockChain.Child($"Chain/{block.ID}").PutAsync(block);
    }
    public static List<Block> GetBlocks()
    {
        var Res = FBase.BlockChain.Child("Chain").OnceSingleAsync<List<Block>>().Result;
        if (Res==null)
        {
            AddGenesis();
            return GetBlocks();
        }
        return Res;
    }
    public static List<Transaction> GetHistory(string UserName)
    {
        var history = new List<Transaction>();
        foreach (var block in Chain)
        {
            var transactions = block.Transactions;
            foreach (var transaction in transactions)
            {
                var sender = transaction.Sender;
                var recipient = transaction.Recipient;
                if (UserName.ToLower().Equals(sender.ToLower())| UserName.ToLower().Equals(recipient.ToLower()))
                {
                    history.Add(transaction);
                }
            }
        }
        return history;
    }
    public static bool isValid()
    {
        for (int i = 1; i < Chain.Count; i++)
        {
            var PrevBlock = Chain.ElementAt(i - 1);
            var CurrBlock = Chain.ElementAt(i);
            if (CurrBlock.Hash != CurrBlock.CalculateHash())
                return false;
            if (CurrBlock.PrevHash != PrevBlock.Hash)
                return false;
        }
        return true;
    }
    public static float GetBalance(string UserName)
    {
        float balance = 0;
        float spending = 0;
        float income = 0;
        foreach (var block in Chain)
        {
            var transactions = block.Transactions;
            foreach (var transaction in transactions)
            {
                var sender = transaction.Sender;
                var recipient = transaction.Recipient;
                if (UserName.ToLower().Equals(sender.ToLower()))
                {
                    spending += transaction.Amount + transaction.Fee;
                }
                if (UserName.ToLower().Equals(recipient.ToLower()))
                {
                    income += transaction.Amount;
                }
                balance = income - spending;
            }
        }
        return balance;
    }
    public static Block GetLastBlock()
    {
        var BC = GetBlocks();
        var block = BC.ToArray()[BC.Count-1];
        return block;
    }
    public static void AddGenesis()
    {
        AddBlock(CreateGenesisBlock());
    }
    private static Block CreateGenesisBlock()
    {
        return new Block("Admin",new string('0',20), DateTime.Now.Ticks, new List<Transaction>() { Transaction.Empty }) { ID = 0 };
    }
}
public class Block
{
    public int ID { get; set; }
    public string Creator { get; }
    public string Hash { get; set; }
    public string PrevHash { get; set; }
    public List<Transaction> Transactions { get; set; }
    public long Timestamp { get; set; }
    public Block(string _Creator, string _PrevHash, long _Timestamp, List<Transaction> _transactions)
    {
        Creator = _Creator;
        PrevHash = _PrevHash;
        Transactions = _transactions;
        Timestamp = _Timestamp;
        Hash = CalculateHash();
    }
    public void SetHash()
    {
        Hash = CalculateHash();
    }
    public string CalculateHash()
    {
        using SHA256 sha = SHA256.Create();
        var vars = new dynamic[] { Creator, Timestamp, Transactions, PrevHash };
        var keys = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(vars));
        
        string hash = Convert.ToBase64String(sha.ComputeHash(keys));
       
        return hash;
    }
}
public class User
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Created { get; set; }
    public Wallet Wallet { get; set; }
}
public class Wallet
{
    public float Balance { get; set; } = 0f;
    public List<Transaction> History { get; set; }
}
public class Transaction
{
    public string Sender { get; set; }
    public string Recipient { get; set; }
    public float Amount { get; set; }
    public float Fee { get; set; }
    public static Transaction Empty = new Transaction() {Sender="Admin",Recipient="Admin",Amount=0f,Fee=0f};
}
