using Logbook3MVC.Models;

namespace Logbook3MVC.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            addAddresses(context);

            //addCustomers(context);
        }

        private static void addAddresses(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Addresses.Any())
            {
                return;   // DB has been seeded
            }

            var addresses = new Address[]
            {
                new Address
                {
                    HouseNumber = "33",
                    PostCode = "WD5 999"
                },

            };
        }

        private static void addCustomers(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer
                {
                    Name = "Derek Peacock",
                    AddressId = 1,
                }          
            };
        }

    }
}
