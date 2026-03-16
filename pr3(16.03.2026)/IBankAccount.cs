using System;

namespace pr3
{
    public interface IBankAccount : IPersonal, IPublic
    {
        void CallHelpCenter();
    }
}
