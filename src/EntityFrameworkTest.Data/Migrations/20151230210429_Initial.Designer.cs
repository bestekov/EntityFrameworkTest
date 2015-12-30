using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EntityFrameworkTest.Data;

namespace EntityFrameworkTest.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20151230210429_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkTest.Data.Model", b =>
                {
                    b.Property<string>("Test");

                    b.HasKey("Test");
                });
        }
    }
}
