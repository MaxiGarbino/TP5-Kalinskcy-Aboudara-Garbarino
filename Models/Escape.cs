/*
 Debe contener los siguientes atributos privados:

static string[] incognitasSalas
(Aquí almacenaremos las soluciones de cada sala en formato texto. En el caso de que un resultado de sala sea en otro tipo de dato convertirlo a string antes de compararlo)
static int estadoJuego;
(Indicara que numero de Sala fue la última resuelta, Inicialmente en 1)
        Y los siguientes Métodos:

private static void InicializarJuego()
Inicializa el juego con el array de incógnitas correctas.
public static int GetEstadoJuego()
Retorna el estado del juego.

public static bool ResolverSala(int Sala, string Incognita)
(Recibe el número de sala a resolver y la incógnita elegida por el usuario. Debe validar con EstadoJuego si puede resolver dicha sala (devolver false si está resolviendo una sala a la que aún no tenga acceso) y luego validar la incógnita de la sala en cuestión devolviendo true o false si es correcta o no.) incrementando EstadoJuego en caso de ser correcta.
Tener en cuenta que si el array de incógnitas tiene 0 elementos debe llamar a InicializarJuego (como ocurrió con el TP anterior)
*/

public static class Escape 
{
    static string[] incognitasSalas = {"hola", "hol", "ho", "h"};
    static int estadoJuego;

    public static int GetEstadoJuego() {
        int a = 0;
        return a;
    }

    public static bool ResolverSala(int Sala, string Incognita) {
        bool b = true;
        return b;
    }
}


