# MCP Server With C#

This project is a minimal Model Context Protocol (MCP) server built with C# and .NET. It exposes a tool that returns sample bill data and can be used as a starting point for building your own MCP-enabled services.

## Features

- Built with .NET and C#
- Uses the Model Context Protocol server package
- Exposes a tool called `GetBillDetailsAsync`
- Returns bill information from a service layer
- Uses dependency injection and a simple hosted application model

## Project structure

- `Program.cs` - application startup and MCP server registration
- `Services/BillService.cs` - business logic that provides bill data
- `Model/BillDetail.cs` - bill model definition
- `Tool/BillTool.cs` - MCP tool that serializes and exposes bill details
- `MCPServerWithService.csproj` - .NET project configuration

## Prerequisites

- .NET SDK 8.0 or later
- A terminal or IDE such as Visual Studio or VS Code

## Run the server

1. Open a terminal in the project folder.
2. Restore dependencies:

```bash
dotnet restore
```

3. Run the project:

```bash
dotnet run
```

The server starts in stdio mode and registers the MCP tool for use by compatible MCP clients.

## Example tool output

The `GetBillDetailsAsync` tool returns JSON similar to:

```json
[
  {
    "id": 1,
    "itemName": "Item A",
    "quantity": 2,
    "itemPrice": 10,
    "totalPrice": 20,
    "billDate": "2026-10-30T00:00:00"
  }
]
```

## Notes

This is a sample implementation intended to demonstrate how to expose a service method as an MCP tool in C#.

