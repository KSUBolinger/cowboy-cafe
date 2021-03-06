﻿/*
 * Author: Easton Bolinger
 * Class: TexasTea.cs
 * Purpose: Handles the attributes of the Texas Tea Drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class represetnign the Texas Tea drink 
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    return 1.00;
                }
                else if(this.Size == Size.Medium)
                {
                    return 1.50;
                }
                else
                {
                    return 2.00;
                }
            }
        }

        /// <summary>
        /// Calories of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(this.Size == Size.Small)
                {
                    if(Sweet == false)
                    {
                        return 5;
                    }
                    return 10; 
                }
                else if(this.Size == Size.Medium)
                {
                    if(Sweet == false)
                    {
                        return 11;
                    }
                    return 22;
                }
                else
                {
                    if(Sweet == false)
                    {
                        return 18;
                    }
                    return 36;
                }
            }
        }
        private bool sweet = true;
        /// <summary>
        /// IF the tea should be sweet
        /// </summary>
        public bool Sweet 
        {
            get { return sweet; }
            set
            {
                sweet = value;
                NotifyPropertyChanged("Sweet");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the tea should include a lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyPropertyChanged("Lemon");
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the tea should include ice
        /// </summary>
        public new bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
            }
        }
        /// <summary>
        /// Special Instructions for the preparation of the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Lemon != false) instructions.Add("Add Lemon");
                if (Ice != true) instructions.Add("Hold Ice");
                if (Sweet != true) instructions.Add("Plain");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representing the tea
        /// </summary>
        /// <returns>string decribing the tea</returns>
        public override string ToString()
        {
            string sweet;
            if(Sweet == true)
            {
                 sweet = "Sweet";
            }
            else
            {
                 sweet = "Plain";
            }
            return Size.ToString()  + " Texas " + sweet + " Tea" ;
        }
    }
}
