﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroService.Models;

namespace ProductMicroService.Database
{
    public interface IProductRepository
    {
	    IReadOnlyCollection<Product> GetProducts();
	    Product GetProductById( int id );
	}
}
