using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : ObservableObject
    {
        private SuperheroesService servicio;
        private List<Superheroe> lista;
        public MainWindowVM()
        {
            servicio = new SuperheroesService();
            lista = servicio.GetSamples();
            SuperheroeActual = lista[0];
            PosicionActual = 1;
            TotalHeroes = lista.Count;
        }

        private Superheroe superHeroeActual;
        public Superheroe SuperheroeActual
        {
            get { return superHeroeActual; }
            set
            {
                SetProperty(ref superHeroeActual, value);
            }
        }

        private int posicionActual;
        public int PosicionActual
        {
            get { return posicionActual; }
            set
            {
                SetProperty(ref posicionActual, value);
            }
        }

        private int totalHeroes;
        public int TotalHeroes
        {
            get { return totalHeroes; }
            set
            {
                SetProperty(ref totalHeroes, value);
            }
        }

        public void Avanzar()
        {
            if (PosicionActual < TotalHeroes)
            {
                PosicionActual++;
                SuperheroeActual = lista[PosicionActual - 1];
            }
        }
        public void Retroceder()
        {
            if (PosicionActual > 1)
            {
                PosicionActual--;
                SuperheroeActual = lista[PosicionActual - 1];
            }
        }

    }
}
