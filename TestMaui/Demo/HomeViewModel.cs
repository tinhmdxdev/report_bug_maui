using System.Collections.ObjectModel;

namespace TestMaui.Demo
{
    class HomeViewModel: NotifyPropertyChangedImpl
    {
        private ObservableCollection<DemoData> _items;
        public ObservableCollection<DemoData> Items
        {
            get
            {
                return _items;
            }
            private set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        private int _carouselCurrentItemIndex;

        public int CarouselCurrentItemIndex
        {
            get
            {
                return _carouselCurrentItemIndex;
            }
            private set
            {
                _carouselCurrentItemIndex = value;
                OnPropertyChanged(nameof(CarouselCurrentItemIndex));
            }
        }

        public Command OneCommand { get; }
        public Command TwoCommand { get; }
        public Command ThreeCommand { get; }
        public HomeViewModel()
        {
            Items = new ObservableCollection<DemoData>()
            {
                new DemoData("One", "icon_add.png"),
                new DemoData("Two", "icon_add.png"),
                new DemoData("Three", "icon_add.png"),
            };

            CarouselCurrentItemIndex = 0;

            OneCommand = new Command(() =>
            {
                System.Diagnostics.Debug.WriteLine("click 1");
                CarouselCurrentItemIndex = 0;
            });
            TwoCommand = new Command(() =>
            {

                System.Diagnostics.Debug.WriteLine("click 2");
                CarouselCurrentItemIndex = 1;
            });
            ThreeCommand = new Command(() =>
            {
                System.Diagnostics.Debug.WriteLine("click 3");
                CarouselCurrentItemIndex = 2;
            });
        }
    }

    class DemoData
    {
        public string Title { get; set; }
        public string Image { get; set; }

        public DemoData(string title, string image)
        {
            Title = title;
            Image = image;
        }
    }
}
