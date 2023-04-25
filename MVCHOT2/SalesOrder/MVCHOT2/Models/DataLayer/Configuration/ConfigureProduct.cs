using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCHOT2.Models.DomainModels;

namespace MVCHOT2.Models.DataLayer.Configuration
{
    internal class ConfigureProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            //seed initial Data
            entity.HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "AeroFlo ATB Wheels",
                    ProductDescShort = "ATB Wheels",
                    ProductDescLong = "This is a fun flowy trail! The trail starts with a test- a skinny with a 2 ft. The area is mostly wooded but there are several places that offer spectacular views.",
                    ProductImage = "/01-AeroFlo-ATB-Wheels.jpg",
                    ProductPrice = 189M,
                    ProductQty = 40,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Clear Shade 85-T Glasses",
                    ProductDescShort = "85-T Glasses",
                    ProductDescLong = "There is no preferred direction and the trail is a great connector for several other fun loops. Two wheel drifting is likely if you have speed.",
                    ProductImage = "/02-Clear-Shade-85-T-Glasses.jpg",
                    ProductPrice = 45M,
                    ProductQty = 14,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Cosmic Elite Road Warrior Wheels",
                    ProductDescShort = "Road Warrior Wheels",
                    ProductDescLong = "Rowdy little downhill/freeride track. 16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008.",
                    ProductImage = "~/images/03-Cosmic-Elite-Road-Warrior-Wheels.jpg",
                    ProductPrice = 165M,
                    ProductQty = 22,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Cycle-Doc Pro Repair Stand",
                    ProductDescShort = "Repair Stand",
                    ProductDescLong = "The State of Alaska installed a more user friendly course in 2012. Mostly dry with some small mud puddles. The trails are well drained and suitable for riding when wet.",
                    ProductImage = "~/images/04-Cycle-Doc-Pro-Repair-Stand.jpg",
                    ProductPrice = 166M,
                    ProductQty = 12,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Dog Ear Aero-Flow Floor Pump",
                    ProductDescShort = "Floor Pump",
                    ProductDescLong = "It packs in a lot of excitement in a short amount of time. IMO it is a better ride to turn around and follow the same trail down. Removable by hand saw.",
                    ProductImage = "~/images/05-Dog-Ear-Aero-Flow-Floor-Pump.jpg",
                    ProductPrice = 5M,
                    ProductQty = 25,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Dog Ear Cycle Computer",
                    ProductDescShort = "Cycle Computer",
                    ProductDescLong = "This is just a brute of a climb. Short and fast, with a few small jumps and some loose rocks to keep you on your toes.",
                    ProductImage = "~/images/06-Dog-Ear-Cycle-Computer.jpg",
                    ProductPrice = 75M,
                    ProductQty = 20,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Dog Ear Helmet Mount Mirrors",
                    ProductDescShort = "Helmet Mirrors",
                    ProductDescLong = "There may be an optional dropspot 1/2 way down. The turns may be smooth berms that will be easy riding. It has few real technical features.",
                    ProductImage = "~/images/07-Dog-Ear-Helmet-Mount-Mirror.jpg",
                    ProductPrice = 7.45M,
                    ProductQty = 12,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Dog Ear Monster Grip Gloves",
                    ProductDescShort = "Grip Gloves",
                    ProductDescLong = "Since being redesigned, it is a lot of fun to ride this glassy smooth and generally well-bermed trail. Logs embedded in the trail have been installed.",
                    ProductImage = "~/images/08-Dog-Ear-Monster-Grip-Gloves.jpg",
                    ProductPrice = 15M,
                    ProductQty = 30,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Eagle FS-3 Mountain Bike",
                    ProductDescShort = "Mountain Bike",
                    ProductDescLong = "Installed to signal technical terrain. This trail begins with a small pump section with two smaller jumps and a third larger hip jump.",
                    ProductImage = "~/images/09-Eagle-FS-3-Mountain-Bike.jpg",
                    ProductPrice = 1800M,
                    ProductQty = 8,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Eagle SA-120 Clipless Pedals",
                    ProductDescShort = "Clipless Pedals",
                    ProductDescLong = "Fun! Chewed up, lots of braking bumps, but still fun. Winding trail with dips, climbs and descents. The turns are all smooth berms and easy to ride.",
                    ProductImage = "~/images/10-Eagle-SA-120-Clipless-Pedals.jpg",
                    ProductPrice = 139.95M,
                    ProductQty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Glide-O-Matic Cycling Helmet",
                    ProductDescShort = "Cycling Helmet",
                    ProductDescLong = "Easy to ride and not wash out. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.",
                    ProductImage = "~/images/11-Glide-O-Matic-Cycling-Helmet.jpg",
                    ProductPrice = 125M,
                    ProductQty = 24,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "GT RTS-2 Mountain Bike",
                    ProductDescShort = "Mountain Bike",
                    ProductDescLong = "MBoSC has partnered with land manager California Department of Forestry and Fire Protection (CAL FIRE) to build a four mile flow trail in Soquel Demonstration State Forest (SDSF).",
                    ProductImage = "~/images/12-GT-RTS-2-Mountain-Bike.jpg",
                    ProductPrice = 1650M,
                    ProductQty = 5,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "HP Deluxe Panniers",
                    ProductDescShort = "Panniers",
                    ProductDescLong = "Large group of trees down on northern section of trail, between buckhorn and club gap. There is no preferred direction and the trail is a great connector for several other fun loops.",
                    ProductImage = "~/images/13-HP-Deluxe-Panniers.jpg",
                    ProductPrice = 39M,
                    ProductQty = 10,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "King Cobra Helmet",
                    ProductDescShort = "Helmet",
                    ProductDescLong = "This area has a high density of trails for all ability levels and serves as the unofficial hub of mountain bike activity in the South Shore.",
                    ProductImage = "~/images/14-King-Cobra-Helmet.jpg",
                    ProductPrice = 139M,
                    ProductQty = 30,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Kool Breeze Rocket Top Jersey",
                    ProductDescShort = "Kool Breeze Rocket Top Jersey",
                    ProductDescLong = "Mountain bike activity in the South Shore. By the end of the 45-50 miles youll be plenty tired from the constant up and down nature of Mana Road.",
                    ProductImage = "~/images/15-Kool-Breeze-Rocket-Top-Jersey.jpg",
                    ProductPrice = 4.99M,
                    ProductQty = 40,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Kryptonite Advanced 2000 U-Lock",
                    ProductDescShort = "2000 U-Lock",
                    ProductDescLong = "16 Mile Summer Trail was initially a rugged singletrack DH trail maintained by local builders since 2008, the State of Alaska installed a more user friendly course in 2012.",
                    ProductImage = "~/images/16-Kryptonite-Advanced-2000-U-Lock.jpg",
                    ProductPrice = 50M,
                    ProductQty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Nikoma Lok-Tight U-Lock",
                    ProductDescShort = "U-Lock",
                    ProductDescLong = "Third Divide makes up part of the classic Downieville downhill route. A little overgrown on the seward side, but totlaly manageable.",
                    ProductImage = "~/images/17-Nikoma-Lok-Tight-U-Lock.jpg",
                    ProductPrice = 33M,
                    ProductQty = 12,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "ProFormance ATB All-Terrain Pedal",
                    ProductDescShort = "ATB Pedal",
                    ProductDescLong = "Overgrown on the seward side, but totlaly manageable. Trail full of berms and fun features! But this trail does not relent for one second.",
                    ProductImage = "~/images/18-Proformance-ATB-All-Terrain-Pedal.jpg",
                    ProductPrice = 28M,
                    ProductQty = 40,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "ProFormance Toe Klips 2G",
                    ProductDescShort = "Toe Klips",
                    ProductDescLong = "It doesnt get much use though so is sometimes a bit overgrown. Out here you will find the most legal features including log rides.",
                    ProductImage = "~/images/19-ProFormance-Toe-Klips-2G.jpg",
                    ProductPrice = 28M,
                    ProductQty = 40,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Pro-Sport Dillo Shades",
                    ProductDescShort = "Dillo Shades",
                    ProductDescLong = "Jumps and rock rolls in South Tahoe including the new jumps, berms, rollers and hips TAMBA and SBTS built in 2014. As the valley begins to close",
                    ProductImage = "~/images/20-Pro-Sport-Dillo-Shades.jpg",
                    ProductPrice = 82M,
                    ProductQty = 18,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Road Warrior Hitch Pack",
                    ProductDescShort = "Hitch Pack",
                    ProductDescLong = "The route transitions to a section of open forest. Trail contains a rope-suspended ladder bridge, elevated bridges and a long-straight skinny.",
                    ProductImage = "~/images/21-Road-Warrior-Hitch-Pack.jpg",
                    ProductPrice = 175M,
                    ProductQty = 6,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 22,
                    ProductName = "Shinoman 105 SC Brakes",
                    ProductDescShort = "SC Brakes",
                    ProductDescLong = "Elevated bridges and a long-straight skinny. This new trail flows well and has multiple banked berms and small jumps that wind down the mountainside.",
                    ProductImage = "~/images/22-Shinoman-105-SC-Brakes.jpg",
                    ProductPrice = 23.50M,
                    ProductQty = 16,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 23,
                    ProductName = "Shinoman Deluxe TX-30 Pedal",
                    ProductDescShort = "TX-30 Pedal",
                    ProductDescLong = "The trail is somewhat wide for singletrack and a bit technical with roots and rocks. Several high speed, low risk sections take you down the sandy open trail.",
                    ProductImage = "~/images/23-Shinoman-Deluxe-TX-30-Pedal.jpg",
                    ProductPrice = 45M,
                    ProductQty = 60,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 24,
                    ProductName = "Shinoman Dura-Ace Headset",
                    ProductDescShort = "Headset",
                    ProductDescLong = "The sandy open trail for some of the most fun downhills in the area. Lost Lake starts at its namesake trailhead. Several high speed, low risk sections take you down the sandy open trail",
                    ProductImage = "~/images/24-Shinoman-Dura-Ace-Headset.jpg",
                    ProductPrice = 67.50M,
                    ProductQty = 20,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 25,
                    ProductName = "StaDry Cycling Pants",
                    ProductDescShort = "Pants",
                    ProductDescLong = "Take you down the sandy open trail for some of the most fun downhills in the area. Ridgeline is a crown jewel of Dupont State Recreational Forest.",
                    ProductImage = "~/images/25-StaDry-Cycling-Pants.jpg",
                    ProductPrice = 69M,
                    ProductQty = 22,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 26,
                    ProductName = "TransPort Bicycle Rack",
                    ProductDescShort = "Bike Rack",
                    ProductDescLong = "You now have to ride down an asphalt trail and cut off onto a gravel trail before getting back to the old single track. Watch that you dont overshoot the switchback",
                    ProductImage = "~/images/26-TransPort-Bicycle-Rack.jpg",
                    ProductPrice = 27M,
                    ProductQty = 14,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 27,
                    ProductName = "Trek 9000 Mountain Bike",
                    ProductDescShort = "Mountain Bike",
                    ProductDescLong = "Stay the black diamond descent - the blue route was completely overgrown. This was a legitimate expert trail, but much difficulty can be mitigated slowing down, picking your line carefully.",
                    ProductImage = "~/images/27-Trek-9000-Mountain-Bike.jpg",
                    ProductPrice = 1200M,
                    ProductQty = 6,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 28,
                    ProductName = "True Grip Competition Gloves",
                    ProductDescShort = "Gloves",
                    ProductDescLong = "The start of the dirt road is marked on the Google Map directions on this page. Im slow and a little chicken top hit some of the gap jumps but this was super fun.",
                    ProductImage = "~/images/28-True-Grip-Competition-Gloves.jpg",
                    ProductPrice = 22M,
                    ProductQty = 20,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 29,
                    ProductName = "Turbo Twin Tires",
                    ProductDescShort = "Tires",
                    ProductDescLong = "Logs embedded in the trail have been installed to signal technical terrain. Out of the parking lot, take your first left. Trail contains a rope-suspended ladder bridge.",
                    ProductImage = "~/images/29-Turbo-Twin-Tires.jpg",
                    ProductPrice = 29M,
                    ProductQty = 18,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 30,
                    ProductName = "Ultimate Export 2G Car Rack",
                    ProductDescShort = "Car Rack",
                    ProductDescLong = "Elevated bridges and a long-straight skinny. Having gotten that out of the way, the Mana Road ride is absolutely beautiful and worth the ride.",
                    ProductImage = "~/images/30-Ultimate-Export-2G-Car-Rack.jpg",
                    ProductPrice = 180M,
                    ProductQty = 8,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 31,
                    ProductName = "Ultra-2K Competition Tire",
                    ProductDescShort = "Tires",
                    ProductDescLong = "Road ride is absolutely beautiful and worth the ride. Watch that you dont overshoot the switchback to stay on the black diamond descent - the blue route is completely overgrown.",
                    ProductImage = "~/images/31-Ultra-2K-Competition-Tire.jpg",
                    ProductPrice = 34M,
                    ProductQty = 22,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 32,
                    ProductName = "Ultra-Pro Rain Jacket",
                    ProductDescShort = "Rain Jacket",
                    ProductDescLong = "Super loose after second intersection. The bottom portion of the trail is fast, loose and tight. Landings are getting a little rotted but the overall condition is good.",
                    ProductImage = "~/images/32-Ultra-Pro-Rain-Jacket.jpg",
                    ProductPrice = 85M,
                    ProductQty = 30,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 33,
                    ProductName = "Victoria Pro All Weather Tires",
                    ProductDescShort = "Tires",
                    ProductDescLong = "The overall condition is good. The start of the dirt road is marked on the Google Map directions on this page. Pretty dry and fast.",
                    ProductImage = "~/images/33-Victoria-Pro-All-Weather-Tires.jpg",
                    ProductPrice = 54.95M,
                    ProductQty = 20,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 34,
                    ProductName = "Viscount C-500 Wireless Bike Computer",
                    ProductDescShort = "Computer",
                    ProductDescLong = "At almost 20 miles with almost everything tahoe has to offer. I need to learn how to jump! By the end of the 45-50 miles youll be plenty tired from the constant up and down.",
                    ProductImage = "~/images/34-Viscount-C-500-Wireless-Bike-Computer.jpg",
                    ProductPrice = 49M,
                    ProductQty = 30,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 35,
                    ProductName = "Viscount CardioSport Sport Watch",
                    ProductDescShort = "Watch",
                    ProductDescLong = "The constant up and down nature of Mana Road. There are actually three trails which make up the loop: Horse Creek-Cattle Creek-Lower Twin Lake. Logs are gone!",
                    ProductImage = "~/images/35-Viscount-CardioSport-Sport-Watch.jpg",
                    ProductPrice = 179M,
                    ProductQty = 12,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 36,
                    ProductName = "Viscount Microshell Helmet",
                    ProductDescShort = "Helmet",
                    ProductDescLong = "Third Divide makes up part of the classic Downieville downhill route. There is no preferred direction and the trail is a great connector for several other fun loops.",
                    ProductImage = "~/images/36-Viscount-Microshell-Helmet.jpg",
                    ProductPrice = 36M,
                    ProductQty = 20,
                    CategoryID = 6
                },
                new Product
                {
                    ProductID = 37,
                    ProductName = "Viscount Mountain Bike",
                    ProductDescShort = "Mountain Bike",
                    ProductDescLong = "A trail & parking area reconstruction project completed in July 17. Long pedal up form town but best when shuttled to the top.",
                    ProductImage = "~/images/37-Viscount-Mountain-Bikes.jpg",
                    ProductPrice = 635M,
                    ProductQty = 5,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 38,
                    ProductName = "Viscount Tru-Beat Heart Transmitter",
                    ProductDescShort = "Transmitter",
                    ProductDescLong = "One of the best downhills in the area. This ridge is more rugged than the other two ridges. The trail has good flow with some spicy sections.",
                    ProductImage = "~/images/38-Viscount-Tru-Beat-Heart-Transmitter.jpg",
                    ProductPrice = 47M,
                    ProductQty = 20,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 39,
                    ProductName = "Wonder Wool Cycle Socks",
                    ProductDescShort = "Cycle Socks",
                    ProductDescLong = "There are also several sections of slickrock that are fun to ride and allow you to pick your own line. The trails all run parallel to the Fountain Place paved road.",
                    ProductImage = "~/images/39-Wonder-Wood-Cycle-Socks.jpg",
                    ProductPrice = 19M,
                    ProductQty = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 40,
                    ProductName = "X-Pro All Weather Tires",
                    ProductDescShort = "Tires",
                    ProductDescLong = "Built specifically for mountain bikes, a flow trail emphasizes speed and rhythm, featuring berms, rollers, jumps and other features.",
                    ProductImage = "~/images/40-X-Pro-All-Weather-Tires.jpg",
                    ProductPrice = 24M,
                    ProductQty = 20,
                    CategoryID = 4
                });
        }
    }
}
