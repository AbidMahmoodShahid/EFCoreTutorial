using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTutorial.Migrations
{
    public partial class ModelsUsingAllEFCOREConventions_Correct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NNPFK_Group_CC",
                columns: table => new
                {
                    NNPFK_Group_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NNPFK_Group_CC", x => x.NNPFK_Group_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "NNPFK_Point_CC",
                columns: table => new
                {
                    NNPFK_Point_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NNPFK_Point_CC", x => x.NNPFK_Point_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "NNPFK_Process_CC",
                columns: table => new
                {
                    NNPFK_Process_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NNPFK_Process_CC", x => x.NNPFK_Process_CC_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NNPFK_Group_CC");

            migrationBuilder.DropTable(
                name: "NNPFK_Point_CC");

            migrationBuilder.DropTable(
                name: "NNPFK_Process_CC");
        }
    }
}
