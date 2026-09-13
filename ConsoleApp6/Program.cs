namespace ConsoleApp6
{class Enemy
    {
        int hp;
        public static int enemySum;
        public static void ShowEnemyCount(   )
        {
            Console.WriteLine(enemySum);

        }
        public Enemy()
        {
            hp = 80;
            enemySum++;

        }
        public void SetHp(int value )
        {  hp = value; 
        }
        public int GetHp() { return hp; }   
        public void PrintInfo ()
        {
            Console.WriteLine($"敌方血量:{hp}");
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {Enemy e1= new Enemy();
            Enemy e2  = new Enemy();
           Enemy e3 = new Enemy();
            e1.PrintInfo();
            e2.PrintInfo();
            e3.PrintInfo();
           Enemy. ShowEnemyCount();

        }
    }
}
