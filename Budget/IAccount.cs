using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal interface IAccount
    {

        void AddAmount(int price);

        void SubtractAmount(int price);

        void GetAccountData();


    }
}
