using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    public class BaseBankAccount : IPersonal
    {
        private int _userId;
        private static int _countId = 1;
        private int _id;
        private int _balance;
        public int Id { get { return _id; } }
        public int UserId => _userId;
        public BaseBankAccount(int userId)
        {
            _id = _countId;
            _countId++;
            _userId = userId;
        }
        public int Balance => _balance;

        public void Deposite(int money)
        {
            _balance += money;
        }

        public virtual bool Withdraw(int money)
        {
            if (money > _balance)
            {
                Console.WriteLine("You have not enough money!");
                return false;
            }
            _balance -= money;
            return true;
        }
    }
    public class PremiumBankAccount : BaseBankAccount, IBankAccount
    {
        public PremiumBankAccount(int userId) : base(userId)
        {
        }

        public void CallHelpCenter()
        {            
        }
        public override bool Withdraw(int money)
        {
            var result = base.Withdraw(money);
            if (result)
                Deposite(Balance / 100);
            return result;
        }
        public bool Transfer(int money, IPersonal bankAccount)
        {
            if (money > Balance)
            {
                bankAccount.Deposite(money);
                this.Withdraw(money);
                return true;
            }
            return false;
        }
    }
}
