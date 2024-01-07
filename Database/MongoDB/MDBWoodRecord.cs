using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTheWoods.Database.MongoDB
{
    public class MDBWoodRecord
    {
        public MDBWoodRecord(int woodID, int treeID, int x, int y)
        {
            WoodID = woodID;
            TreeID = treeID;
            X = x;
            Y = y;
        }

        public int WoodID { get; set; }
        public int TreeID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
