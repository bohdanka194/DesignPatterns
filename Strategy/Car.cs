using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Car
    {
        protected int passengers;
        protected string model;
        public IMovable Movable { private get; set; }
        public Car (int pass, string mod,IMovable movable)
        {
            passengers = pass;
            model = mod;
            Movable = movable;
        }
        public void Move()
        {
            Movable.Move();
        }
    }
}
