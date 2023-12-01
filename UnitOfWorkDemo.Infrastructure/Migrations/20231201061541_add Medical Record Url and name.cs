using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class addMedicalRecordUrlandname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MedicalRecordUrl",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "medicalRecordFileName",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GetPatientStatisticsDto",
                columns: table => new
                {
                    TotalPatients = table.Column<int>(type: "int", nullable: false),
                    NewPatientsToday = table.Column<int>(type: "int", nullable: false),
                    NewPatientsThisWeek = table.Column<int>(type: "int", nullable: false),
                    ActivePatients = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetPatientStatisticsDto");

            migrationBuilder.DropColumn(
                name: "MedicalRecordUrl",
                table: "PatientRecord");

            migrationBuilder.DropColumn(
                name: "medicalRecordFileName",
                table: "PatientRecord");
        }
    }
}
