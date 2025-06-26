using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DrinkStock.Models
{
    public partial class Drink : ObservableObject
    {
        [ObservableProperty]
        public partial string? Name { get; set; }
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DownstockQuantity))]
        public partial int CurrentStock { get; set; }
        [ObservableProperty]
        public partial int MaxStock { get; set; }
        public int DownstockQuantity => MaxStock - CurrentStock;

        [RelayCommand]
        public void AddOne()
        {
            CurrentStock++;
        }

        [RelayCommand]
        public void SubtractOne()
        {
            CurrentStock--;
        }
    }
}
