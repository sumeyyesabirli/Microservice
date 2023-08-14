using CasgemMicroservice.Services.Cargo.DataAccesLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccesLayer.Context;
using CasgemMicroservice.Services.Cargo.DataAccesLayer.Repository;
using CasgemMicroServices.Services.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccesLayer.EntityFramework
{
    public class EfCargoDetailDal:GenericRepository<CargoDetail>, ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext context):base(context)
        {
            
        }
    }
}
