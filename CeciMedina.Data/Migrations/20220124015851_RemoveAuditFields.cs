using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CeciMedina.Data.Migrations
{
    public partial class RemoveAuditFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPedido_Pedidos_PedidoId",
                table: "DetallesPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPedido_Productos_ProductoId",
                table: "DetallesPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_FormasPago_FormaPagoId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Sucursales_SucursalId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Traslados");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Traslados");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Traslados");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Traslados");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "TrasladoInventarios");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TrasladoInventarios");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TrasladoInventarios");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "TrasladoInventarios");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Sucursales");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Sucursales");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Sucursales");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Sucursales");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "HistorialInventario");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "HistorialInventario");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "HistorialInventario");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "HistorialInventario");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "FormasPago");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FormasPago");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "FormasPago");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FormasPago");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "DetallesPedido");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DetallesPedido");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "DetallesPedido");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "DetallesPedido");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Categorias");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FormaPagoId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "DetallesPedido",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "DetallesPedido",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPedido_Pedidos_PedidoId",
                table: "DetallesPedido",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPedido_Productos_ProductoId",
                table: "DetallesPedido",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_FormasPago_FormaPagoId",
                table: "Pedidos",
                column: "FormaPagoId",
                principalTable: "FormasPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Sucursales_SucursalId",
                table: "Pedidos",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPedido_Pedidos_PedidoId",
                table: "DetallesPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPedido_Productos_ProductoId",
                table: "DetallesPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_FormasPago_FormaPagoId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Sucursales_SucursalId",
                table: "Pedidos");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Traslados",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Traslados",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Traslados",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Traslados",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "TrasladoInventarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TrasladoInventarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TrasladoInventarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "TrasladoInventarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Sucursales",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Sucursales",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Sucursales",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Sucursales",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Productos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Productos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Productos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "FormaPagoId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Pedidos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Pedidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Pedidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Pedidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Inventarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Inventarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Inventarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Inventarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "HistorialInventario",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "HistorialInventario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "HistorialInventario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "HistorialInventario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "FormasPago",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FormasPago",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "FormasPago",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FormasPago",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "DetallesPedido",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "DetallesPedido",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "DetallesPedido",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DetallesPedido",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "DetallesPedido",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "DetallesPedido",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Categorias",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categorias",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Categorias",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Categorias",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPedido_Pedidos_PedidoId",
                table: "DetallesPedido",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPedido_Productos_ProductoId",
                table: "DetallesPedido",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_FormasPago_FormaPagoId",
                table: "Pedidos",
                column: "FormaPagoId",
                principalTable: "FormasPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Sucursales_SucursalId",
                table: "Pedidos",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
