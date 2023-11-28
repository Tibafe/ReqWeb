using Microsoft.EntityFrameworkCore;
using Req231123_V1.Controllers;
using Req231123_V1.Models;

namespace Req231123_V1.Context;


    public class AppDbContext: DbContext
    {
   
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<Produto> Produto { get; set; }
            public DbSet<Requisicao> Requisicao { get; set;}

       



    }