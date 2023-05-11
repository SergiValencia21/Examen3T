public class CD
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int AnioLanzamiento { get; set; }
    public string GeneroMusical { get; set; }
}

public static class MiColeccionDeCDs
{
    public static List<CD> coleccionDeCDs = new List<CD>();

    public static CD BuscarCDPorTitulo(string titulo)
    {
        foreach (CD cd in coleccionDeCDs)
        {
            if (cd.Titulo == titulo)
            {
                return cd;
            }
        }

        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CD miCD = new CD();
        miCD.Titulo = "The Dark Side of the Moon";
        miCD.Artista = "Pink Floyd";
        miCD.AnioLanzamiento = 1973;
        miCD.GeneroMusical = "Rock progresivo";

        MiColeccionDeCDs.coleccionDeCDs.Add(miCD);

        CD cdBuscado = MiColeccionDeCDs.BuscarCDPorTitulo("The Dark Side of the Moon");

        if (cdBuscado != null)
        {
            Console.WriteLine("El CD '{0}' fue encontrado.", cdBuscado.Titulo);
        }
        else
        {
            Console.WriteLine("El CD no fue encontrado.");
        }
    }
}