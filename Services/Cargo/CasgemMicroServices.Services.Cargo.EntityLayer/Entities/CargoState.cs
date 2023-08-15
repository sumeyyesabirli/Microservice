using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroServices.Services.Cargo.EntityLayer.Entities
{
    public class CargoState
    {
        public int CargoStateID { get; set; }
        public string CargoStateDescirption { get; set; }
        public List<CargoDetail> CargoDetails { get; set; }
    }
}
