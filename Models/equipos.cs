public static class equipos{
    public static List<string> ListaEquipos {get; private set;} = new List<string> {"CABJ","CARP","Colo Colo","Argentinos Jr.","Banfield","Racing","Velez","Defensa y Justicia","Independiente","Chaco For Ever" };
    public static List<string> ListaMedias {get; private set;} = new List<string> {"1.png","2.png","3.png","4.png","5.png","6.png","7.png","8.png","9.png","10.png"};
    public static List<string> ListaPantalones {get; private set;} = new List<string> {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg"};
    public static List<string> ListaRemeras {get; private set;} = new List<string> {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpeg","8.jpg","9.jpg","10.jpg"};
    public static Dictionary<string, indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, indumentaria>{};
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