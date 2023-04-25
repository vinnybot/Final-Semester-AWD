using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCHOT2.Models.DomainModels;

namespace MVCHOT2.Models.DataLayer.Configuration
{
    public class ConfigureCustomer : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            // seed initial data
            entity.HasData(
                new Customer
                {
                    CustomerID = 1,
                    CustomerFirstName = "Suzanne",
                    CustomerLastName = "Viescas",
                    CustomerStreetAddress = "15127 NE 24th, #383",
                    CustomerCity = "Redmond",
                    CustomerState = "WA",
                    CustomerZipCode = "98052",
                    CustomerPhoneNumber = "425-555-2686"
                },
    new Customer
    {
        CustomerID = 2,
        CustomerFirstName = "William",
        CustomerLastName = "Thompson",
        CustomerStreetAddress = "122 Spring River Drive",
        CustomerCity = "Duvall",
        CustomerState = "WA",
        CustomerZipCode = "98019",
        CustomerPhoneNumber = "425-555-2681"
    },
    new Customer
    {
        CustomerID = 3,
        CustomerFirstName = "Gary",
        CustomerLastName = "Hallmark",
        CustomerStreetAddress = "Route 2 Road",
        CustomerCity = "Auburn",
        CustomerState = "WA",
        CustomerZipCode = "98002",
        CustomerPhoneNumber = "253-555-2676"
    },
    new Customer
    {
        CustomerID = 4,
        CustomerFirstName = "Robert",
        CustomerLastName = "Brown",
        CustomerStreetAddress = "672 Lamont Ave",
        CustomerCity = "Houston",
        CustomerState = "TX",
        CustomerZipCode = "77201",
        CustomerPhoneNumber = "713-555-2491"
    },
    new Customer
    {
        CustomerID = 5,
        CustomerFirstName = "Dean",
        CustomerLastName = "McCrae",
        CustomerStreetAddress = "4110 Redmond Rd.",
        CustomerCity = "Redmond",
        CustomerState = "WA",
        CustomerZipCode = "98052",
        CustomerPhoneNumber = "425-555-2506"
    },
    new Customer
    {
        CustomerID = 6,
        CustomerFirstName = "John",
        CustomerLastName = "Viescas",
        CustomerStreetAddress = "15127 NE 24th, #383",
        CustomerCity = "Redmond",
        CustomerState = "WA",
        CustomerZipCode = "98052",
        CustomerPhoneNumber = "425-555-2511"
    },
    new Customer
    {
        CustomerID = 7,
        CustomerFirstName = "Mariya",
        CustomerLastName = "Sergienko",
        CustomerStreetAddress = "901 Pine Avenue",
        CustomerCity = "Portland",
        CustomerState = "OR",
        CustomerZipCode = "97208",
        CustomerPhoneNumber = "503-555-2526"
    },
    new Customer
    {
        CustomerID = 8,
        CustomerFirstName = "Neil",
        CustomerLastName = "Patterson",
        CustomerStreetAddress = "233 West Valley Hwy",
        CustomerCity = "San Diego",
        CustomerState = "CA",
        CustomerZipCode = "92199",
        CustomerPhoneNumber = "619-555-2541"
    },
    new Customer
    {
        CustomerID = 9,
        CustomerFirstName = "Andrew",
        CustomerLastName = "Cencini",
        CustomerStreetAddress = "507 - 20th Ave. E. Apt. 2A",
        CustomerCity = "Seattle",
        CustomerState = "WA",
        CustomerZipCode = "98105",
        CustomerPhoneNumber = "206-555-2601"
    },
    new Customer
    {
        CustomerID = 10,
        CustomerFirstName = "Angel",
        CustomerLastName = "Kennedy",
        CustomerStreetAddress = "667 Red River Road",
        CustomerCity = "Austin",
        CustomerState = "TX",
        CustomerZipCode = "78710",
        CustomerPhoneNumber = "512-555-2571"
    },
    new Customer
    {
        CustomerID = 11,
        CustomerFirstName = "Alaina",
        CustomerLastName = "Hallmark",
        CustomerStreetAddress = "Route 2, Box 203B",
        CustomerCity = "Woodinville",
        CustomerState = "WA",
        CustomerZipCode = "98072",
        CustomerPhoneNumber = "425-555-2631"
    },
    new Customer
    {
        CustomerID = 12,
        CustomerFirstName = "Liz",
        CustomerLastName = "Keyser",
        CustomerStreetAddress = "13920 S.E. 40th Street",
        CustomerCity = "Bellevue",
        CustomerState = "WA",
        CustomerZipCode = "98006",
        CustomerPhoneNumber = "425-555-2556"
    },
    new Customer
    {
        CustomerID = 13,
        CustomerFirstName = "Rachel",
        CustomerLastName = "Patterson",
        CustomerStreetAddress = "2114 Longview Lane",
        CustomerCity = "San Diego",
        CustomerState = "CA",
        CustomerZipCode = "92199",
        CustomerPhoneNumber = "619-555-2546"
    },
    new Customer
    {
        CustomerID = 14,
        CustomerFirstName = "Sam",
        CustomerLastName = "Abolrous",
        CustomerStreetAddress = "611 Alpine Drive",
        CustomerCity = "Palm Springs",
        CustomerState = "CA",
        CustomerZipCode = "92263",
        CustomerPhoneNumber = "760-555-2611"
    },
    new Customer
    {
        CustomerID = 15,
        CustomerFirstName = "Darren",
        CustomerLastName = "Gehring",
        CustomerStreetAddress = "2601 Seaview Lane",
        CustomerCity = "Chico",
        CustomerState = "CA",
        CustomerZipCode = "95926",
        CustomerPhoneNumber = "530-555-2616"
    },
    new Customer
    {
        CustomerID = 16,
        CustomerFirstName = "Jim",
        CustomerLastName = "Wilson",
        CustomerStreetAddress = "101 NE 88th",
        CustomerCity = "Salem",
        CustomerState = "OR",
        CustomerZipCode = "97301",
        CustomerPhoneNumber = "503-555-2636"
    },
    new Customer
    {
        CustomerID = 17,
        CustomerFirstName = "Manuela",
        CustomerLastName = "Seidel",
        CustomerStreetAddress = "66 Spring Valley Drive",
        CustomerCity = "Medford",
        CustomerState = "OR",
        CustomerZipCode = "97501",
        CustomerPhoneNumber = "541-555-2641"

    },
    new Customer
    {
        CustomerID = 18,
        CustomerFirstName = "David",
        CustomerLastName = "Smith",
        CustomerStreetAddress = "311 20th Ave. N.E.",
        CustomerCity = "Fremont",
        CustomerState = "CA",
        CustomerZipCode = "94538",
        CustomerPhoneNumber = "510-555-2646"
    },
    new Customer
    {
        CustomerID = 19,
        CustomerFirstName = "Zachary",
        CustomerLastName = "Ehrlich",
        CustomerStreetAddress = "12330 Kingman Drive",
        CustomerCity = "Glendale",
        CustomerState = "CA",
        CustomerZipCode = "91209",
        CustomerPhoneNumber = "818-555-2721"
    },
    new Customer
    {
        CustomerID = 20,
        CustomerFirstName = "Joyce",
        CustomerLastName = "Bonnicksen",
        CustomerStreetAddress = "2424 Thames Drive",
        CustomerCity = "Bellevue",
        CustomerState = "WA",
        CustomerZipCode = "98006",
        CustomerPhoneNumber = "425-555-2726"
    },
    new Customer
    {
        CustomerID = 21,
        CustomerFirstName = "Estella",
        CustomerLastName = "Pundt",
        CustomerStreetAddress = "2500 Rosales Lane",
        CustomerCity = "Dallas",
        CustomerState = "TX",
        CustomerZipCode = "75260",
        CustomerPhoneNumber = "972-555-9938"
    },
    new Customer
    {
        CustomerID = 22,
        CustomerFirstName = "Caleb",
        CustomerLastName = "Viescas",
        CustomerStreetAddress = "4501 Wetland Road",
        CustomerCity = "Long Beach",
        CustomerState = "CA",
        CustomerZipCode = "90809",
        CustomerPhoneNumber = "562-555-0037"
    },
    new Customer
    {
        CustomerID = 23,
        CustomerFirstName = "Julia",
        CustomerLastName = "Schnebly",
        CustomerStreetAddress = "2343 Harmony Lane",
        CustomerCity = "Seattle",
        CustomerState = "WA",
        CustomerZipCode = "99837",
        CustomerPhoneNumber = "206-555-9936"
    },
    new Customer
    {
        CustomerID = 24,
        CustomerFirstName = "Mark",
        CustomerLastName = "Rosales",
        CustomerStreetAddress = "323 Advocate Lane",
        CustomerCity = "El Paso",
        CustomerState = "TX",
        CustomerZipCode = "79915",
        CustomerPhoneNumber = "915-555-2286"
    },
    new Customer
    {
        CustomerID = 25,
        CustomerFirstName = "Maria",
        CustomerLastName = "Patterson",
        CustomerStreetAddress = "3445 Cheyenne Road",
        CustomerCity = "El Paso",
        CustomerState = "TX",
        CustomerZipCode = "79915",
        CustomerPhoneNumber = "915-555-2291"
    },
    new Customer
    {
        CustomerID = 26,
        CustomerFirstName = "Kirk",
        CustomerLastName = "DeGrasse",
        CustomerStreetAddress = "455 West Palm Ave",
        CustomerCity = "San Antonio",
        CustomerState = "TX",
        CustomerZipCode = "78284",
        CustomerPhoneNumber = "210-555-2311"
    },
    new Customer
    {
        CustomerID = 27,
        CustomerFirstName = "Luke",
        CustomerLastName = "Patterson",
        CustomerStreetAddress = "877 145th Ave SE",
        CustomerCity = "Portland",
        CustomerState = "OR",
        CustomerZipCode = "97208",
        CustomerPhoneNumber = "503-555-2316"
    });
        }
    }
}
