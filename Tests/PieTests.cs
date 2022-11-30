using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Xunit;

namespace BethanysPieShop.Tests
{
    public class PieTests
    {
        [Fact]
        public void CanChangePieName()
        {
            // Arrange
            var p = new Pie { Name = "Orange Pie", Price = 5.99M };

            // Act
            p.Name = "Orange Pie";

            //Assert
            Assert.Equal("Orange Pie", p.Name);

        }

        
        [Fact]
        public void CanChangePiePrice()
        {
            var p = new Pie { Name = "Orange Pie", Price = 100M };

            p.Price = 200M;

            Assert.Equal(100M, p.Price);
        }

    }
}
