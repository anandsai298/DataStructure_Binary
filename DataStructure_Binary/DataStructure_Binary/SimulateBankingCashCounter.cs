using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class SimulateBankingCashCounter
    {
        LinkedListQueue<string> queue = new LinkedListQueue<string>();
        int amount = Convert.ToInt32(Console.ReadLine());
        public SimulateBankingCashCounter()
        {
            queue.Enqueue("ask");
            queue.Enqueue("anand");
            queue.Enqueue("sai");
            queue.Display();
        }
        public void BankOperation()
        {
            int count = queue.Size();
            for(int i = 0; i < count; i++) 
            { 

                Console.WriteLine("Enter option for banking operation\n1.Withdraw\n2.Deposit\n3.Checkbalance");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:WithDraw();
                        break;
                    case 2:Deposit();
                        break;
                    case 3:CheckBalance();
                        break;
                }
                queue.Dequeue();
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine(amount);
        }

        public void Deposit()
        {
            Console.WriteLine("enter Deposit amount");
            int depositamount=Convert.ToInt32(Console.ReadLine());
            amount += depositamount;
            Console.WriteLine(amount + "balance amount");
        }

        public void WithDraw()
        {
            Console.WriteLine("enter withdraw amount");
            int withdrawamount=Convert.ToInt32(Console.ReadLine());
            if(amount>=withdrawamount)
            {
                amount -= withdrawamount;
                Console.WriteLine(amount + "balance amount");
            }
            else
                Console.WriteLine(" insufficent amount to do transaction");
        }
    }
}
