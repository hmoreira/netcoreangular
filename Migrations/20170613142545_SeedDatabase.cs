using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name) values ('Make1')");
            migrationBuilder.Sql("Insert into Makes (Name) values ('Make2')");
            migrationBuilder.Sql("Insert into Makes (Name) values ('Make3')");

            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make1-ModelA', (select id from makes where name='Make1'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make1-ModelB',(select id from makes where name='Make1'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make1-ModelC',(select id from makes where name='Make1'))");

            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make2-ModelA',(select id from makes where name='Make2'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make2-ModelB',(select id from makes where name='Make2'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make2-ModelC',(select id from makes where name='Make2'))");

            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make3-ModelA',(select id from makes where name='Make3'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make3-ModelB',(select id from makes where name='Make3'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) values ('Make3-ModelC',(select id from makes where name='Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from models");
            migrationBuilder.Sql("delete from makes");
        }
    }
}
