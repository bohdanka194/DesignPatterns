using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot();
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState());
            hero.Shoot(); 
            hero.RestoreState(game.History.Pop());
            hero.Shoot(); 

            Console.Read();
        }
    }
}
