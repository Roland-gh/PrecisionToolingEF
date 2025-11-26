using Microsoft.EntityFrameworkCore;

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using PrecisionToolingEF.Models;

namespace PrecisionToolingEF.Data
{
    public class PrecisionToolingInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider, bool DeleteDatabase = false, bool UseMigrations = true, bool SeedSampleData = true) 
        {
            
            using (var context = new PrecisionToolingContext(serviceProvider.GetRequiredService<DbContextOptions<PrecisionToolingContext>>()))
            {

                // refresh the database as per the parameter options
                try
                {
                    if(DeleteDatabase || !context.Database.CanConnect())
                    {
                        if (UseMigrations)
                        {
                            context.Database.Migrate(); //Create the database and apply all migration s
                        }
                        else
                        {
                            context.Database.EnsureCreated(); // create and update the database per the Model
                        }
                    }
                    else
                    {
                        if (UseMigrations)
                        {
                            context.Database.Migrate();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.GetBaseException().Message);
                }



                if (SeedSampleData)
                {
                    // Seed data REQUIRED for production and during development
                    #region Seed  Required Data
                    try
                    {
                        // add some customers
                        if (!context.Customers.Any())
                        {
                            context.Customers.AddRange(
                                new Customer
                                {
                                    Name = "Medical Devices R Us",
                                    Address1 = "123 Somestreet Ave",
                                    Address2 = "",
                                    City = "Memphis",
                                    State = "TN",
                                    ZipCode = "38117",
                                    Contact = "Steve Hern",
                                    Email = "shern@gmail.com",
                                    Phone = "9018449384",
                                    FaxNumber = "9013459878",
                                    Notes = "Company making medical parts"
                                },
                                new Customer
                                {
                                    Name = "Medtech Manufacturing Solution",
                                    Address1 = "543 Prescott Street",
                                    Address2 = "",
                                    City = "Memphis",
                                    State = "TN",
                                    ZipCode = "38117",
                                    Contact = "Joe Boneafide",
                                    Email = "jboneafide@gmail.com",
                                    Phone = "9017884431",
                                    FaxNumber = "9017789878",
                                    Notes = "Manufacturer for medical devices"
                                },
                                new Customer
                                {
                                    Name = "Epson Automation Solutions",
                                    Address1 = "53 Summer Ave.",
                                    Address2 = "",
                                    City = "Memphis",
                                    State = "TN",
                                    ZipCode = "38117",
                                    Contact = "John Hunt",
                                    Email = "jhunt@hwainternational.com",
                                    Phone = "9012324431",
                                    FaxNumber = "9012329878",
                                    Notes = "Manufacturer for medical devices"
                                },
                                new Customer
                                {
                                    Name = "Medtronic",
                                    Address1 = "123 Airline Rd.",
                                    Address2 = "",
                                    City = "Arlington",
                                    State = "TN",
                                    ZipCode = "38117",
                                    Contact = "Bubba J",
                                    Email = "bubbaj@gmail.com",
                                    Phone = "9012224631",
                                    FaxNumber = "9012229879",
                                    Notes = "Manufacturer for medical devices"
                                },
                                new Customer
                                {
                                    Name = "Johnson & Johnson",
                                    Address1 = "13 Bayline Rd.",
                                    Address2 = "",
                                    City = "Southaven",
                                    State = "MS",
                                    ZipCode = "38117",
                                    Contact = "Julius Macab",
                                    Email = "jmacab@gmail.com",
                                    Phone = "6623214631",
                                    FaxNumber = "6623219879",
                                    Notes = "Manufacturer of medical devices and consumer goods"
                                });
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                }

                

                #endregion
            }


        }

    }
}
