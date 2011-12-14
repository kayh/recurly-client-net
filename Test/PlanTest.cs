using System;
using System.Collections.Generic;
using System.Text;
using Recurly;
using NUnit.Framework;

namespace Recurly.Test
{
    [TestFixture]
    public class PlanTest
    {
        [Test]
        public void GetAll()
        {
            IEnumerable<RecurlyPlan> plans = RecurlyPlan.GetAll();

            Assert.NotNull(plans);
        }
    }
}