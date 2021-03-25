using System;
using System.Collections.Generic;

using Xunit;

namespace SensorValidate.Tests
{
    public class SensorValidatorTest
    {
        [Fact]
        public void reportsErrorWhenSOCjumps() {
            Assert.True(SensorValidator.validateReadings(
                new List<double>{0.0, 0.01, 0.5, 0.51},0.05
            ));
        }
        [Fact]
        public void reportsErrorWhenCurrentjumps() {
            Assert.True(SensorValidator.validateReadings(
                new List<double>{0.03, 0.03, 0.03, 0.33},0.1
            ));
        }
        [Fact]
        public void reportsOkWhenValuesNotEmpty()
        {
            Assert.False(SensorValidator.validateReadings(
                new List<double> { 0.03, 0.03, 0.03, 0.33 }, 0.7
            ));
        }
        [Fact]
        public void reportsEmptyWhenValuesEmpty()
        {
            Assert.True(SensorValidator.validateReadings(
                new List<double> {}, 0.9
            ));
        }

    }
}
