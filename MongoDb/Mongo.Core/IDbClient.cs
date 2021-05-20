using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Core
{
    public interface IDbClient
    {

        IMongoCollection<Temp> GetTempCollection();


    }
}
