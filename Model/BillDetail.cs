using System;
using System.Collections.Generic;
using System.Text;

namespace MCPServerWithService.Model
{
    public class BillDetail
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = "";
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double TotalPrice => Quantity * ItemPrice;
        public DateTime BillDate { get; set; }
        
    }
}
