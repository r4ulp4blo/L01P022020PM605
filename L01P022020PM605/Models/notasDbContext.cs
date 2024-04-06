using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace L01P022020PM605.Models
{
    public class notasDbContext : DbContext
    {
        public notasDbContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
