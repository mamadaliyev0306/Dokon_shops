using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukon_Project.classes
{
    public class Product
    {
        public int Id {  get; set; }
        // public string user {  get; set; }
        public string? ProductName {  get; set; }
        public int ProductPrice {  get; set; }
        public int ProductSize {  get; set; }
        public DateTime ProductDateTime {  get; set; }
    }
}
