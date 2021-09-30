using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceApi.Migrations
{
    public partial class AddProductsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products VALUES('Shirt','Black Shirt','Clothing',12.5,12,4)");
            migrationBuilder.Sql("INSERT INTO Products VALUES('T-Shirt','White Collared T-Shirt','Clothing',22.5,20,4)");
            migrationBuilder.Sql("INSERT INTO Products VALUES('Laptop - Dell','Dell Laptop','Electronics',500,10,4)");
            migrationBuilder.Sql("INSERT INTO Products VALUES('iPhone','iPhone 13','Electronics',700,5,5)");
            migrationBuilder.Sql("INSERT INTO Products VALUES('Laptop - Asus','Asus Laptop','Electronics',700,10,4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
