using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCHOT2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescShort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductQty = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Accessories" },
                    { 2, "Bikes" },
                    { 3, "Clothing" },
                    { 4, "Car Racks" },
                    { 5, "Wheels" },
                    { 6, "Components" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CustomerCity", "CustomerFirstName", "CustomerLastName", "CustomerPhoneNumber", "CustomerState", "CustomerStreetAddress", "CustomerZipCode" },
                values: new object[,]
                {
                    { 1, "Redmond", "Suzanne", "Viescas", "425-555-2686", "WA", "15127 NE 24th, #383", "98052" },
                    { 2, "Duvall", "William", "Thompson", "425-555-2681", "WA", "122 Spring River Drive", "98019" },
                    { 3, "Auburn", "Gary", "Hallmark", "253-555-2676", "WA", "Route 2 Road", "98002" },
                    { 4, "Houston", "Robert", "Brown", "713-555-2491", "TX", "672 Lamont Ave", "77201" },
                    { 5, "Redmond", "Dean", "McCrae", "425-555-2506", "WA", "4110 Redmond Rd.", "98052" },
                    { 6, "Redmond", "John", "Viescas", "425-555-2511", "WA", "15127 NE 24th, #383", "98052" },
                    { 7, "Portland", "Mariya", "Sergienko", "503-555-2526", "OR", "901 Pine Avenue", "97208" },
                    { 8, "San Diego", "Neil", "Patterson", "619-555-2541", "CA", "233 West Valley Hwy", "92199" },
                    { 9, "Seattle", "Andrew", "Cencini", "206-555-2601", "WA", "507 - 20th Ave. E. Apt. 2A", "98105" },
                    { 10, "Austin", "Angel", "Kennedy", "512-555-2571", "TX", "667 Red River Road", "78710" },
                    { 11, "Woodinville", "Alaina", "Hallmark", "425-555-2631", "WA", "Route 2, Box 203B", "98072" },
                    { 12, "Bellevue", "Liz", "Keyser", "425-555-2556", "WA", "13920 S.E. 40th Street", "98006" },
                    { 13, "San Diego", "Rachel", "Patterson", "619-555-2546", "CA", "2114 Longview Lane", "92199" },
                    { 14, "Palm Springs", "Sam", "Abolrous", "760-555-2611", "CA", "611 Alpine Drive", "92263" },
                    { 15, "Chico", "Darren", "Gehring", "530-555-2616", "CA", "2601 Seaview Lane", "95926" },
                    { 16, "Salem", "Jim", "Wilson", "503-555-2636", "OR", "101 NE 88th", "97301" },
                    { 17, "Medford", "Manuela", "Seidel", "541-555-2641", "OR", "66 Spring Valley Drive", "97501" },
                    { 18, "Fremont", "David", "Smith", "510-555-2646", "CA", "311 20th Ave. N.E.", "94538" },
                    { 19, "Glendale", "Zachary", "Ehrlich", "818-555-2721", "CA", "12330 Kingman Drive", "91209" },
                    { 20, "Bellevue", "Joyce", "Bonnicksen", "425-555-2726", "WA", "2424 Thames Drive", "98006" },
                    { 21, "Dallas", "Estella", "Pundt", "972-555-9938", "TX", "2500 Rosales Lane", "75260" },
                    { 22, "Long Beach", "Caleb", "Viescas", "562-555-0037", "CA", "4501 Wetland Road", "90809" },
                    { 23, "Seattle", "Julia", "Schnebly", "206-555-9936", "WA", "2343 Harmony Lane", "99837" },
                    { 24, "El Paso", "Mark", "Rosales", "915-555-2286", "TX", "323 Advocate Lane", "79915" },
                    { 25, "El Paso", "Maria", "Patterson", "915-555-2291", "TX", "3445 Cheyenne Road", "79915" },
                    { 26, "San Antonio", "Kirk", "DeGrasse", "210-555-2311", "TX", "455 West Palm Ave", "78284" },
                    { 27, "Portland", "Luke", "Patterson", "503-555-2316", "OR", "877 145th Ave SE", "97208" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ProductDescLong", "ProductDescShort", "ProductName", "ProductPrice", "ProductQty" },
                values: new object[,]
                {
                    { 1, 1, "This is a fun flowy trail! The trail starts with a test- a skinny with a 2 ft. The area is mostly wooded but there are several places that offer spectacular views.", "ATB Wheels", "AeroFlo ATB Wheels", 189m, 40 },
                    { 2, 2, "There is no preferred direction and the trail is a great connector for several other fun loops. Two wheel drifting is likely if you have speed.", "85-T Glasses", "Clear Shade 85-T Glasses", 45m, 14 },
                    { 3, 3, "Rowdy little downhill/freeride track. 16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008.", "Road Warrior Wheels", "Cosmic Elite Road Warrior Wheels", 165m, 22 },
                    { 4, 4, "The State of Alaska installed a more user friendly course in 2012. Mostly dry with some small mud puddles. The trails are well drained and suitable for riding when wet.", "Repair Stand", "Cycle-Doc Pro Repair Stand", 166m, 12 },
                    { 5, 5, "It packs in a lot of excitement in a short amount of time. IMO it is a better ride to turn around and follow the same trail down. Removable by hand saw.", "Floor Pump", "Dog Ear Aero-Flow Floor Pump", 5m, 25 },
                    { 6, 6, "This is just a brute of a climb. Short and fast, with a few small jumps and some loose rocks to keep you on your toes.", "Cycle Computer", "Dog Ear Cycle Computer", 75m, 20 },
                    { 7, 1, "There may be an optional dropspot 1/2 way down. The turns may be smooth berms that will be easy riding. It has few real technical features.", "Helmet Mirrors", "Dog Ear Helmet Mount Mirrors", 7.45m, 12 },
                    { 8, 2, "Since being redesigned, it is a lot of fun to ride this glassy smooth and generally well-bermed trail. Logs embedded in the trail have been installed.", "Grip Gloves", "Dog Ear Monster Grip Gloves", 15m, 30 },
                    { 9, 3, "Installed to signal technical terrain. This trail begins with a small pump section with two smaller jumps and a third larger hip jump.", "Mountain Bike", "Eagle FS-3 Mountain Bike", 1800m, 8 },
                    { 10, 4, "Fun! Chewed up, lots of braking bumps, but still fun. Winding trail with dips, climbs and descents. The turns are all smooth berms and easy to ride.", "Clipless Pedals", "Eagle SA-120 Clipless Pedals", 139.95m, 20 },
                    { 11, 5, "Easy to ride and not wash out. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.", "Cycling Helmet", "Glide-O-Matic Cycling Helmet", 125m, 24 },
                    { 12, 6, "MBoSC has partnered with land manager California Department of Forestry and Fire Protection (CAL FIRE) to build a four mile flow trail in Soquel Demonstration State Forest (SDSF).", "Mountain Bike", "GT RTS-2 Mountain Bike", 1650m, 5 },
                    { 13, 1, "Large group of trees down on northern section of trail, between buckhorn and club gap. There is no preferred direction and the trail is a great connector for several other fun loops.", "Panniers", "HP Deluxe Panniers", 39m, 10 },
                    { 14, 2, "This area has a high density of trails for all ability levels and serves as the unofficial hub of mountain bike activity in the South Shore.", "Helmet", "King Cobra Helmet", 139m, 30 },
                    { 15, 3, "Mountain bike activity in the South Shore. By the end of the 45-50 miles youll be plenty tired from the constant up and down nature of Mana Road.", "Kool Breeze Rocket Top Jersey", "Kool Breeze Rocket Top Jersey", 4.99m, 40 },
                    { 16, 4, "16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008, the State of Alaska installed a more user friendly course in 2012.", "2000 U-Lock", "Kryptonite Advanced 2000 U-Lock", 50m, 20 },
                    { 17, 5, "Third Divide makes up part of the classic Downieville downhill route. A little overgrown on the seward side, but totlaly manageable.", "U-Lock", "Nikoma Lok-Tight U-Lock", 33m, 12 },
                    { 18, 6, "Overgrown on the seward side, but totlaly manageable. Trail full of berms and fun features! But this trail does not relent for one second.", "ATB Pedal", "ProFormance ATB All-Terrain Pedal", 28m, 40 },
                    { 19, 1, "It doesnt get much use though so is sometimes a bit overgrown. Out here you will find the most legal features including log rides.", "Toe Klips", "ProFormance Toe Klips 2G", 28m, 40 },
                    { 20, 2, "Jumps and rock rolls in South Tahoe including the new jumps, berms, rollers and hips TAMBA and SBTS built in 2014. As the valley begins to close", "Dillo Shades", "Pro-Sport Dillo Shades", 82m, 18 },
                    { 21, 3, "The route transitions to a section of open forest. Trail contains a rope-suspended ladder bridge, elevated bridges and a long-straight skinny.", "Hitch Pack", "Road Warrior Hitch Pack", 175m, 6 },
                    { 22, 4, "Elevated bridges and a long-straight skinny. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.", "SC Brakes", "Shinoman 105 SC Brakes", 23.50m, 16 },
                    { 23, 5, "The trail is somewhat wide for singletrack and a bit technical with roots and rocks. Several high speed, low risk sections take you down the sandy open trail.", "TX-30 Pedal", "Shinoman Deluxe TX-30 Pedal", 45m, 60 },
                    { 24, 6, "The sandy open trail for some of the most fun downhills in the area. Lost Lake starts at its namesake trailhead. Several high speed, low risk sections take you down the sandy open trail", "Headset", "Shinoman Dura-Ace Headset", 67.50m, 20 },
                    { 25, 1, "Take you down the sandy open trail for some of the most fun downhills in the area. Ridgeline is a crown jewel of Dupont State Recreational Forest.", "Pants", "StaDry Cycling Pants", 69m, 22 },
                    { 26, 2, "You now have to ride down an asphalt trail and cut off onto a gravel trail before getting back to the old single track. Watch that you dont overshoot the switchback", "Bike Rack", "TransPort Bicycle Rack", 27m, 14 },
                    { 27, 3, "Stay the black diamond descent - the blue route was completely overgrown. This was a legitimate expert trail, but much difficulty can be mitigated slowing down, picking your line carefully.", "Mountain Bike", "Trek 9000 Mountain Bike", 1200m, 6 },
                    { 28, 4, "The start of the dirt road is marked on the Google Map directions on this page. Im slow and a little chicken top hit some of the gap jumps but this was super fun.", "Gloves", "True Grip Competition Gloves", 22m, 20 },
                    { 29, 5, "Logs embedded in the trail have been installed to signal technical terrain. Out of the parking lot, take your first left. Trail contains a rope-suspended ladder bridge.", "Tires", "Turbo Twin Tires", 29m, 18 },
                    { 30, 6, "Elevated bridges and a long-straight skinny. Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride.", "Car Rack", "Ultimate Export 2G Car Rack", 180m, 8 },
                    { 31, 1, "Road ride is absolutely beautiful and worth the ride. Watch that you dont overshoot the switchback to stay on the black diamond descent - the blue route is completely overgrown.", "Tires", "Ultra-2K Competition Tire", 34m, 22 },
                    { 32, 2, "Super loose after second intersection. The bottom portion of the trail is fast, loose and tight. Landings are getting a little rotted but the overall condition is good.", "Rain Jacket", "Ultra-Pro Rain Jacket", 85m, 30 },
                    { 33, 3, "The overall condition is good. The start of the dirt road is marked on the Google Map directions on this page. Pretty dry and fast.", "Tires", "Victoria Pro All Weather Tires", 54.95m, 20 },
                    { 34, 4, "At almost 20 miles with almost everything tahoe has to offer. I need to learn how to jump! By the end of the 45-50 miles youll be plenty tired from the constant up and down.", "Computer", "Viscount C-500 Wireless Bike Computer", 49m, 30 },
                    { 35, 5, "The constant up and down nature of Mana Road. There are actually three trails which make up the loop: Horse Creek-Cattle Creek-Lower Twin Lake. Logs are gone!", "Watch", "Viscount CardioSport Sport Watch", 179m, 12 },
                    { 36, 6, "Third Divide makes up part of the classic Downieville downhill route. There is no preferred direction and the trail is a great connector for several other fun loops.", "Helmet", "Viscount Microshell Helmet", 36m, 20 },
                    { 37, 1, "A trail & parking area reconstruction project completed in July 17. Long pedal up form town but best when shuttled to the top.", "Mountain Bike", "Viscount Mountain Bike", 635m, 5 },
                    { 38, 2, "One of the best downhills in the area. This ridge is more rugged than the other two ridges. The trail has good flow with some spicy sections.", "Transmitter", "Viscount Tru-Beat Heart Transmitter", 47m, 20 },
                    { 39, 3, "There are also several sections of slickrock that are fun to ride and allow you to pick your own line. The trails all run parallel to the Fountain Place paved road.", "Cycle Socks", "Wonder Wool Cycle Socks", 19m, 30 },
                    { 40, 4, "Built specifically for mountain bikes, a flow trail emphasizes speed and rhythm, featuring berms, rollers, jumps and other features.", "Tires", "X-Pro All Weather Tires", 24m, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
