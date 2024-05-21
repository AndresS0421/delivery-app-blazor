using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3Parcial.Migrations
{
    /// <inheritdoc />
    public partial class StopsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryRouteVehiculo",
                columns: table => new
                {
                    RoutesId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryRouteVehiculo", x => new { x.RoutesId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_DeliveryRouteVehiculo_Routes_RoutesId",
                        column: x => x.RoutesId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryRouteVehiculo_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stops_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryRouteStops",
                columns: table => new
                {
                    RoutesId = table.Column<int>(type: "int", nullable: false),
                    StopsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryRouteStops", x => new { x.RoutesId, x.StopsId });
                    table.ForeignKey(
                        name: "FK_DeliveryRouteStops_Routes_RoutesId",
                        column: x => x.RoutesId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryRouteStops_Stops_StopsId",
                        column: x => x.StopsId,
                        principalTable: "Stops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryRouteStops_StopsId",
                table: "DeliveryRouteStops",
                column: "StopsId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryRouteVehiculo_VehiclesId",
                table: "DeliveryRouteVehiculo",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stops_LocationId",
                table: "Stops",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryRouteStops");

            migrationBuilder.DropTable(
                name: "DeliveryRouteVehiculo");

            migrationBuilder.DropTable(
                name: "Stops");
        }
    }
}
