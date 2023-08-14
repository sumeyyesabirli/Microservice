using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroServices.Services.Cargo.EntityLayer.Entities
{
    public class CargoDetail
    {
        public int CargoDetailID { get;set;}
        public int OrderID { get;set;}
        public int CargoStateID { get;set;}
        public CargoState CargoState { get;set;}
    }
}
