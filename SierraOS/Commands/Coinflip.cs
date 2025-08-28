using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Coinflip : Command
    {
        public Coinflip(string name) : base(name) { }
        private Random random;
        
        public override string execute(string[] args)
        {
            random = new Random();
            Flip();
            return "";
            
        }

        public void Flip()
        {
            
            int result = random.Next(2);
            if (result == 0)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                 Console.WriteLine("Tails");
            }
        }
    }
}
