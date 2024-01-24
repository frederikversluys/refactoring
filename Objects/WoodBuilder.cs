using EscapeFromTheWoods.Database.MongoDB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTheWoods
{
    public class WoodBuilder
    {

        public async Task<Wood> GetWood(int size,Map map,string path, DBWriterMDB mdb)
        {
            Random r = new Random(100);
            List<Tree> trees = new List<Tree>();
            int n = 0;
            while(n<size)
            {
                Tree t = new Tree(IDgenerator.GetTreeID(),r.Next(map.xmin,map.xmax),r.Next(map.ymin,map.ymax));
                if (!trees.Contains(t)) { trees.Add(t); n++; }
            }

            DBWriterMDB localmdb = mdb;

            Wood w = new Wood(IDgenerator.GetWoodID(),trees,map,path,mdb);

            await mdb.WriteWoodCollectiontToDB(w);

            return w;
        }
    }
}
