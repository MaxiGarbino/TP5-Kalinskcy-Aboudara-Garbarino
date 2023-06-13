public static class Escape
{
    private static string[] incognitasSalas = { "56", "2", "ho", "1297" };
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
        return true;
    }
}


