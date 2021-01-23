using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Superheroes
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly List<Superheroe> superheroes;

        private Superheroe _superheroeSeleccionado;
        public Superheroe SuperheroeSeleccionado
        {
            get => _superheroeSeleccionado;
            set
            {
                if (_superheroeSeleccionado != value)
                {
                    _superheroeSeleccionado = value;
                    NotifyPropertyChanged("SuperheroeSeleccionado");
                }
            }
        }

        private Superheroe _superheroeNuevo;

        public Superheroe SuperheroeNuevo
        {
            get => _superheroeNuevo;
            set
            {
                if (_superheroeNuevo != value)
                {
                    _superheroeNuevo = value;
                    NotifyPropertyChanged("SuperheroeNuevo");
                }
            }
        }

        private int _indice;

        public int Indice
        {
            get => _indice;
            set
            {
                if (_indice != value && (value >= 1 && value <= Cantidad))
                {
                    _indice = value;
                    NotifyPropertyChanged("Indice");
                }
            }
        }


        private int _cantidad;

        public int Cantidad
        {
            get => _cantidad;
            set
            {
                if (_cantidad != value)
                {
                    _cantidad = value;
                    NotifyPropertyChanged("Cantidad");
                }
            }
        }

        public MainWindowViewModel()
        {
            superheroes = DatosService.GetSamples();
            Cantidad = superheroes.Count;
            Indice = 1;
            SuperheroeSeleccionado = superheroes[Indice - 1];
            SuperheroeNuevo = new Superheroe();
        }

        public void AñadirSuperheroe()
        {
            superheroes.Add(SuperheroeNuevo);
            Cantidad = superheroes.Count;
            LimpiarSuperheroe();
        }

        public bool ComprobarAñadirSuperheroe()
        {
            return SuperheroeNuevo.Nombre != null && SuperheroeNuevo.Imagen != null;
        }

        public void LimpiarSuperheroe()
        {
            SuperheroeNuevo = new Superheroe();
        }

        public bool ComprobarLimpiarSuperheroe()
        {
            return !SuperheroeNuevo.Equals(new Superheroe());
        }

        internal void ActualizaIndice(string valor)
        {
            Indice += int.Parse(valor);
            SuperheroeSeleccionado = superheroes[Indice - 1];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
