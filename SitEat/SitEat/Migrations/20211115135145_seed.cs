using Microsoft.EntityFrameworkCore.Migrations;

namespace SitEat.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "OpeningTimes" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum blah blah blah", "", "Marco Polo", "" },
                    { 2, "Lorem ipsum blah blah blah", "", "Restaurant number 2", "" },
                    { 3, "Lorem ipsum blah blah blah", "", "Family Place", "" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Greek" },
                    { 2, "Pizzeria" },
                    { 3, "Vegetarian" },
                    { 4, "Chinese" },
                    { 5, "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Item-R1-A", 1.23m, 1 },
                    { 22, "Item-R3-F", 100.23m, 3 },
                    { 21, "Item-R3-E", 100.23m, 3 },
                    { 20, "Item-R3-D", 100.23m, 3 },
                    { 19, "Item-R3-C", 100.23m, 3 },
                    { 18, "Item-R3-B", 100.23m, 3 },
                    { 17, "Item-R3-A", 100.23m, 3 },
                    { 16, "Item-R2-H", 10.23m, 2 },
                    { 15, "Item-R2-G", 10.23m, 2 },
                    { 14, "Item-R2-F", 10.23m, 2 },
                    { 13, "Item-R2-E", 10.23m, 2 },
                    { 23, "Item-R3-G", 100.23m, 3 },
                    { 11, "Item-R2-C", 10.23m, 2 },
                    { 10, "Item-R2-B", 10.23m, 2 },
                    { 12, "Item-R2-D", 10.23m, 2 },
                    { 24, "Item-R3-H", 100.23m, 3 },
                    { 2, "Item-R1-B", 1.23m, 1 },
                    { 3, "Item-R1-C", 1.23m, 1 },
                    { 4, "Item-R1-D", 1.23m, 1 },
                    { 5, "Item-R1-E", 1.23m, 1 },
                    { 6, "Item-R1-F", 1.23m, 1 },
                    { 8, "Item-R1-H", 1.23m, 1 },
                    { 7, "Item-R1-G", 1.23m, 1 },
                    { 9, "Item-R2-A", 10.23m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Author", "RestaurantId", "Score", "Text" },
                values: new object[,]
                {
                    { 11, "Karol", 2, 5, "I enjoyed every bit of it!" },
                    { 9, "Ian", 2, 3, "Not great, not terrible" },
                    { 8, "Helga", 2, 1, "I'm not saying that this place sells s***, but I wouldn't eat it again." },
                    { 7, "Gregory", 2, 5, "Just wonderful!" },
                    { 1, "Arnold", 1, 1, "It sucks!" },
                    { 2, "Bernard", 1, 5, "Great place, would certainly eat at again." },
                    { 3, "Ciril", 1, 3, "If only they had more variety. The quality is decent but I got bored of their food already." },
                    { 4, "Dionisius", 1, 2, "Meh." },
                    { 5, "Ergon", 1, 5, "I love this place! <3" },
                    { 10, "Jeremy", 2, 5, "Truly amazing place, never ate such good food" },
                    { 6, "Fred", 1, 4, "Decent food. Pretty cheap too." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
