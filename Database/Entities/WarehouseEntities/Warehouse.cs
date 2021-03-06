﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Database.Entities.WarehouseEntities.Product;
using Database.Entities.WarehouseEntities.Service;
using System;

namespace Database.Entities.WarehouseEntities
{
    [Serializable]
    public class Warehouse
    {
        [Key]
        public int IdWarehouse { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public virtual List<ProductWarehouse> ProductWarehouses { get; set; }

        public virtual List<ServiceWarehouse> ServiceWarehouses { get; set; }
    }
}