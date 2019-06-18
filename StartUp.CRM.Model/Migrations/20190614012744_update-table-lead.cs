using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StartUp.CRM.Model.Migrations
{
    public partial class updatetablelead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressCity",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressCountry",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressPostalCode",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressState",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressStreet",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CampaignId",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Emails",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Flags",
                table: "Lead",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Lead",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LeadSourceId",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phones",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialLinks",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Lead",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Lead",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Lead",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressCity",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "AddressCountry",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "AddressPostalCode",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "AddressState",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "AddressStreet",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Emails",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Flags",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "LeadSourceId",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Phones",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "SocialLinks",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Lead");
        }
    }
}
