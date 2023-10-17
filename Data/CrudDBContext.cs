using AspNeCoreCrudApp.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace Solcucja.Data;

public class CrudDBContext : DbContext
{
    public CrudDBContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Employee> Employees { get; set; }
}