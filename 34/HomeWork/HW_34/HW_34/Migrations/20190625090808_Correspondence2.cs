using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW_34.Migrations
{
    public partial class Correspondence2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Positions_PositionId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostelItemId",
                table: "SendingStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendingStatuses",
                table: "SendingStatuses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SendingStatuses");

            migrationBuilder.RenameColumn(
                name: "PostelItemId",
                table: "SendingStatuses",
                newName: "PostalItemId");

            migrationBuilder.RenameIndex(
                name: "IX_SendingStatuses_PostelItemId",
                table: "SendingStatuses",
                newName: "IX_SendingStatuses_PostalItemId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Statuses",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PostalItems",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Positions",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Contractors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contractors",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Adresses",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Adresses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendingStatuses",
                table: "SendingStatuses",
                column: "UpdateStatusDateTime");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_Positions_PositionId",
                table: "Contractors",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostalItemId",
                table: "SendingStatuses",
                column: "PostalItemId",
                principalTable: "PostalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Positions_PositionId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostalItemId",
                table: "SendingStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendingStatuses",
                table: "SendingStatuses");

            migrationBuilder.RenameColumn(
                name: "PostalItemId",
                table: "SendingStatuses",
                newName: "PostelItemId");

            migrationBuilder.RenameIndex(
                name: "IX_SendingStatuses_PostalItemId",
                table: "SendingStatuses",
                newName: "IX_SendingStatuses_PostelItemId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Statuses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SendingStatuses",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PostalItems",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Positions",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Contractors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contractors",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Adresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Adresses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendingStatuses",
                table: "SendingStatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_Positions_PositionId",
                table: "Contractors",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendingStatuses_PostalItems_PostelItemId",
                table: "SendingStatuses",
                column: "PostelItemId",
                principalTable: "PostalItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
