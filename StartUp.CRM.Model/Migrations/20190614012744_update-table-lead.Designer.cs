﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StartUp.CRM.Model;

namespace StartUp.CRM.Model.Migrations
{
    [DbContext(typeof(CRMDBContext))]
    [Migration("20190614012744_update-table-lead")]
    partial class updatetablelead
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StartUp.CRM.Model.Entities.Lead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressCity");

                    b.Property<string>("AddressCountry");

                    b.Property<string>("AddressPostalCode");

                    b.Property<string>("AddressState");

                    b.Property<string>("AddressStreet");

                    b.Property<Guid?>("CampaignId");

                    b.Property<string>("CompanyName");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Emails");

                    b.Property<string>("FirstName");

                    b.Property<int>("Flags");

                    b.Property<int?>("Gender");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastName");

                    b.Property<Guid?>("LeadSourceId");

                    b.Property<string>("MiddleName");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("Phones");

                    b.Property<string>("Position");

                    b.Property<int?>("Ranking");

                    b.Property<string>("SocialLinks");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Lead");
                });
#pragma warning restore 612, 618
        }
    }
}
