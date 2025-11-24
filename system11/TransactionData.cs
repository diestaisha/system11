using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace system11
{
    public class TransactionData
    {
        // Basic transaction info
        public string FName { get; set; }
        public string LName { get; set; }
        public int IDNum { get; set; }
        public string Orders { get; set; }
        public float Total { get; set; }
        public float PaymentAmount { get; set; }
        public float Change { get; set; }
        public string PaymentMethod { get; set; }
        public string DineType { get; set; }
        public DateTime Date { get; set; }

        // Store all transactions
        public static List<TransactionData> Transactions = new List<TransactionData>();

        // Current logged in user info (set when user logs in)
        public static string CurrentFName { get; set; }
        public static string CurrentLName { get; set; }
        public static int CurrentID { get; set; }
    }
}
