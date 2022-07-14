using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.ViewModels.Products
{
    public class VM_List_Product
    {
        public String Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
