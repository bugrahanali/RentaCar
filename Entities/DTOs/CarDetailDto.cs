using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
        
    {
        public int CarId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitInStock { get; set; }
    }
}
