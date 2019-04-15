﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastucture;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository:RepositoryBase<Product>,IProductRepository
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
