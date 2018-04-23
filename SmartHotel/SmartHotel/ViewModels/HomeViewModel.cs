using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using FFImageLoading.Forms;
using SmartHotel.ViewModels.Base;
using Xamarin.Forms;

namespace SmartHotel.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<View> _myItemSource;

        public HomeViewModel()
        {
            //ic_be_green
            //ic_hotel
            //ic_room
            //ic_others
            //MyItemSource = new ObservableCollection<View>()
            //{
            //    new CachedImage() {Source="ic_be_green", DownsampleToViewSize=true, Aspect=Aspect.AspectFill},
            //    new CachedImage() {Source="ic_hotel", DownsampleToViewSize=true, Aspect=Aspect.AspectFill},
            //    new CachedImage() {Source="ic_room", DownsampleToViewSize=true, Aspect=Aspect.AspectFill},
            //    new CachedImage() {Source="ic_others", DownsampleToViewSize=true, Aspect=Aspect.AspectFill},
            //};

            //MyCommand = new Command(() => { Debug.WriteLine(""); });
        }

    //    public Command MyCommand { protected set; get; }
    //    public ObservableCollection<View> MyItemSource { get { return _myItemSource; } set { _myItemSource = value; OnPropertyChanged("MyItemSource"); } }
    }
}
