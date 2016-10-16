using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegister.Model;
using Xunit;

namespace CashRegisterTest
{
    public class Test
    {
        [Fact]
        public void TruthTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void ItemTest()
        {
            Assert.True(Item.Truth());
        }
    }
}
