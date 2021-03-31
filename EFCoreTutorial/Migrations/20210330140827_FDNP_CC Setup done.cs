using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTutorial.Migrations
{
    public partial class FDNP_CCSetupdone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FDNP_Group_CC_FDNP_Process_CC_ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC");

            migrationBuilder.DropIndex(
                name: "IX_FDNP_Group_CC_ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC");

            migrationBuilder.DropColumn(
                name: "ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC");

            migrationBuilder.AddColumn<int>(
                name: "FDNP_Process_CC_Id1",
                table: "FDNP_Group_CC",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FDNP_Blog_CC",
                columns: table => new
                {
                    FDNP_Blog_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FDNP_Process_CCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Blog_CC", x => x.FDNP_Blog_CC_Id);
                    table.ForeignKey(
                        name: "FK_FDNP_Blog_CC_FDNP_Process_CC_FDNP_Process_CCId",
                        column: x => x.FDNP_Process_CCId,
                        principalTable: "FDNP_Process_CC",
                        principalColumn: "FDNP_Process_CC_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_Tag_CC",
                columns: table => new
                {
                    FDNP_Tag_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Tag_CC", x => x.FDNP_Tag_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_Blogger_CC",
                columns: table => new
                {
                    FDNP_Blogger_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FDNP_Blog_CC_Id1 = table.Column<int>(nullable: true),
                    FDNP_Blog_CC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Blogger_CC", x => x.FDNP_Blogger_CC_Id);
                    table.ForeignKey(
                        name: "FK_FDNP_Blogger_CC_FDNP_Blog_CC_FDNP_Blog_CC_Id1",
                        column: x => x.FDNP_Blog_CC_Id1,
                        principalTable: "FDNP_Blog_CC",
                        principalColumn: "FDNP_Blog_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_Post_CC",
                columns: table => new
                {
                    FDNP_Post_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FDNP_Blog_CC_Id1 = table.Column<int>(nullable: true),
                    FDNP_Blog_CC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Post_CC", x => x.FDNP_Post_CC_Id);
                    table.ForeignKey(
                        name: "FK_FDNP_Post_CC_FDNP_Blog_CC_FDNP_Blog_CC_Id1",
                        column: x => x.FDNP_Blog_CC_Id1,
                        principalTable: "FDNP_Blog_CC",
                        principalColumn: "FDNP_Blog_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_Address_CC",
                columns: table => new
                {
                    FDNP_Address_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FDNP_Blogger_CCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Address_CC", x => x.FDNP_Address_CC_Id);
                    table.ForeignKey(
                        name: "FK_FDNP_Address_CC_FDNP_Blogger_CC_FDNP_Blogger_CCId",
                        column: x => x.FDNP_Blogger_CCId,
                        principalTable: "FDNP_Blogger_CC",
                        principalColumn: "FDNP_Blogger_CC_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_PostTag_CC",
                columns: table => new
                {
                    FDNP_Post_CCId = table.Column<int>(nullable: false),
                    FDNP_Tag_CCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_PostTag_CC", x => new { x.FDNP_Post_CCId, x.FDNP_Tag_CCId });
                    table.ForeignKey(
                        name: "FK_FDNP_PostTag_CC_FDNP_Post_CC_FDNP_Post_CCId",
                        column: x => x.FDNP_Post_CCId,
                        principalTable: "FDNP_Post_CC",
                        principalColumn: "FDNP_Post_CC_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FDNP_PostTag_CC_FDNP_Tag_CC_FDNP_Tag_CCId",
                        column: x => x.FDNP_Tag_CCId,
                        principalTable: "FDNP_Tag_CC",
                        principalColumn: "FDNP_Tag_CC_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Group_CC_FDNP_Process_CC_Id1",
                table: "FDNP_Group_CC",
                column: "FDNP_Process_CC_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Address_CC_FDNP_Blogger_CCId",
                table: "FDNP_Address_CC",
                column: "FDNP_Blogger_CCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Blog_CC_FDNP_Process_CCId",
                table: "FDNP_Blog_CC",
                column: "FDNP_Process_CCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Blogger_CC_FDNP_Blog_CC_Id1",
                table: "FDNP_Blogger_CC",
                column: "FDNP_Blog_CC_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Post_CC_FDNP_Blog_CC_Id1",
                table: "FDNP_Post_CC",
                column: "FDNP_Blog_CC_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_PostTag_CC_FDNP_Tag_CCId",
                table: "FDNP_PostTag_CC",
                column: "FDNP_Tag_CCId");

            migrationBuilder.AddForeignKey(
                name: "FK_FDNP_Group_CC_FDNP_Process_CC_FDNP_Process_CC_Id1",
                table: "FDNP_Group_CC",
                column: "FDNP_Process_CC_Id1",
                principalTable: "FDNP_Process_CC",
                principalColumn: "FDNP_Process_CC_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FDNP_Group_CC_FDNP_Process_CC_FDNP_Process_CC_Id1",
                table: "FDNP_Group_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Address_CC");

            migrationBuilder.DropTable(
                name: "FDNP_PostTag_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Blogger_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Post_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Tag_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Blog_CC");

            migrationBuilder.DropIndex(
                name: "IX_FDNP_Group_CC_FDNP_Process_CC_Id1",
                table: "FDNP_Group_CC");

            migrationBuilder.DropColumn(
                name: "FDNP_Process_CC_Id1",
                table: "FDNP_Group_CC");

            migrationBuilder.AddColumn<int>(
                name: "ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Group_CC_ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC",
                column: "ProcessFDNP_Process_CC_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FDNP_Group_CC_FDNP_Process_CC_ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC",
                column: "ProcessFDNP_Process_CC_Id",
                principalTable: "FDNP_Process_CC",
                principalColumn: "FDNP_Process_CC_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
