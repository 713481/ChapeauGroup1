using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public enum ItemStatus { Open = 1, Preparing, Ready, Served }
    public enum ItemCategory { Starters = 1, Entrements, Mains, Deserts, SoftDrinks, Beers, Wines, SpiritDrinks, CoffeeTea }
    public enum MenuType { Lunch = 1, Dinner, Drinks }
    public enum StaffRole { Waiter = 1, Chef, Manger, Bartender }
    public enum OrderStatus { Open = 1, Preparing, Ready, Served }
    public enum TableStatus { free = 1, occupied = 2 }
    
}
