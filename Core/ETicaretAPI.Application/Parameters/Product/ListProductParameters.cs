using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Parameters.Product
{
    public record ListProductParameters
    {
        public int PageSize { get; set; } = 5;
        public int PageCount { get; set; } = 0;
    }
}
