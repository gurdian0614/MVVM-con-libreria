using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_con_libreria.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private int count;

        //La anotacion agrega internamente IncrementarCommand
        [RelayCommand]
        public void Incrementar()
        {
            Count++;
        }
    }
}
