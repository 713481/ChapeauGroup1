﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public enum ItemStatus { Open = 1, Preparing, Ready, Served }
    public enum ItemCategory { Starters = 1, Entrements, Mains, Deserts, SoftDrinks, Beers, Wines, SpiritDrinks, CoffeeTea }
    public enum MenuType { Lunch = 1, Dinner, Drinks }
}
