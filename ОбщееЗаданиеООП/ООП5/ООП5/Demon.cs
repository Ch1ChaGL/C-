using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП5
{
    internal class Demon : Entity
    {

        private int intelligence;
        public Demon(string name, int power, int health, int intelligence) : base(name, power, health)
        {
            this.intelligence = intelligence;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Интелект = " + intelligence);
        }

        public int GetIntelligence()
        {   
            return intelligence;
        }
    }
}
