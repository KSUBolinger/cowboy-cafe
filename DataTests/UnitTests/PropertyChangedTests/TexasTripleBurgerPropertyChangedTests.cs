using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Implementation Test
        /// </summary>
        [Fact]
        public void TexasTripleBurgerShouldImplementNotifyPropertyChanged()
        {
            var burger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Bun Tests
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }

        [Fact]
        public void ChaningBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }

        [Fact]
        public void ChaningKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }

        [Fact]
        public void ChanignMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }

        /// <summary>
        /// Tomato tests
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Tomato = false;
            });
        }

        /// <summary>
        /// lettuce tests
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Lettuce = false;
            });
        }

        /// <summary>
        /// Mayo tests
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedFormayo()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = false;
            });
        }

        [Fact]
        public void ChaningMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mayo = false;
            });
        }

        /// <summary>
        /// Bacon Tests
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Bacon", () =>
            {
                burger.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bacon = false;
            });
        }

        /// <summary>
        /// egg Tests
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Egg", () =>
            {
                burger.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Egg = false;
            });
        }
    }
}
