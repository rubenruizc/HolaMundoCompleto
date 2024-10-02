using BibliotecaDeClases;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHolaMundo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String nombre = nombreTextBox.Text;
            String apellido = apellidoTextBox.Text;
            String dia = diaTextBox.Text;
            String mes = mesTextBox.Text;
            String anio = anioTextBox.Text;

            DateTime cumple = new DateTime();
            String fechaCumple = dia + "/" + mes + "/" + anio;
            cumple = DateTime.Parse(fechaCumple);


            ClPersona persona = new ClPersona(nombre, apellido, cumple);

            String mensajeMostrar = "Muy buenas " + persona.Nombre + " " + persona.Apellido + ", naciste el  " + persona.FechaNacimiento;

            MessageBoxResult resultado;

            resultado = MessageBox.Show(mensajeMostrar);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}