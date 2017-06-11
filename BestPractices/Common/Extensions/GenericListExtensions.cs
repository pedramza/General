using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedram.BestPractices.Extensions
{
    public static class GenericListExtensions
    {
        public static void SafeAdd(this List<object> list, object item)
        {
            if (list == null)
                list = new List<object>();

            list.Add(item);
        }

    }
}
