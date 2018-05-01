﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Directory : Component
    {
        private List<Component> components = new List<Component>();  
        public Directory(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }
        public override void Remove(Component component)
        {
            components.Remove(component);
        }
        public override void Print()
        {
            Console.WriteLine("Node " + name);
            Console.WriteLine("Subnodes:");
            for( int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }
}
