namespace learn_2.DAL
{
    using learn_2.Models.Abcent;
    using learn_2.Models.Person;
    using learn_2.Models.WorkPlace;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Farhang : DbContext
    {
        class MigrationConfig : DbMigrationsConfiguration<Farhang>
        {
            public MigrationConfig()
            {
                AutomaticMigrationsEnabled = true;
                AutomaticMigrationDataLossAllowed = true;

            }

        }


        public Farhang()
            : base("name=Farhang")
        {
        }

        public DbSet<DaysOfWeek> DaysOfWeeks { get; set; }
        public DbSet<DayType> DayTypes { get; set; }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Unit> Units { get; set; }


    }


}