using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto
{
    public class UpdateOrderingDto
    {
        public int OrderingId { get; set; }
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderingDate { get; set; }
    }
}
