using Microsoft.EntityFrameworkCore;
using myApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Services.System
{
    public class TireProductService : ITireProductService
    {
        private readonly ApplicationDbContext _dbContext;
        public TireProductService(
            ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TireProduct> GetData()
        {
            var query = $@"select * from TireProduct ";

            return _dbContext.TireProducts.FromSqlRaw(query);
        }
    }
}
