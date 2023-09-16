using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{
    using System;

    public class NoCash : ATMState
    {
        private ATMMachine atmMachine;

        public NoCash(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("We don't have any money");
            Console.WriteLine("Your card is ejected");
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have any money");
            Console.WriteLine("There is no card to eject");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("We don't have any money");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We don't have any money");
        }
    }

}
