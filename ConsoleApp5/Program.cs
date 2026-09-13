using System.Runtime.InteropServices;

namespace ConsoleApp5
{class Player 
    {
        int hp;
            int damage;
        public Player()

        //无参构造函数
        
        {
             hp = 100;
             damage = 10;

        }//带参构造函数
        public Player(int hpVal, int damageVal)
        {
             
           hp = hpVal;
            damage = damageVal;

        }public void SetHp(int value)
        {
            hp = value;
        }
        public int GetHp()
        {
            return hp;
        }
        public void SetDamage(int value)
        {  damage = value; 
        }
        public int GetDamage(int value)
        {
            return damage;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"玩家血量:{hp};伤害:{damage}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1= new Player();
            p1.PrintInfo();
            Player p2= new Player(150,25);
            p2.PrintInfo();
        }
    }
}
