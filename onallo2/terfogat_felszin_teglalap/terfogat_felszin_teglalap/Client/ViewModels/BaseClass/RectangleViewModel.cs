using System.ComponentModel;
using terfogat_felszin_teglalap.Client.Models;
namespace terfogat_felszin_teglalap.Client.ViewModels.BaseClass
{
    public class RectangleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private RectangleModel _rectangle = new RectangleModel();

        public double Length
        {
            get => _rectangle.Length;
            set
            {
                if (_rectangle.Length != value)
                {
                    _rectangle.Length = value;
                    OnPropertyChanged(nameof(Length));
                    OnPropertyChanged(nameof(SurfaceArea));
                    OnPropertyChanged(nameof(Volume));
                }
            }
        }

        public double Width
        {
            get => _rectangle.Width;
            set
            {
                if (_rectangle.Width != value)
                {
                    _rectangle.Width = value;
                    OnPropertyChanged(nameof(Width));
                    OnPropertyChanged(nameof(SurfaceArea));
                    OnPropertyChanged(nameof(Volume));
                }
            }
        }

        public double SurfaceArea => _rectangle.SurfaceArea;

        public double Volume => _rectangle.Volume;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
