using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using myApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Services.System
{
    public interface ITireProductService 
    {
        public IQueryable<TireProduct> GetData();
    }
}
