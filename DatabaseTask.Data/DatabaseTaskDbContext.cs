using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<BranchOffice> BranchOffice { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<EmployeesChild> EmployeesChild { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<WorkTime> WorkTime { get; set; }
        public DbSet<BorrowedItem> BorrowedItems { get; set;}
        public DbSet<Hint> Hint { get; set; }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Vacations)
                .WithOne()
                .HasForeignKey(v => v.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.SickLeaves)
                .WithOne()
                .HasForeignKey(s => s.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.HealthChecks)
                .WithOne()
                .HasForeignKey(h => h.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Requests)
                .WithOne()
                .HasForeignKey(r => r.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Children)
                .WithOne()
                .HasForeignKey(c => c.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.WorkTimes)
                .WithOne()
                .HasForeignKey(w => w.EmployeeId);

            modelBuilder.Entity<BranchOffice>()
                .HasMany(b => b.Departments)
                .WithOne(d => d.BranchOffice)
                .HasForeignKey(d => d.BranchOfficeId);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.BranchOffices)
                .WithOne(b => b.Company)
                .HasForeignKey(b => b.CompanyId);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId);

        }
    }
}
