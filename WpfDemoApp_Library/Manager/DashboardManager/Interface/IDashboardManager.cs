﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;
using WPFAppDemo_DTO.DashBoard;

namespace WpfAppDemo_Library.Manager.AccountManager.Interface
{
   public interface IDashboardManager
    {
        IList<SalesDTO> GetProductSales();
       IList<ProductDTO> GetProductList();
    }
}
