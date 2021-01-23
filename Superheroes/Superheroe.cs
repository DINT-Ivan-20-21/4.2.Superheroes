using System.ComponentModel;

namespace Superheroes
{
    class Superheroe : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }
        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                if (_imagen != value)
                {
                    _imagen = value;
                    NotifyPropertyChanged("Imagen");
                }
            }
        }

        private bool _vengador;
        public bool Vengador
        {
            get => _vengador;
            set
            {
                if (_vengador != value)
                {
                    _vengador = value;
                    NotifyPropertyChanged("Vengador");
                }
            }
        }

        private bool _xmen;
        public bool Xmen
        {
            get => _xmen;
            set
            {
                if (_xmen != value)
                {
                    _xmen = value;
                    NotifyPropertyChanged("Xmen");
                }
            }
        }

        private bool _heroe;
        public bool Heroe
        {
            get => _heroe;
            set
            {
                if (_heroe != value)
                {
                    _heroe = value;
                    NotifyPropertyChanged("Heroe");
                }
            }
        }

        private bool _villano;
        public bool Villano
        {
            get => _villano;
            set
            {
                if (_villano != value)
                {
                    _villano = value;
                    NotifyPropertyChanged("Villano");
                }
                if (_villano)
                {
                    Vengador = false;
                    Xmen = false;
                }
            }
        }

        public Superheroe()
        {
            Heroe = true;
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe, bool villano)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
            Villano = villano;
        }

        public override bool Equals(object obj)
        {
            return obj is Superheroe superheroe &&
                   _nombre == superheroe._nombre &&
                   Nombre == superheroe.Nombre &&
                   _imagen == superheroe._imagen &&
                   Imagen == superheroe.Imagen &&
                   _vengador == superheroe._vengador &&
                   Vengador == superheroe.Vengador &&
                   _xmen == superheroe._xmen &&
                   Xmen == superheroe.Xmen &&
                   _heroe == superheroe._heroe &&
                   Heroe == superheroe.Heroe &&
                   _villano == superheroe._villano &&
                   Villano == superheroe.Villano;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
