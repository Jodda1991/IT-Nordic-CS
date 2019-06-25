using Microsoft.EntityFrameworkCore.Migrations;

namespace HW_34.Migrations
{
    public partial class Correspondence5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostalItemId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Adresses_ReceivingAddressId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Contractors_ReceivingContractorId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Adresses_SendingAddressId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Contractors_SendingContractorId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Statuses_StatusId",
                table: "SendingStatuses");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "SendingStatuses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SendingContractorId",
                table: "SendingStatuses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SendingAddressId",
                table: "SendingStatuses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceivingContractorId",
                table: "SendingStatuses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceivingAddressId",
                table: "SendingStatuses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostalItemId",
                table: "SendingStatuses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostalItemId",
                table: "SendingStatuses",
                column: "PostalItemId",
                principalTable: "PostalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Adresses_ReceivingAddressId",
                table: "SendingStatuses",
                column: "ReceivingAddressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Contractors_ReceivingContractorId",
                table: "SendingStatuses",
                column: "ReceivingContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Adresses_SendingAddressId",
                table: "SendingStatuses",
                column: "SendingAddressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Contractors_SendingContractorId",
                table: "SendingStatuses",
                column: "SendingContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Statuses_StatusId",
                table: "SendingStatuses",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostalItemId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Adresses_ReceivingAddressId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Contractors_ReceivingContractorId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Adresses_SendingAddressId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Contractors_SendingContractorId",
                table: "SendingStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_Statuses_StatusId",
                table: "SendingStatuses");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "SendingStatuses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SendingContractorId",
                table: "SendingStatuses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SendingAddressId",
                table: "SendingStatuses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReceivingContractorId",
                table: "SendingStatuses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReceivingAddressId",
                table: "SendingStatuses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PostalItemId",
                table: "SendingStatuses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostalItemId",
                table: "SendingStatuses",
                column: "PostalItemId",
                principalTable: "PostalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Adresses_ReceivingAddressId",
                table: "SendingStatuses",
                column: "ReceivingAddressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Contractors_ReceivingContractorId",
                table: "SendingStatuses",
                column: "ReceivingContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Adresses_SendingAddressId",
                table: "SendingStatuses",
                column: "SendingAddressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Contractors_SendingContractorId",
                table: "SendingStatuses",
                column: "SendingContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_Statuses_StatusId",
                table: "SendingStatuses",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
