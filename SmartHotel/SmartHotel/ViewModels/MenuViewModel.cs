using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;

namespace SmartHotel.ViewModels
{
    public class MenuViewModel
    {
        public class MenuItem
        {
            public string Icon { get; set; }
            public string Title { get; set; }
        }
        public List<MenuItem> Menu { get; set; }

        public MenuViewModel()
        {
            Menu = new List<MenuItem>()
            {
                new MenuItem(){ Icon = "ic_bed", Title ="Book a room" },
                new MenuItem(){ Icon = "ic_key", Title ="My room" },
                new MenuItem(){ Icon = "ic_beach", Title ="Suggestions" },
                new MenuItem(){ Icon = "ic_bot", Title ="Concierge" },
                new MenuItem(){ Icon = "ic_logout", Title ="Logout" },
            };
            
            //UserDialogs.Instance.
        }
        
    }
}
