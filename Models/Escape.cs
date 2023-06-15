public static class Escape
{
    private static string[] incognitasSalas = { "2", "56", "3", "1297" };
    private static int estadoJuego = 1;

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if (Incognita != incognitasSalas[Sala - 1])
            return false;
        estadoJuego++;
        if (Sala == 4)
            estadoJuego = 1;
        return true;
    }
}


