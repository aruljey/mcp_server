using ModelContextProtocol.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json;

namespace MCPServerWithService.Tool
{
    [McpServerToolType]
    public static class BillTool
    {
        [McpServerTool,Description("Get Bill Details")]
        public static async Task<string> GetBillDetailsAsync()
        {
            var billService = new Services.BillService();
            var billDetails = await billService.GetBillDetailsAsync();
            
            return JsonSerializer.Serialize(billDetails);
        }
    }
}
