using System.Windows.Input;

namespace Superheroes
{
    public static class Comandos
    {
        public static readonly RoutedUICommand Aceptar = new RoutedUICommand
            (
                "Aceptar",
                "Aceptar",
                typeof(Comandos),
                null
            );
        public static readonly RoutedUICommand Limpiar = new RoutedUICommand
            (
                "Limpiar",
                "Limpiar",
                typeof(Comandos),
                null
            );
    }
}
