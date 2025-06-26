using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DrinkStock.Models;
using System.Collections.ObjectModel;

namespace DrinkStock.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Drink> Drinks { get; } =
        [
            new Drink { Name = "Coke", MaxStock = 20 },
            new Drink { Name = "Diet Coke", MaxStock = 10 },
            new Drink { Name = "Coke Zero", MaxStock = 10 },
            new Drink { Name = "Sprite", MaxStock = 10 },
            new Drink { Name = "Sprite Zero", MaxStock = 10 },
            new Drink { Name = "Sprite + Tea", MaxStock = 10 },
            new Drink { Name = "Root Beer", MaxStock = 10 },
            new Drink { Name = "Mexican Coke", MaxStock = 10 },
            new Drink { Name = "Mexican Sprite", MaxStock = 10 },
            new Drink { Name = "Topo Chico Mineral Water", MaxStock = 10 },
            new Drink { Name = "Dr. Pepper", MaxStock = 10 },
            new Drink { Name = "Diet Dr. Pepper", MaxStock = 10 },
            new Drink { Name = "Fanta Orange", MaxStock = 10 },
            new Drink { Name = "Gold Peak Sweet Tea", MaxStock = 10 },
            new Drink { Name = "Smart Water", MaxStock = 10 },
            new Drink { Name = "Powerade Blue", MaxStock = 10 },
            new Drink { Name = "Powerade Red", MaxStock = 10 },
            new Drink { Name = "Powerade Zero Blue", MaxStock = 10 },
            new Drink { Name = "Vitamin Water Lemonade", MaxStock = 10 },
            new Drink { Name = "Vitamin Water Acai Blueberry Pomegranate", MaxStock = 10 },
            new Drink { Name = "Vitamin Water Dragonfruit", MaxStock = 10 },
            new Drink { Name = "Body Armor Strawberry Banana", MaxStock = 10 },
            new Drink { Name = "Body Armor Orange Mango", MaxStock = 10 },
            new Drink { Name = "Body Armor Lyte Peach Mango", MaxStock = 10 },
            new Drink { Name = "Core Power Chocolate", MaxStock = 10 },
            new Drink { Name = "Monster Energy", MaxStock = 12 },
            new Drink { Name = "Monster Blue Hawaiian", MaxStock = 12 },
            new Drink { Name = "Monster Strawberry Dreams", MaxStock = 12 },
            new Drink { Name = "Monster Peachy Keen", MaxStock = 12 },
            new Drink { Name = "Monster Zero Ultra", MaxStock = 12 },
            new Drink { Name = "Monster Ultra Violet", MaxStock = 12 },
            new Drink { Name = "Monster Ultra Vice Guava", MaxStock = 12 },
            new Drink { Name = "Monster Juice", MaxStock = 12 },
            new Drink { Name = "Monster Java Mean Bean", MaxStock = 12 },
            new Drink { Name = "NOS Blue", MaxStock = 12 },
            new Drink { Name = "NOS Purple", MaxStock = 12 },
            new Drink { Name = "Reign Orange", MaxStock = 12 },
            new Drink { Name = "Reign Tiny Purple Can?", MaxStock = 12 },
            new Drink { Name = "Bang Orange", MaxStock = 12 }
        ];
    }

    
}
