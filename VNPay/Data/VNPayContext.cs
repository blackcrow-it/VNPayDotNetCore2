using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VNPay.Models
{
    public class VNPayContext : DbContext
    {
        public VNPayContext (DbContextOptions<VNPayContext> options)
            : base(options)
        {
        }

        public DbSet<VNPay.Models.OrderInfo> OrderInfo { get; set; }
    }
}
