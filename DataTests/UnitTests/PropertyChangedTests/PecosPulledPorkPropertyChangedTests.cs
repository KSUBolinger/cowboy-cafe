using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        /// <summary>
        /// Implementation test 
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplementNotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }


        /// <summary>
        /// bread tests
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });
        }

        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }

        /// <summary>
        /// Pickle Tests
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickles()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }
    }
}
