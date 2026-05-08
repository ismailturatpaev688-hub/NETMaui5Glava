using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NETMaui5Glava.Controls
{
    public class Project : INotifyPropertyChanged
    {
        string name = "";
        bool isActive = false;
        double cost = 0;

        public string Name
        {
            get => name;
            set
            { 
                if(name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool IsActive
        {
            get => isActive;
            set
            {
                if(isActive != value)
                {
                    isActive = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Cost
        {
            get => cost;
            set
            {
                if(cost != value)
                {
                    cost = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
