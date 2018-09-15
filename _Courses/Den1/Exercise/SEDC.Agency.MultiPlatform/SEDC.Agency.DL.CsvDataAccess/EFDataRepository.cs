using SEDC.Agency.BL.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Agency.DL.CsvDataAccess
{
    public class EFDataRepository : IDataRepository
    {
        public List<BL.Models.Property> GetAllProperties()
        {
            throw new NotImplementedException();
        }

        public void Insert(BL.Models.Property p)
        {
            throw new NotImplementedException();
        }
    }
}
