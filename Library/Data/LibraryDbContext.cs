using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
        {
            
        }
        //create the table
        public DbSet<BorrowingRecords> BorrowingRecords { get; set; }
    }
}
