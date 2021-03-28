﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int MoldelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}