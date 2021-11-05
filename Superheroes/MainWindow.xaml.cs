using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> superheroes = Superheroe.GetSamples();
        private int superHeroeActual = 1;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = superheroes[superHeroeActual-1];
        }

        private void SiguienteImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(superHeroeActual != 3)
            {
                superHeroeActual++;
                HeroeActualTextBlock.Text = superHeroeActual + "/3";
                DataContext = superheroes[superHeroeActual-1];
            }
        }

        private void AnteriorImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (superHeroeActual != 1)
            {
                superHeroeActual--;
                HeroeActualTextBlock.Text = superHeroeActual + "/3";
                DataContext = superheroes[superHeroeActual-1];
            }
        }
    }
}
