using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTheWoods.Database.MongoDB
{
    public class MDBMonkeyRecord
    {
        public MDBMonkeyRecord(int monkeyID, string monkeyName, int woodID, int seqNr, int treeID, int x, int y)
        {
            MonkeyID = monkeyID;
            MonkeyName = monkeyName;
            WoodID = woodID;
            SeqNr = seqNr;
            TreeID = treeID;
            X = x;
            Y = y;
        }

        public int MonkeyID { get; set; }
        public string MonkeyName { get; set; }
        public int WoodID { get; set; }
        public int SeqNr { get; set; }
        public int TreeID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
