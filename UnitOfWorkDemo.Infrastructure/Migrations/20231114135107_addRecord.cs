using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class addRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "PatientRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Bht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientCategories = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Surgery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndicationForAdmissionToTheICU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranexamicAcidGivenOrNot = table.Column<bool>(type: "bit", nullable: false),
                    PreOpBP_mmHg = table.Column<int>(type: "int", nullable: true),
                    PreOpHR_bpm = table.Column<int>(type: "int", nullable: true),
                    PreOpRR_bpm = table.Column<int>(type: "int", nullable: true),
                    PreOpBloodUrea_mg_dL = table.Column<int>(type: "int", nullable: true),
                    PreOpNa = table.Column<int>(type: "int", nullable: true),
                    PreOpK = table.Column<int>(type: "int", nullable: true),
                    PreOpSCcreatinine = table.Column<int>(type: "int", nullable: true),
                    PreOpHB_g_dL = table.Column<int>(type: "int", nullable: true),
                    PreOpWBC_103 = table.Column<int>(type: "int", nullable: true),
                    PreOpFBS_mg_dL = table.Column<int>(type: "int", nullable: true),
                    PreOpNeutrophilCount = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1BP = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1HR = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1RR = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1BloodUrea = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1SerumNa = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1SerumK = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1SerumCreatinine = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1HB = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1WBC = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1FBS_mg_dL = table.Column<int>(type: "int", nullable: true),
                    PostOpDay1Neutrophil = table.Column<int>(type: "int", nullable: true),
                    PostOpD3BP = table.Column<int>(type: "int", nullable: true),
                    PostOpD3HR = table.Column<int>(type: "int", nullable: true),
                    PostOpD3RR = table.Column<int>(type: "int", nullable: true),
                    PostOpD3BloodUrea = table.Column<int>(type: "int", nullable: true),
                    PostOpD3SerumNa = table.Column<int>(type: "int", nullable: true),
                    PostOpD3SerumK = table.Column<int>(type: "int", nullable: true),
                    PostOpD3SerumCreatinine = table.Column<int>(type: "int", nullable: true),
                    PostOpD3HB = table.Column<int>(type: "int", nullable: true),
                    PostOpD3WBC = table.Column<int>(type: "int", nullable: true),
                    PostOpD3FBS = table.Column<int>(type: "int", nullable: true),
                    PostOpD3NeutrophilCount_103_uL = table.Column<int>(type: "int", nullable: true),
                    PostOpD5BP = table.Column<int>(type: "int", nullable: true),
                    PostOpD5HR = table.Column<int>(type: "int", nullable: true),
                    PostOpD5RR = table.Column<int>(type: "int", nullable: true),
                    PostOpD5BloodUrea = table.Column<int>(type: "int", nullable: true),
                    PostOpD5SerumNa = table.Column<int>(type: "int", nullable: true),
                    PostOpD5SerumK = table.Column<int>(type: "int", nullable: true),
                    PostOpD5SerumCreatinine = table.Column<int>(type: "int", nullable: true),
                    PostOpD5HB = table.Column<int>(type: "int", nullable: true),
                    PostOpD5WBC = table.Column<int>(type: "int", nullable: true),
                    PostOpD5FBS = table.Column<int>(type: "int", nullable: true),
                    PostOpD5Neutrophil = table.Column<int>(type: "int", nullable: true),
                    Height_cm = table.Column<int>(type: "int", nullable: true),
                    Weight_kg = table.Column<int>(type: "int", nullable: true),
                    BMI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateofSurgery = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hypertension = table.Column<bool>(type: "bit", nullable: true),
                    DLD = table.Column<bool>(type: "bit", nullable: true),
                    DM = table.Column<bool>(type: "bit", nullable: true),
                    Thyroid = table.Column<bool>(type: "bit", nullable: true),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IschemicHeartDiseases = table.Column<bool>(type: "bit", nullable: true),
                    Other1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Other2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeripheralNeuropathies = table.Column<bool>(type: "bit", nullable: true),
                    Stroke = table.Column<bool>(type: "bit", nullable: true),
                    OtherBoneDissordersInLimbs_congenital = table.Column<bool>(type: "bit", nullable: true),
                    OtherBoneDissordersInLimbs_traumatic = table.Column<bool>(type: "bit", nullable: true),
                    HxOfOtherMSKInjuriesAndPains = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hepato_Gastrointestinal = table.Column<bool>(type: "bit", nullable: true),
                    Respiratory = table.Column<bool>(type: "bit", nullable: true),
                    Renal = table.Column<bool>(type: "bit", nullable: true),
                    other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerOperativeBloodLoss = table.Column<int>(type: "int", nullable: true),
                    BloodLossInTheDrainD2 = table.Column<int>(type: "int", nullable: true),
                    BloodLossInTheDrainD1_D2 = table.Column<int>(type: "int", nullable: true),
                    TorniquetTimeMin = table.Column<int>(type: "int", nullable: true),
                    NOofPostOpBloodTransfussions = table.Column<int>(type: "int", nullable: true),
                    N0ofPostOpFFPTransfussions = table.Column<int>(type: "int", nullable: true),
                    TotalOperativeRoomTime_min = table.Column<int>(type: "int", nullable: true),
                    BoneAvolsion = table.Column<bool>(type: "bit", nullable: true),
                    LigametAvulsions = table.Column<bool>(type: "bit", nullable: true),
                    IatrogenicFactors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperficialWoundInfections_1st = table.Column<int>(type: "int", nullable: true),
                    DeepWoundInfections_1st = table.Column<int>(type: "int", nullable: true),
                    QuadricepMuscleRupture_1st = table.Column<int>(type: "int", nullable: true),
                    SkinOpening_1st = table.Column<int>(type: "int", nullable: true),
                    FatEmbolism_1st = table.Column<int>(type: "int", nullable: true),
                    SurgicalWoundComplication_1st = table.Column<int>(type: "int", nullable: true),
                    Hematoma_1st = table.Column<int>(type: "int", nullable: true),
                    ChestComplications_1st = table.Column<int>(type: "int", nullable: true),
                    SuperficialWoundInfections_2nd = table.Column<int>(type: "int", nullable: true),
                    DeepWoundInfections_2nd = table.Column<int>(type: "int", nullable: true),
                    QuadricepMuscleRupture_2st = table.Column<int>(type: "int", nullable: true),
                    SkinOpening_2st = table.Column<int>(type: "int", nullable: true),
                    FatEmbolism_2st = table.Column<int>(type: "int", nullable: true),
                    SurgicalWoundComplication_2st = table.Column<int>(type: "int", nullable: true),
                    Hematoma_2st = table.Column<int>(type: "int", nullable: true),
                    ChestComplications_2st = table.Column<int>(type: "int", nullable: true),
                    SuperficialWoundInfections_Intermediate = table.Column<int>(type: "int", nullable: true),
                    DeepWoundInfections_Intermediate = table.Column<int>(type: "int", nullable: true),
                    QuadricepMuscleRupture_Intermediate = table.Column<int>(type: "int", nullable: true),
                    SkinOpening_Intermediate = table.Column<int>(type: "int", nullable: true),
                    FatEmbolism_Intermediate = table.Column<int>(type: "int", nullable: true),
                    SurgicalWoundComplication_Intermediate = table.Column<int>(type: "int", nullable: true),
                    Hematoma_Intermediate = table.Column<int>(type: "int", nullable: true),
                    ChestComplications_Intermediate = table.Column<int>(type: "int", nullable: true),
                    SuperficialWoundInfections_Late = table.Column<int>(type: "int", nullable: true),
                    DeepWoundInfections_Late = table.Column<int>(type: "int", nullable: true),
                    QuadricepMuscleRupture_Late = table.Column<int>(type: "int", nullable: true),
                    SkinOpening_Late = table.Column<int>(type: "int", nullable: true),
                    FatEmbolism_Late = table.Column<int>(type: "int", nullable: true),
                    SurgicalWoundComplication_Late = table.Column<int>(type: "int", nullable: true),
                    Hematoma_Late = table.Column<int>(type: "int", nullable: true),
                    ChestComplications_Late = table.Column<int>(type: "int", nullable: true),
                    PainTolerance_PostOpD1 = table.Column<int>(type: "int", nullable: true),
                    PainTolerance_beforeDischarge = table.Column<int>(type: "int", nullable: true),
                    NoofDaysInTheICU = table.Column<int>(type: "int", nullable: true),
                    EffectivenessInMobilization = table.Column<int>(type: "int", nullable: true),
                    NoofDaysInTheHospital = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRecord", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientRecord");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }
    }
}
