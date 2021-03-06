﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;
using WPFAppDemo_DTO.DashBoard;

namespace WpfAppDemo_Library.DAL.DashboardDao.Interface
{
   public interface IDashboardDao
    {
        IList<SalesDTO> GetProductSales();
       IList<ProductDTO> GetProductList();
    }
}
