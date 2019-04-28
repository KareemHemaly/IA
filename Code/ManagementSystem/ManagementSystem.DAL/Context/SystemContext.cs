using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.DAL.Context
{
    public class SystemContext : DbContext
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of 
        /// type MersalAccountingContext.
        /// </summary>
        public SystemContext()
            : base("name=SystemContext")
        {

        }
        #endregion

        #region Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        public DbSet<Users> users {get;set;}
        public DbSet<Project> projects {get;set;}
        public DbSet<ProjectStatu> projectStatus {get;set;}
        public DbSet<Requests> requests {get;set;}
        public DbSet<Request_Type> request_Types {get;set;}
        public DbSet<Roles> roles {get;set; }
        public DbSet<Team> teams {get;set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
