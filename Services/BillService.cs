using MCPServerWithService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCPServerWithService.Services
{
    public class BillService
    {
        public async Task<List<BillDetail>> GetBillDetailsAsync()
        {                        
            var billDetails = new List<BillDetail>
            {
                new BillDetail { Id = 1, ItemName = "Item A", Quantity = 2, ItemPrice = 10.0, BillDate = DateTime.Now },
                new BillDetail { Id = 2, ItemName = "Item B", Quantity = 1, ItemPrice = 20.0, BillDate = DateTime.Now },
                new BillDetail { Id = 3, ItemName = "Item C", Quantity = 5, ItemPrice = 5.0, BillDate = DateTime.Now }
            };
            return billDetails;
        }
    }
}
