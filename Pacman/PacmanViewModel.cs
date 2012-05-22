using System.ComponentModel;

namespace Pacman
{
    public class PacmanViewModel : INotifyPropertyChanged
    {
        private string _mouth;
        private string _size;

        public PacmanViewModel()
        {
            Mouth = "40";
            Size = "100";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Mouth
        {
            get { return _mouth; }
            set
            {
                _mouth = value;
                OnPropertyChanged("Mouth");
            }
        }

        public string Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged("Size");
            }
        }

        public void OnPropertyChanged(string e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null) handler(this, new PropertyChangedEventArgs(e));
        }
    }
}