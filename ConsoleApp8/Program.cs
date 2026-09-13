
using System.Runtime.InteropServices;
namespace ConsoleApp8
{interface IMove
    {
        void Move();

    }abstract class Creature
    {
      public   int hp;

    }
    class Hero : Creature, IMove
    {
        public void Move() {
            Console.WriteLine("英雄正在移动");
        }
        

        
    }
    class Tree :Creature { }
    
    
        
        
    internal class Program
    {
        static void Main(string[] args)
        {List<Creature> creatures=new List<Creature>();
            Hero h=new Hero();
            Tree t= new Tree();
            creatures.Add(h);
            creatures.Add(t);
            foreach (Creature c in creatures)
            {
                if (c is IMove)
                {//向下转型，向上转型为Unit u = new Player();
                    IMove m = (IMove)c;
                    m.Move();
                }

            }

        }
    }
}
