using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace computecApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiPaginaControlDetail : ContentPage
    {
        public MiPaginaControlDetail()
        {
            InitializeComponent();
        }

        private async void MostrarInformacionTapped(object sender, EventArgs e)
        {
            var nombreDestino = "Laptop"; // Reemplaza con el nombre del destino correspondiente a esta imagen

            // Muestra una ventana emergente con información del destino
            await DisplayAlert("Información del producto", $"La laptop es un equipo compuesto por una pantalla líquida, " +
                $"alimentada con baterías o corriente alterna, puede durar más de dos horas de funcionamiento," +
                $"es liviana (usualmente pesa menos de 12 libras), presenta teclado integrado, panel táctil para manejar el puntero en lugar del ratón, entre otras características. {nombreDestino}", "Cerrar");
        }

        private async void MostrarInformacionTapped01(object sender, EventArgs e)
        {
            var nombreDestino = "Teclado Mecanico"; // Reemplaza con el nombre del destino correspondiente a esta imagen

            // Muestra una ventana emergente con información del destino
            await DisplayAlert("Información del producto", $"Un teclado gaming, o teclado mecánico, se diferencia de otros tipos de teclados en que cuentan con un mecanismo propio de pulsación, " +
                $" haciendo que cada una de las teclas sea totalmente independiente. Además, duran hasta 50 millones de pulsaciones, siendo que los teclados convencionales duran entre 5 y 10. {nombreDestino}", "Cerrar");
        }

        private async void MostrarInformacionTapped02(object sender, EventArgs e)
        {
            var nombreDestino = "Computadora"; // Reemplaza con el nombre del destino correspondiente a esta imagen

            // Muestra una ventana emergente con información del destino
            await DisplayAlert("Información del producto", $"Los monitores para gaming se llaman así porque están diseñados para las necesidades muy específicas de los videojuegos. " +
                $"Tienen paneles con alta velocidad de respuesta y frecuencias de actualización: ya conoces la diferencia entre esos dos. Mantienen el input lag al mínimo y no agregan ninguna molestia a tu imagen. {nombreDestino}", "Cerrar");
        }

        private async void MostrarInformacionTapped03(object sender, EventArgs e)
        {
            var nombreDestino = "Audifonos Inalambricos"; // Reemplaza con el nombre del destino correspondiente a esta imagen

            // Muestra una ventana emergente con información del destino
            await DisplayAlert("Información del producto", $"Los auriculares inalámbricos son auriculares que se conectan a un dispositivo, " +
                $"por ejemplo un smartphone, un altavoz estéreo, un televisor, una consola de videojuegos, un ordenador u otro dispositivo electrónico, sin utilizar cables.{nombreDestino}", "Cerrar");
        }

        private async void MostrarInformacionTapped04(object sender, EventArgs e)
        {
            var nombreDestino = "Mouse gamer"; // Reemplaza con el nombre del destino correspondiente a esta imagen

            // Muestra una ventana emergente con información del destino
            await DisplayAlert("Información del producto", $"El mouse gamer o ratón de juegos es un dispositivo periférico de computadora que en realidad es una extensión de la mano del jugador de videojuegos." +
                $"Es, ante todo, su herramienta de trabajo, por lo que no solo debe ser de alta calidad y conveniente, sino también lo más funcional posible. {nombreDestino}", "Cerrar");
        }

        private async void MostrarInformacionTapped05(object sender, EventArgs e)
        {
            var nombreDestino = " GeForce RTX® "; // Reemplaza con el nombre del destino correspondiente a esta imagen

            // Muestra una ventana emergente con información del destino
            await DisplayAlert("Información del producto", $"Las GPU GeForce RTX® Serie 30 proporcionan alto rendimiento para los jugadores y los creadores. Cuentan con la tecnología de Ampere, la arquitectura de RTX de 2.ª generación de NVIDIA, " +
                $"con los Núcleos RT de 2.ª generación y los Núcleos Tensor de 3.ª generación dedicados y multiprocesadores de transmisión para potenciar los gráficos con ray tracing y las funciones de IA de vanguardia. {nombreDestino}", "Cerrar");
        }
    }
}