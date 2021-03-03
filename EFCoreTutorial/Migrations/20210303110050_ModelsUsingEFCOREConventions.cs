using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTutorial.Migrations
{
    public partial class ModelsUsingEFCOREConventions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FDNP_Process_CC",
                columns: table => new
                {
                    FDNP_Process_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Process_CC", x => x.FDNP_Process_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "SCNP_Process_CC",
                columns: table => new
                {
                    SCNP_Process_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCNP_Process_CC", x => x.SCNP_Process_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "SCNPFK_Process_CC",
                columns: table => new
                {
                    SCNPFK_Process_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCNPFK_Process_CC", x => x.SCNPFK_Process_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "SRNP_Process_CC",
                columns: table => new
                {
                    SRNP_Process_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRNP_Process_CC", x => x.SRNP_Process_CC_Id);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_Group_CC",
                columns: table => new
                {
                    FDNP_Group_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProcessFDNP_Process_CC_Id = table.Column<int>(nullable: true),
                    FDNP_Process_CC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Group_CC", x => x.FDNP_Group_CC_Id);
                    table.ForeignKey(
                        name: "FK_FDNP_Group_CC_FDNP_Process_CC_ProcessFDNP_Process_CC_Id",
                        column: x => x.ProcessFDNP_Process_CC_Id,
                        principalTable: "FDNP_Process_CC",
                        principalColumn: "FDNP_Process_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SCNP_Group_CC",
                columns: table => new
                {
                    SCNP_Group_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SCNP_Process_CC_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCNP_Group_CC", x => x.SCNP_Group_CC_Id);
                    table.ForeignKey(
                        name: "FK_SCNP_Group_CC_SCNP_Process_CC_SCNP_Process_CC_Id",
                        column: x => x.SCNP_Process_CC_Id,
                        principalTable: "SCNP_Process_CC",
                        principalColumn: "SCNP_Process_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SCNPFK_Group_CC",
                columns: table => new
                {
                    SCNPFK_Group_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SCNPFK_Process_CC_Id = table.Column<int>(nullable: false),
                    SCNPFK_Process_CC_Id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCNPFK_Group_CC", x => x.SCNPFK_Group_CC_Id);
                    table.ForeignKey(
                        name: "FK_SCNPFK_Group_CC_SCNPFK_Process_CC_SCNPFK_Process_CC_Id1",
                        column: x => x.SCNPFK_Process_CC_Id1,
                        principalTable: "SCNPFK_Process_CC",
                        principalColumn: "SCNPFK_Process_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SRNP_Group_CC",
                columns: table => new
                {
                    SRNP_Group_CC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProcessSRNP_Process_CC_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRNP_Group_CC", x => x.SRNP_Group_CC_Id);
                    table.ForeignKey(
                        name: "FK_SRNP_Group_CC_SRNP_Process_CC_ProcessSRNP_Process_CC_Id",
                        column: x => x.ProcessSRNP_Process_CC_Id,
                        principalTable: "SRNP_Process_CC",
                        principalColumn: "SRNP_Process_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FDNP_Point_CC",
                columns: table => new
                {
                    FDNP_Point_CC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GroupFDNP_Group_CC_Id = table.Column<int>(nullable: true),
                    FDNP_Group_CC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDNP_Point_CC", x => x.FDNP_Point_CC_ID);
                    table.ForeignKey(
                        name: "FK_FDNP_Point_CC_FDNP_Group_CC_GroupFDNP_Group_CC_Id",
                        column: x => x.GroupFDNP_Group_CC_Id,
                        principalTable: "FDNP_Group_CC",
                        principalColumn: "FDNP_Group_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SCNP_Point_CC",
                columns: table => new
                {
                    SCNP_Point_CC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SCNP_Group_CC_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCNP_Point_CC", x => x.SCNP_Point_CC_ID);
                    table.ForeignKey(
                        name: "FK_SCNP_Point_CC_SCNP_Group_CC_SCNP_Group_CC_Id",
                        column: x => x.SCNP_Group_CC_Id,
                        principalTable: "SCNP_Group_CC",
                        principalColumn: "SCNP_Group_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SCNPFK_Point_CC",
                columns: table => new
                {
                    SCNPFK_Point_CC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SCNPFK_Group_CC_Id = table.Column<int>(nullable: false),
                    SCNPFK_Group_CC_Id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCNPFK_Point_CC", x => x.SCNPFK_Point_CC_ID);
                    table.ForeignKey(
                        name: "FK_SCNPFK_Point_CC_SCNPFK_Group_CC_SCNPFK_Group_CC_Id1",
                        column: x => x.SCNPFK_Group_CC_Id1,
                        principalTable: "SCNPFK_Group_CC",
                        principalColumn: "SCNPFK_Group_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SRNP_Point_CC",
                columns: table => new
                {
                    SRNP_Point_CC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GroupSRNP_Group_CC_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRNP_Point_CC", x => x.SRNP_Point_CC_ID);
                    table.ForeignKey(
                        name: "FK_SRNP_Point_CC_SRNP_Group_CC_GroupSRNP_Group_CC_Id",
                        column: x => x.GroupSRNP_Group_CC_Id,
                        principalTable: "SRNP_Group_CC",
                        principalColumn: "SRNP_Group_CC_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Group_CC_ProcessFDNP_Process_CC_Id",
                table: "FDNP_Group_CC",
                column: "ProcessFDNP_Process_CC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FDNP_Point_CC_GroupFDNP_Group_CC_Id",
                table: "FDNP_Point_CC",
                column: "GroupFDNP_Group_CC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SCNP_Group_CC_SCNP_Process_CC_Id",
                table: "SCNP_Group_CC",
                column: "SCNP_Process_CC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SCNP_Point_CC_SCNP_Group_CC_Id",
                table: "SCNP_Point_CC",
                column: "SCNP_Group_CC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SCNPFK_Group_CC_SCNPFK_Process_CC_Id1",
                table: "SCNPFK_Group_CC",
                column: "SCNPFK_Process_CC_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_SCNPFK_Point_CC_SCNPFK_Group_CC_Id1",
                table: "SCNPFK_Point_CC",
                column: "SCNPFK_Group_CC_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_SRNP_Group_CC_ProcessSRNP_Process_CC_Id",
                table: "SRNP_Group_CC",
                column: "ProcessSRNP_Process_CC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SRNP_Point_CC_GroupSRNP_Group_CC_Id",
                table: "SRNP_Point_CC",
                column: "GroupSRNP_Group_CC_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FDNP_Point_CC");

            migrationBuilder.DropTable(
                name: "SCNP_Point_CC");

            migrationBuilder.DropTable(
                name: "SCNPFK_Point_CC");

            migrationBuilder.DropTable(
                name: "SRNP_Point_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Group_CC");

            migrationBuilder.DropTable(
                name: "SCNP_Group_CC");

            migrationBuilder.DropTable(
                name: "SCNPFK_Group_CC");

            migrationBuilder.DropTable(
                name: "SRNP_Group_CC");

            migrationBuilder.DropTable(
                name: "FDNP_Process_CC");

            migrationBuilder.DropTable(
                name: "SCNP_Process_CC");

            migrationBuilder.DropTable(
                name: "SCNPFK_Process_CC");

            migrationBuilder.DropTable(
                name: "SRNP_Process_CC");
        }
    }
}
