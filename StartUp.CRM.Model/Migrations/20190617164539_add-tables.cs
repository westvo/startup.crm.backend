using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StartUp.CRM.Model.Migrations
{
    public partial class addtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SalesUnitId",
                table: "Lead",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    LinkedItemId = table.Column<Guid>(nullable: true),
                    LinkedItemType = table.Column<int>(nullable: true),
                    AssigneeId = table.Column<Guid>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: true),
                    Longitude = table.Column<decimal>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Call",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    LinkedItemId = table.Column<Guid>(nullable: true),
                    LinkedItemType = table.Column<int>(nullable: true),
                    AssigneeId = table.Column<Guid>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    Ordinal = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: true),
                    DurationHours = table.Column<int>(nullable: true),
                    DurationMinutes = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Call", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    DigitsAfterDecimal = table.Column<int>(nullable: false),
                    CurrencySymbol = table.Column<string>(nullable: true),
                    ListSymbol = table.Column<string>(nullable: true),
                    DecimalSymbol = table.Column<string>(nullable: true),
                    Format = table.Column<string>(nullable: true),
                    ExchangeRate = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadAudit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    BeforeValueString = table.Column<string>(nullable: true),
                    AfterValueString = table.Column<string>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadAudit_Lead_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Lead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeadSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LostReason",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LostReason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    LinkedItemId = table.Column<Guid>(nullable: true),
                    LinkedItemType = table.Column<int>(nullable: true),
                    AssigneeId = table.Column<Guid>(nullable: true),
                    ZIndex = table.Column<int>(nullable: false),
                    PositionTop = table.Column<int>(nullable: false),
                    PositionLeft = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    UnitSymbol = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TaxonId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPriceList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPriceList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    LinkedItemId = table.Column<Guid>(nullable: true),
                    LinkedItemType = table.Column<int>(nullable: true),
                    AssigneeId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    EndDateOffset = table.Column<int>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesUnit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: true),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StageCustomField",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageCustomField", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Target",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Target", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaignAudit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    BeforeValueString = table.Column<string>(nullable: true),
                    AfterValueString = table.Column<string>(nullable: true),
                    CampaignId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignAudit_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    CampaignId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignLog_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignTracker",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    CampaignId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignTracker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignTracker_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRateList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    CurrencyId = table.Column<Guid>(nullable: false),
                    ExchangeRateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRateList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExchangeRateList_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExchangeRateList_ExchangeRate_ExchangeRateId",
                        column: x => x.ExchangeRateId,
                        principalTable: "ExchangeRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPriceListDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductPriceListId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPriceListDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPriceListDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPriceListDetail_ProductPriceList_ProductPriceListId",
                        column: x => x.ProductPriceListId,
                        principalTable: "ProductPriceList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pipeline",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UrlName = table.Column<string>(nullable: true),
                    Color = table.Column<int>(nullable: false),
                    SalesUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pipeline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pipeline_SalesUnit_SalesUnitId",
                        column: x => x.SalesUnitId,
                        principalTable: "SalesUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    LinkedItemId = table.Column<Guid>(nullable: true),
                    LinkedItemType = table.Column<int>(nullable: true),
                    AssigneeId = table.Column<Guid>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    Ordinal = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TaskTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_TaskType_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "TaskType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Percentage = table.Column<double>(nullable: false),
                    TimeFrame = table.Column<double>(nullable: false),
                    PipelineId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stage_Pipeline_PipelineId",
                        column: x => x.PipelineId,
                        principalTable: "Pipeline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: true),
                    FixedExchangeRate = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Ordinal = table.Column<double>(nullable: false),
                    Ranking = table.Column<int>(nullable: true),
                    OpportunityTypeId = table.Column<Guid>(nullable: true),
                    LeadSourceId = table.Column<Guid>(nullable: true),
                    LostReasonId = table.Column<Guid>(nullable: true),
                    CurrencyId = table.Column<Guid>(nullable: true),
                    CampaignId = table.Column<Guid>(nullable: true),
                    StageId = table.Column<Guid>(nullable: true),
                    LastMovedDate = table.Column<DateTime>(nullable: false),
                    PipelineId = table.Column<Guid>(nullable: true),
                    CloseDate = table.Column<DateTime>(nullable: false),
                    SalesUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opportunity_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_LeadSource_LeadSourceId",
                        column: x => x.LeadSourceId,
                        principalTable: "LeadSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_LostReason_LostReasonId",
                        column: x => x.LostReasonId,
                        principalTable: "LostReason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_OpportunityType_OpportunityTypeId",
                        column: x => x.OpportunityTypeId,
                        principalTable: "OpportunityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Pipeline_PipelineId",
                        column: x => x.PipelineId,
                        principalTable: "Pipeline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_SalesUnit_SalesUnitId",
                        column: x => x.SalesUnitId,
                        principalTable: "SalesUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StageCheckedList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ItemType = table.Column<int>(nullable: false),
                    Ordinal = table.Column<int>(nullable: false),
                    StageId = table.Column<Guid>(nullable: false),
                    StageCustomFieldId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageCheckedList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StageCheckedList_StageCustomField_StageCustomFieldId",
                        column: x => x.StageCustomFieldId,
                        principalTable: "StageCustomField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StageCheckedList_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    AddressStreet = table.Column<string>(nullable: true),
                    AddressCity = table.Column<string>(nullable: true),
                    AddressState = table.Column<string>(nullable: true),
                    AddressPostalCode = table.Column<string>(nullable: true),
                    AddressCountry = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AccountTypeId = table.Column<Guid>(nullable: false),
                    IndustryId = table.Column<Guid>(nullable: false),
                    Emails = table.Column<string>(nullable: true),
                    Phones = table.Column<string>(nullable: true),
                    AvatarMediaItemId = table.Column<Guid>(nullable: true),
                    SocialLinks = table.Column<string>(nullable: true),
                    OpportunityId = table.Column<Guid>(nullable: true),
                    SalesUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_SalesUnit_SalesUnitId",
                        column: x => x.SalesUnitId,
                        principalTable: "SalesUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    AddressStreet = table.Column<string>(nullable: true),
                    AddressCity = table.Column<string>(nullable: true),
                    AddressState = table.Column<string>(nullable: true),
                    AddressPostalCode = table.Column<string>(nullable: true),
                    AddressCountry = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Emails = table.Column<string>(nullable: true),
                    Phones = table.Column<string>(nullable: true),
                    AvatarMediaItemId = table.Column<Guid>(nullable: true),
                    SocialLinks = table.Column<string>(nullable: true),
                    OpportunityId = table.Column<Guid>(nullable: true),
                    SalesUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_SalesUnit_SalesUnitId",
                        column: x => x.SalesUnitId,
                        principalTable: "SalesUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityAudit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    BeforeValueString = table.Column<string>(nullable: true),
                    AfterValueString = table.Column<string>(nullable: true),
                    OpportunityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityAudit_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OpportunityId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityProduct_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountAudit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    BeforeValueString = table.Column<string>(nullable: true),
                    AfterValueString = table.Column<string>(nullable: true),
                    AccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountAudit_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressBook",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AccountId = table.Column<Guid>(nullable: false),
                    ContactId = table.Column<Guid>(nullable: false),
                    ParentContactId = table.Column<Guid>(nullable: true),
                    Department = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressBook_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressBook_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactAudit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true),
                    Flags = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    DataType = table.Column<string>(nullable: true),
                    BeforeValueString = table.Column<string>(nullable: true),
                    AfterValueString = table.Column<string>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactAudit_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CampaignId",
                table: "Lead",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_LeadSourceId",
                table: "Lead",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_SalesUnitId",
                table: "Lead",
                column: "SalesUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeId",
                table: "Account",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_IndustryId",
                table: "Account",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_OpportunityId",
                table: "Account",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_SalesUnitId",
                table: "Account",
                column: "SalesUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountAudit_AccountId",
                table: "AccountAudit",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressBook_AccountId",
                table: "AddressBook",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressBook_ContactId",
                table: "AddressBook",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignAudit_CampaignId",
                table: "CampaignAudit",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLog_CampaignId",
                table: "CampaignLog",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTracker_CampaignId",
                table: "CampaignTracker",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_OpportunityId",
                table: "Contact",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_SalesUnitId",
                table: "Contact",
                column: "SalesUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactAudit_ContactId",
                table: "ContactAudit",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRateList_CurrencyId",
                table: "ExchangeRateList",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRateList_ExchangeRateId",
                table: "ExchangeRateList",
                column: "ExchangeRateId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadAudit_LeadId",
                table: "LeadAudit",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_CampaignId",
                table: "Opportunity",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_CurrencyId",
                table: "Opportunity",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_LeadSourceId",
                table: "Opportunity",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_LostReasonId",
                table: "Opportunity",
                column: "LostReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_OpportunityTypeId",
                table: "Opportunity",
                column: "OpportunityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_PipelineId",
                table: "Opportunity",
                column: "PipelineId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_SalesUnitId",
                table: "Opportunity",
                column: "SalesUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_StageId",
                table: "Opportunity",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityAudit_OpportunityId",
                table: "OpportunityAudit",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityProduct_OpportunityId",
                table: "OpportunityProduct",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityProduct_ProductId",
                table: "OpportunityProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Pipeline_SalesUnitId",
                table: "Pipeline",
                column: "SalesUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPriceListDetail_ProductId",
                table: "ProductPriceListDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPriceListDetail_ProductPriceListId",
                table: "ProductPriceListDetail",
                column: "ProductPriceListId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_PipelineId",
                table: "Stage",
                column: "PipelineId");

            migrationBuilder.CreateIndex(
                name: "IX_StageCheckedList_StageCustomFieldId",
                table: "StageCheckedList",
                column: "StageCustomFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_StageCheckedList_StageId",
                table: "StageCheckedList",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskTypeId",
                table: "Task",
                column: "TaskTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lead_Campaign_CampaignId",
                table: "Lead",
                column: "CampaignId",
                principalTable: "Campaign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lead_LeadSource_LeadSourceId",
                table: "Lead",
                column: "LeadSourceId",
                principalTable: "LeadSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lead_SalesUnit_SalesUnitId",
                table: "Lead",
                column: "SalesUnitId",
                principalTable: "SalesUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lead_Campaign_CampaignId",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "FK_Lead_LeadSource_LeadSourceId",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "FK_Lead_SalesUnit_SalesUnitId",
                table: "Lead");

            migrationBuilder.DropTable(
                name: "AccountAudit");

            migrationBuilder.DropTable(
                name: "AddressBook");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Call");

            migrationBuilder.DropTable(
                name: "CampaignAudit");

            migrationBuilder.DropTable(
                name: "CampaignLog");

            migrationBuilder.DropTable(
                name: "CampaignTracker");

            migrationBuilder.DropTable(
                name: "ContactAudit");

            migrationBuilder.DropTable(
                name: "ExchangeRateList");

            migrationBuilder.DropTable(
                name: "LeadAudit");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "OpportunityAudit");

            migrationBuilder.DropTable(
                name: "OpportunityProduct");

            migrationBuilder.DropTable(
                name: "ProductPriceListDetail");

            migrationBuilder.DropTable(
                name: "Reminder");

            migrationBuilder.DropTable(
                name: "StageCheckedList");

            migrationBuilder.DropTable(
                name: "Target");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "ExchangeRate");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductPriceList");

            migrationBuilder.DropTable(
                name: "StageCustomField");

            migrationBuilder.DropTable(
                name: "TaskType");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "Opportunity");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "LeadSource");

            migrationBuilder.DropTable(
                name: "LostReason");

            migrationBuilder.DropTable(
                name: "OpportunityType");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "Pipeline");

            migrationBuilder.DropTable(
                name: "SalesUnit");

            migrationBuilder.DropIndex(
                name: "IX_Lead_CampaignId",
                table: "Lead");

            migrationBuilder.DropIndex(
                name: "IX_Lead_LeadSourceId",
                table: "Lead");

            migrationBuilder.DropIndex(
                name: "IX_Lead_SalesUnitId",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "SalesUnitId",
                table: "Lead");
        }
    }
}
