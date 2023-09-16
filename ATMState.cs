using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{
    public interface ATMState
    {
        // Different states expected
        // HasCard, NoCard, HasPin, NoCash

        void InsertCard();

        void EjectCard();

        void InsertPin(int pinEntered);

        void RequestCash(int cashToWithdraw);
    }

}
