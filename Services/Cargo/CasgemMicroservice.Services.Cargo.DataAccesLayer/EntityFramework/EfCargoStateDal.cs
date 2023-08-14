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
    public class EfCargoStateDal:GenericRepository<CargoState>, ICargoStateDal
    {
        public EfCargoStateDal(CargoContext context) : base(context)
        {

        }
    }
}
