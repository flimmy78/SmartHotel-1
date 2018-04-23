using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using SmartHotel.Mvvm.Commands;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public class MenuItem
        {
            public string Icon { get; set; }
            public string Title { get; set; }

            public Type ViewModelType { get; set; }
        }
        public List<MenuItem> Menu { get; set; }

        public MenuViewModel()
        {
            Menu = new List<MenuItem>()
            {
                new MenuItem(){ Icon = "ic_bed", Title ="Book a room", ViewModelType = typeof(BookingViewModel) },
                new MenuItem(){ Icon = "ic_key", Title ="My room", ViewModelType = typeof(MyRoomViewModel) },
                new MenuItem(){ Icon = "ic_beach", Title ="Suggestions", ViewModelType = typeof(SuggesstionsViewModel) },
                new MenuItem(){ Icon = "ic_bot", Title ="Concierge" },
                new MenuItem(){ Icon = "ic_logout", Title ="Logout" },
            };

            //UserDialogs.Instance.
            MenuCommand = new DelegateCommand<object>(Selected);
        }

        private void Selected(object page)
        {
            if (page is MenuItem menuItem && menuItem.ViewModelType != null)
            {
                NavigationService.NavigateToAsync(menuItem.ViewModelType);
            }
        }

        public DelegateCommand<object> MenuCommand { get; }

    }
}
