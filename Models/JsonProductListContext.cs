using System;
using System.IO;
using FileContextCore;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Product_List.Models
{
    public partial class JsonProductListContext : BaseContext
    {

        public JsonProductListContext(DbContextOptions<JsonProductListContext> options)
            : base(options)
        {
        }
    }
}
