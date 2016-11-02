using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeVector
{
    public struct pull
    {
        public double force;
        public int x, y;

        public pull(double f, int ax, int ay)
        {
            force = f;
            x = ax;
            y = ay;

        }

    }
    class Node
    {
        public int x, y;
        public int label;
        public List<pull> pulls;

        public Node()
            :this(0, 0)
        {
            
        }

        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;

            pulls = new List<pull>();
        }

        public void addPull(double f, int x, int y)
        {
            pull p = new pull(f, x, y);
            
            pulls.Add(p);

        }
    }
}
