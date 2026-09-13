using ConsoleApp4;
using System;

namespace ConsoleApp4
{ class Enemy
    {
        int hp;
        int damage;
        public void SetHp(int value)
        {
            hp = value;
        }
        public void SetDamage(int value)
        {
            damage = value;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"敌方血量:{hp};敌方攻击:{damage}");
        }
    }
          
        }

        internal class Program
        {
            static void Main(string[] args)
            {Enemy e1 = new Enemy();
        e1.SetHp(80);
        e1.SetDamage(20);
        Enemy e2 = new Enemy();
        e2.SetHp(150);
        e2.SetDamage(40);
      e2.PrintInfo();
              e1.PrintInfo();
            }
        }
   
