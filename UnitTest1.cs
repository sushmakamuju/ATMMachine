using System;
using atmMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ATMMachineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInsertCard()
        {
            ATMMachine atmMachine = new ATMMachine();

            atmMachine.InsertCard();

            atmMachine.EjectCard();

            atmMachine.InsertCard();

            atmMachine.InsertPin(1234);

            atmMachine.RequestCash(20);

            atmMachine.InsertCard();

            atmMachine.InsertPin(1234);
        }
        
    }
}
