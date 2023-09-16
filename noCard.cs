using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{
    using System;

    public class NoCard : ATMState
    {
        private ATMMachine atmMachine;

        public NoCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter your PIN");
            atmMachine.SetATMState(atmMachine.GetYesCardState());
        }

        public void EjectCard()
        {
            Console.WriteLine("You didn't enter a card");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("You have not entered your card");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("You have not entered your card");
        }
    }

}
