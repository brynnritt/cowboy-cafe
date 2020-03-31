using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Equal(5.88, pulledPork.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Equal<uint>(528, pulledPork.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Empty(pulledPork.SpecialInstructions);
        }

        [Fact]
        public void HoldingBreadShouldAddSpecialInstruction()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Bread = false;
            Assert.Collection(pulledPork.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bread", instruction);
            });
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () => {
                pork.Bread = false;
            });
        }

        [Fact]
        public void HoldingPickleShouldAddSpecialInstruction()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Pickle = false;
            Assert.Collection(pulledPork.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () => {
                pork.Pickle = false;
            });
        }

        [Fact]
        public void HoldingBothBreadAndPickleShouldAddTwoSpecialInstructions()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Bread = false;
            pulledPork.Pickle = false;
            Assert.Contains("hold pickle", pulledPork.SpecialInstructions);
            Assert.Contains("hold bread", pulledPork.SpecialInstructions);
        }

        [Fact]
        public void PecosPulldPorkImplementsINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }
    }
}
