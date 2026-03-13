using System;
using System.Collections.Generic;
using System.Text;

namespace NETMaui5Glava.Controls
{
    class PageSearchHandler : SearchHandler
    {
        public List<string> Pages {  get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue)) 
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Pages.Where(page => page.ToLower().Contains(newValue.ToLower()))
                    .ToList<string>();
            }
        }
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            await Shell.Current.GoToAsync($"///{item}");
        }
        
    }
}
