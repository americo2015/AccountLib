using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLib
{
    public class Account
    {
        public string Code;
        public string Description { get; set; }
        private decimal amount;
        public decimal Amount
        {
            get
            {
                if (IsSummary)
                {
                    return Children.Sum(child => child.Amount);
                }
                return amount;
            }
        }

        public Account(string Code, string Description, decimal amount, bool isSummary)
        {
            this.Code = Code;
            this.Description = Description;
            this.amount = amount;
            this.IsSummary = isSummary;
            Children = new List<Account>();
        }

        public List<Account> Children { get; set; }
        
        public bool IsSummary { get; set; }
    }
}
