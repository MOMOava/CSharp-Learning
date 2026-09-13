using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{abstract class Unit
    {
        protected int hp;
        public Unit ()
        { hp = 100;
        }
        public void SetHp(int value)
        {  hp = value; 
        }
        public int GetHp() { return hp;
        }
        public abstract void PrintInfo();
    }
    interface IDamage
    {
        void TakeDamage(int dmg);
    }
    class Player:Unit ,IDamage
    {
        int mana;
       public void TakeDamage (int  dmg)

        { hp -= dmg;}

        public Player()
        {
            hp = 100;
            mana = 50;
            
        }public int GetMsns ()
        {
            return hp;
        }public void SetMana (int value)
        {  mana = value; }
        public override void PrintInfo()
        {


            Console.WriteLine($"玩家血量:{hp},玩家蓝量:{mana}");

        }
    }
    class Enemy : Unit,IDamage
    {
        int defense;
        public void TakeDamage (int dmg)
        {
            hp -= dmg;
        }
        public Enemy()
        { hp = 80;
            defense = 20;
        }
        public int GetDefense()
        {  return defense;}
        public void SetDefense(int value)
        {  defense = value; }
        public override void PrintInfo()
        {
            Console.WriteLine($"敌方血量:{hp},敌方防御:{defense}");
             
        }
       
    }
    class Monster:Unit ,IDamage
    {
        int attack;
        public Monster()
        {
            hp = 60;
            attack = 30;
        }
        public void TakeDamage(int dmg)
        {
            hp -= dmg;
        }
        public int GetAttack () { return attack;}
        public override void PrintInfo() { Console.WriteLine($"怪物血量:{hp};怪物攻击力:{attack}"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {Player p= new Player();
            Enemy e = new Enemy();
            Monster m = new Monster();
            List<Unit> unitList = new List<Unit>();
            unitList.Add(p);
            unitList .Add(e);
            unitList.Add (m);
            foreach (Unit u in unitList)
            {if (u is IDamage
                    )
                {
                    IDamage dam = (IDamage)u;
                    dam.TakeDamage(20);
                }
                u.PrintInfo();
            }
           
        }
    }
}
