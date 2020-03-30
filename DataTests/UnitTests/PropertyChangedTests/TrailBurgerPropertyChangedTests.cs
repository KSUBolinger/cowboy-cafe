using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// Implementation Test
        /// </summary>
        [Fact]
        public void TrailBurgerShouldImplementNotifyPropertyChanged()
        {
            var burger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Bun Tests
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }

        [Fact]
        public void ChaningBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });
        }

        /// <summary>
        /// Ketchup tests
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }

        [Fact]
        public void ChaningKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });
        }

        /// <summary>
        /// Mustard tests
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }

        [Fact]
        public void ChanignMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });
        }

        /// <summary>
        /// pickle tests
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Pickle = false;
            });
        }

        /// <summary>
        /// Cheese tests
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }
    }
}
