
namespace pr3
{
public interface IPersonal
    {
        int Balance { get; }
        void Deposite(int money);
        bool Withdraw(int money);
    }
    
}
