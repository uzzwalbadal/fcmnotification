using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Backend.Authorization.Roles;
using Backend.Authorization.Users;
using Backend.MultiTenancy;
using Backend.EntityModels.ProjectUser;
using Backend.EntityModels.Department;

namespace Backend.EntityFrameworkCore
{
    public class BackendDbContext : AbpZeroDbContext<Tenant, Role, User, BackendDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BackendDbContext(DbContextOptions<BackendDbContext> options)
            : base(options)
        {             
    }
        public DbSet<ProjectUser> ProjectUsers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
    
}
