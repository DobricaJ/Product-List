using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Product_List.Models
{
    public partial class ServerProductListContext : BaseContext
    {

        public ServerProductListContext(DbContextOptions<ServerProductListContext> options)
            : base(options)
        {
        }
    }
}
