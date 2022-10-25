using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ООП5;

namespace ООП5
{
    internal class Entity
    {
        private string name;
        private int power;
        private int health;
        public readonly Entity race;


        public Entity(string name, int power, int health)
        {
            this.name = name;
            this.power = power;
            this.health = health;
        }
        public virtual void Show()
        {
            Console.WriteLine("Имя = " + name);
            Console.WriteLine("Сила = " + power);
            Console.WriteLine("Здоровье = " + health);
        }
        public void Attac(Entity other)
        {

            int power1 = power;
            int power2 = other.power;
            
            if(this is Demon)
            {                                                       
                    Demon temp = (Demon)this;
                    power = power + temp.GetIntelligence();
                              
            }
            if(other is Demon)
            {              
                
                    Demon temp = (Demon)other;
                    other.power = other.power + temp.GetIntelligence();
                
                    
            }
            if(power> other.power)
            {
                other.health -= power;
                power += 10;
                Console.WriteLine("Победил " + name);
            }else if (other.power > power)
            {
                health -= other.power;
                other.power += 10;
                Console.WriteLine("Победил " + other.name);
                if (health <= 0) Console.WriteLine("Вы мертвы");
            }
            else
            {
                Console.WriteLine("Ничья....");
            }

        }
        public string GetName()
        {
            return name;
        }
        public int GetHealth()
        {
            return health;
        }
    }
}
//int myPower1 = this.power, myPower2 = other.power;
//if (this is Demon)
//{
//    Demon temp = (Demon)this;
//    myPower1 += 10 * temp.inteleg;
//}
//if (other is Demon)
//{

//    Demon temp = (Demon)other;
//    myPower2 += 10 * temp.Brain;
//}


//if (this.power > other.power)
//{
//    other.heals -= this.power;
//    this.power += 10;
//    Console.WriteLine("Победил " + this.name);
//}
//else if (other.power > this.power)
//{
//    this.heals -= other.power;
//    other.power += 10;
//    Console.WriteLine("Победил " + other.name);
//}
//else
//{
//    Console.WriteLine("Ничья....");
//}