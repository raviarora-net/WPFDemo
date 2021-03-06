﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppDemo_Library.Common
{
    public static class Helpers
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable!=null)
            {
                var col = new ObservableCollection<T>();

                foreach (var cur in enumerable)
                {
                    col.Add(cur);
                }
                return col;
            }
            return null;

        }
    }
}