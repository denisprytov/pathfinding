using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFindingApp.DataStructure
{
    class LabirintVertex
    {
        public List<LabirintVertex> Neighbours { get; } // набор смежных вершин

        public int Mark { get; set; } = int.MaxValue - 100000;

        public bool Visited { get; set; } = false;

        public CellTypes NodeType { get; }

        public LabirintVertex Parent;

        public LabirintVertex(CellTypes type)
        {
            NodeType = type;
            Neighbours = new List<LabirintVertex>();
        }
    }
}
