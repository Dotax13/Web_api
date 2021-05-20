using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Core
{
    public interface ITempServices
    {

        List<Temp> GetTemps();

        Temp GetTemp(string id);
        Temp AddTemp(Temp temp);

        void DeleteTemp(string id);

    }
}
