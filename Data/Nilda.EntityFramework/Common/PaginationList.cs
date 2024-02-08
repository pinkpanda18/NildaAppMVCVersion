using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilda.EntityFrameworkCore.Common
{  
    public class PaginationList<T> where T : class
    {
        public PaginationList()
        {
            Data = new List<T>();
        }

        public List<T> Data { get; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }
    }
}
