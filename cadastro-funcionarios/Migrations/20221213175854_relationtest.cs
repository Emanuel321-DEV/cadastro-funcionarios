using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastro_funcionarios.Migrations
{
    public partial class relationtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Employee_EmployeeId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_EmployeeId",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Address",
                newName: "EmployeeForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployeeForeignKey",
                table: "Address",
                column: "EmployeeForeignKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Employee_EmployeeForeignKey",
                table: "Address",
                column: "EmployeeForeignKey",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Employee_EmployeeForeignKey",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_EmployeeForeignKey",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "EmployeeForeignKey",
                table: "Address",
                newName: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployeeId",
                table: "Address",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Employee_EmployeeId",
                table: "Address",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
