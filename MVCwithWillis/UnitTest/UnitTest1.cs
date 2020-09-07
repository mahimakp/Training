using HospitalRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVCwithWillis.Controllers;
using PatientLibrary;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            return config;
        }

        public static HospitalDbContext CreateDbContext()
        {
            var config = InitConfiguration();
            var connectionString = config["ConnectionStrings"];

            var optionsBuilder = new DbContextOptionsBuilder<HospitalDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var patientdbcontext = new HospitalDbContext(optionsBuilder.Options);
            return patientdbcontext;
        }


        [TestMethod]
        public void TestCustomerAdd()
        {
            Customer x = new Customer();
            //  A A A          

            Mock<IDataLayer> mockdatalayer = new Mock<IDataLayer>(); // Arrange
            // Arrange
            //mockdatalayer.Setup(x => x.Add()).Callback(() =>
            //{            //    // Do not do anything
            //    var x = 100;
            //});

            mockdatalayer.Setup(x => x.Add(It.IsAny<string>()))
                .Returns(true);

            x.db = mockdatalayer.Object;
            x.name = "Mahima";

            // Act
            var isadded = x.Add();

            // Assert
            Assert.AreEqual(true, isadded); // assert / check
        }

        [TestMethod]
        public void TestCustomerDal()
        {
        }

        [TestMethod]
        public void TestApiPost()
        {
            Mock<HttpContext> httpmock = new Mock<HttpContext>();
            Mock<ISession> sessionmock = new Mock<ISession>();                
            sessionmock.Setup(x => x.Set(It.IsAny<string>(), It.IsAny<byte[]>()))
                            .Callback<string, byte[]>((s, b) =>                            {
                                // do nothing
                                var x = 0;
                            }
                            );
            httpmock.Setup(s => s.Session).
                Returns(sessionmock.Object);

            List<PatientDTO> pdtos = new List<PatientDTO>();
            pdtos.Add(new PatientDTO() { name = "Mahima", address = "Mumbai", email = "mahima@gmail.com" });
            pdtos.Add(new PatientDTO() { name = "Abc", address = "Mumbai", email = "abc@gmail.com" });

            PatientApiController pobjApi = new PatientApiController(

                CreateDbContext()
                );

            pobjApi.ControllerContext.HttpContext = httpmock.Object;
            var actionResult = pobjApi.Post(pdtos);
            var objectResult = actionResult as OkObjectResult;

            Assert.AreEqual(200, objectResult.StatusCode);
            Assert.AreNotEqual(0, ((List<Patient>)objectResult.Value).Count);
        }
    }
    public class Customer
    {
        public string name { get; set; }
        public IDataLayer db = new DataLayer();

        public bool Add()
        {

            if (name.Length == 0)
            {
                return false;
            }
            if (db.Add(""))
            {
                name = "Welcome " + name; // code will never
            }
            return true;
        }

    }
    public interface IDataLayer
    {
        bool Add(string connection);
    }
    public class DataLayer : IDataLayer
    {
        public bool Add(string connection)
        {
            throw new Exception("Sql Server is not running");

            // Data acces
        }

    }
}