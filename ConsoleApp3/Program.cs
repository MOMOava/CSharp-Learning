using System;

namespace ConsoleApp3
{
    class Player
    {
        public int hp;
        public int damage;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            p1.hp = 30;
            p1.damage = 100;
            Console.WriteLine($"玩家血量:{p1.hp}\n玩家攻击:{p1.damage}");
        }
    }
}
