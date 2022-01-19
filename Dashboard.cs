using Firebase.Database.Query;
using Firebase.Database.Streaming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCoin
{
    public partial class Dashboard : Form
    {
        string Cur = "RC";
        User CurrentUser;
        LoginForm LoginForm;
        public Dashboard(User user, LoginForm loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;
            BlockChain.Initialize();
            CurrentUser = user;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            WelcomeLbl.Text = $"Welcome, {CurrentUser.Username}";
            BalanceLbl.Text = BlockChain.GetBalance(CurrentUser.Username).ToString();
            BlockChain.AddBlock(new Block("Foo","0000",DateTime.Now.Ticks,new List<Transaction>()
            {
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=12f,Fee=0.01f},
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=-12f,Fee=0.01f},
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=17f,Fee=0.01f},
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=12f,Fee=0.01f},
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=-12f,Fee=0.01f},
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=2f,Fee=0.01f},
                new Transaction(){Sender="Foo",Recipient="Bar",Amount=1f,Fee=0.01f},
            }));
        }
        protected override void OnClosed(EventArgs e)
        {
            LoginForm.Show();
            base.OnClosed(e);
        }

        private void TransferBtnCLicked(object sender, EventArgs e)
        {
            Block B = new Block(CurrentUser.Username,
                BlockChain.GetLastBlock().Hash,
                DateTime.Now.Ticks,
                new List<Transaction>() { Transaction.Empty })
            {ID= BlockChain.GetLastBlock().ID+1};
            BlockChain.AddBlock(B);
            foreach (var item in BlockChain.GetHistory(CurrentUser.Username))
            {
                TransactionLbox.Items.Add($"From:{item.Sender}|To:{item.Recipient}|Amount:{item.Amount+Cur}");
            }
        }
    }
}
