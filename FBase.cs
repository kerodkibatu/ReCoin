using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCoin
{
    static class FBase
    {
        public static FirebaseClient Client =
            new FirebaseClient(
                "https://recoin-crypto-default-rtdb.europe-west1.firebasedatabase.app/",
                new FirebaseOptions() { });
        public static ChildQuery Users = Client.Child("Users");
        public static ChildQuery BlockChain = Client.Child("BlockChain");
    }
}
