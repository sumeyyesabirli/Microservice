
using CasgemMicroservice.Services.Cargo.DataAccesLayer.Abstract;
using CasgemMicroServices.Services.Cargo.BussinessLayer.Abstract;
using CasgemMicroServices.Services.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroServices.Services.Cargo.BussinessLayer.Concrete
{
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailDal _cargoDetailDal;

        public CargoDetailManager(ICargoDetailDal cargoDetailDal)
        {
            _cargoDetailDal = cargoDetailDal;
        }

        public void Delete(CargoDetail entity)
        {
            _cargoDetailDal.Delete(entity);
        }

        public List<CargoDetail> GetAll()
        {
            return _cargoDetailDal.GetAll();
        }

        public CargoDetail GetById(int id)
        {
            return _cargoDetailDal.GetById(id);
        }

        public void Insert(CargoDetail entity)
        {
            _cargoDetailDal.Insert(entity);
        }

        public void Update(CargoDetail entity)
        {
            _cargoDetailDal.Update(entity);
        }
    }
}
