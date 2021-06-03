using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertWeb2.Controllers;
using ConcertWeb2.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;
namespace ConcertWeb2.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ConcertContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-FPLM1TC; Database=Concert; Trusted_Connection=True; MultipleActiveResultSets=true");

            var controller = new ArtistsController(new ConcertContext(optionsBuilder.Options));

            // Act
            var result = await controller.GetArtists();

            // Assert
            Assert.Contains(result.Value, g => g.Name.Equals("Go_A"));
        }
    }
}
