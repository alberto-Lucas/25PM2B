﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RevisaoMVVM.ViewModels
{
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
