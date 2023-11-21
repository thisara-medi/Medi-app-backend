using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class setnullablereasonid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecord_Reason_ReasonID",
                table: "PatientRecord");

            migrationBuilder.AlterColumn<long>(
                name: "ReasonID",
                table: "PatientRecord",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecord_Reason_ReasonID",
                table: "PatientRecord",
                column: "ReasonID",
                principalTable: "Reason",
                principalColumn: "ReasonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecord_Reason_ReasonID",
                table: "PatientRecord");

            migrationBuilder.AlterColumn<long>(
                name: "ReasonID",
                table: "PatientRecord",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecord_Reason_ReasonID",
                table: "PatientRecord",
                column: "ReasonID",
                principalTable: "Reason",
                principalColumn: "ReasonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
