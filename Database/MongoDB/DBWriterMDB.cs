using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeFromTheWoods.Database.MongoDB
{
    public class DBWriterMDB
    {
        private readonly IMongoDatabase _database;

        public DBWriterMDB(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public async Task WriteWoodRecordsAsync(List<MDBWoodRecord> data)
        {
            var woodRecordsCollection = _database.GetCollection<MDBWoodRecord>("WoodRecords");
            await woodRecordsCollection.InsertManyAsync(data);
        }

        public async Task WriteMonkeyRecordsAsync(List<MDBMonkeyRecord> data)
        {
            var monkeyRecordsCollection = _database.GetCollection<MDBMonkeyRecord>("MonkeyRecords");
            await monkeyRecordsCollection.InsertManyAsync(data);
        }

        public async Task WriteWoodCollectiontToDB(Wood wood)
        {
            var woodCollection = _database.GetCollection<Wood>("WoodCollection");
            await woodCollection.InsertOneAsync(wood);
        }


    }
}
