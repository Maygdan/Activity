namespace pr3{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseBankAccount myAccount = new BaseBankAccount(11);
            Console.WriteLine(myAccount.Id);
            Console.WriteLine(myAccount.UserId);
            IPersonal myAccountAbility = myAccount as IPersonal;
            Console.WriteLine(myAccountAbility.Balance);
            var myAccountDuplicate = myAccountAbility as BaseBankAccount;
            Console.WriteLine(myAccountDuplicate.Id);
            Console.WriteLine(myAccountDuplicate.UserId);

            PremiumBankAccount myPremiumAccount = new PremiumBankAccount(12);
            myAccount = (BaseBankAccount)myPremiumAccount;
            myAccount.Deposite(1000);
            myAccount.Withdraw(300);
            Console.WriteLine(myAccount.Balance);
            myAccountAbility = myPremiumAccount as IPersonal;
            IPublic myCommunicationAccount = myAccountAbility as IPublic;
            Console.WriteLine(myCommunicationAccount is not null);
        }
    }
}