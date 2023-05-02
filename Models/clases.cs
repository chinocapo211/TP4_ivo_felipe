public class indumentaria{
    public string Medias {get; private set;}
    public string Pantalon {get; private set;}
    public string Camiseta {get; private set;}
    public void constructorIndu(string medi, string pan, string cami){
        Medias = medi;
        Pantalon = pan;
        Camiseta = cami;
    }
}
public static class equipos{
    public static List<string> ListaEquipos {get; private set;}
    public static List<string> ListaMedias {get; private set;}
    public static List<string> ListaPantalones {get; private set;}
    public static List<string> ListaRemeras {get; private set;}
    public static Dictionary<string, indumentaria> EquiposIndumentaria {get; private set;}
    static public bool ingresaIndumentaria(string EquipoSeleccionado, indumentaria item)
    {
        bool devolver = false;
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
        {
            EquiposIndumentaria.Add(EquipoSeleccionado,item);
            devolver = true;
        }
        return devolver;
    }
}
