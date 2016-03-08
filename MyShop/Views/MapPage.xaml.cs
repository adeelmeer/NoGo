using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MyShop
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            List<CustomPin> pins = new List<CustomPin>();
            pins.Add(new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Generic,
                    Position = new Position(37.70752, -122.40183),
                    Label = "You",
                    Address = "613 Rellim Drive, Old Bridge NJ"
                },
                Id = "You",
                Url = "http://xamarin.com/about/",
                Logo = "monkey.png"
            });
            pins.Add(new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(37.89752, -122.42183),
                    Label = "Solutions Garden",
                    Address = "Something Address, Old Bridge NJ"
                },
                Id = "Solutions Garden",
                Url = "http://xamarin.com/about/",
                Logo = "monkey.png"
            });
            pins.Add(new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(37.79752, -122.41183),
                    Label = "Solutions Garden 2",
                    Address = "Something Address 2, Old Bridge NJ"
                },
                Id = "Solutions Garden 2",
                Url = "http://xamarin.com/about/",
                Logo = "monkey.png"
            });

            customMap.CustomPins = pins;
            foreach (var pin in pins)
            {
                customMap.Pins.Add(pin.Pin);
            }
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.70752, -122.40183), Distance.FromMiles(15)));
        }
    }
}