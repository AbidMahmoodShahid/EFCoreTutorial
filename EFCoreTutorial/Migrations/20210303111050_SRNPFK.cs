using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTutorial.Migrations
{
    public partial class SRNPFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SRNPFK_Process_CC",
                columns: table => new
                {
                    SRNPFK_Process_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRNPFK_Process_CC", x => x.SRNPFK_Process_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "SRNPFK_Group_CC",
                columns: table => new
                {
                    SRNPFK_Group_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProcessSRNPFK_Process_CC_Id = table.Column<int>(nullable: true),
                    SRNPFK_Process_CC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRNPFK_Group_CC", x => x.SRNPFK_Group_CC_Id);
                    table.ForeignKey(
                        name: "FK_SRNPFK_Group_CC_SRNPFK_Process_CC_ProcessSRNPFK_Process_CC_Id",
                        column: x => x.ProcessSRNPFK_Process_CC_Id,
                        principalTable: "SRNPFK_Process_CC",
                        principalColumn: "SRNPFK_Process_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SRNPFK_Point_CC",
                columns: table => new
                {
                    SRNPFK_Point_CC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GroupSRNPFK_Group_CC_Id = table.Column<int>(nullable: true),
                    SRNPFK_Group_CC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRNPFK_Point_CC", x => x.SRNPFK_Point_CC_ID);
                    table.ForeignKey(
                        name: "FK_SRNPFK_Point_CC_SRNPFK_Group_CC_GroupSRNPFK_Group_CC_Id",
                        column: x => x.GroupSRNPFK_Group_CC_Id,
                        principalTable: "SRNPFK_Group_CC",
                        principalColumn: "SRNPFK_Group_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SRNPFK_Group_CC_ProcessSRNPFK_Process_CC_Id",
                table: "SRNPFK_Group_CC",
                column: "ProcessSRNPFK_Process_CC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SRNPFK_Point_CC_GroupSRNPFK_Group_CC_Id",
                table: "SRNPFK_Point_CC",
                column: "GroupSRNPFK_Group_CC_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SRNPFK_Point_CC");

            migrationBuilder.DropTable(
                name: "SRNPFK_Group_CC");

            migrationBuilder.DropTable(
                name: "SRNPFK_Process_CC");
        }
    }
}
