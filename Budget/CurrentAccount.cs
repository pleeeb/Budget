using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public sealed class CurrentAccount : IAccount
    {
        private static readonly Lazy<CurrentAccount> lazy =
            new Lazy<CurrentAccount>(() => new CurrentAccount());

        public static CurrentAccount Instance {  get {  return lazy.Value; } }

        public int amount { get; set; }

        private CurrentAccount()
        {
            amount = 10000;
        }

        public void AddAmount(int price)
        {
            this.amount += price;
        }

        public void GetAccountData()
        {
            throw new NotImplementedException();
        }

        public void SubtractAmount(int price)
        {
            this.amount -= price;
        }
    }
}
