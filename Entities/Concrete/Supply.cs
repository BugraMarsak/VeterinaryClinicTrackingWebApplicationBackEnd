using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Supply : IEntity
    {
        public int SupplyId { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; } //sqlde float C# da double'a denk
    }
}
