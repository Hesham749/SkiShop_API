﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications.ProductSpecifications
{
    public class ProductPriceSpecification : BaseSpecification<Product, decimal?>
    {
        public ProductPriceSpecification(int id) : base(p => p.Id == id)
        {
            AddSelect(p => p.Price);
        }
    }
}
