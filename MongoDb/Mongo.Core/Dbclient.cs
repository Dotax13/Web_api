using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Core
{
    public class Dbclient : IDbClient
    {

        private readonly IMongoCollection<Temp> _temps;

        //Construkter
        public Dbclient(IOptions<TempDbConfig> tempDbConfig)
        {
            var client = new MongoClient(tempDbConfig.Value.Connection_String);
            var database = client.GetDatabase(tempDbConfig.Value.Database_Name);
            _temps = database.GetCollection<Temp>(tempDbConfig.Value.Temp_Collection_Name);
        }

        public IMongoCollection<Temp> GetTempCollection() => _temps;

    }
}
