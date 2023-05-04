public static class equipos{
    public static List<string> ListaEquipos {get; private set;} = new List<string> {"CABJ","CARP","Colo Colo","Argentinos Jr.","Banfield","Racing","Velez","Defensa y Justicia","Independiente","Chaco For Ever" };
    public static List<string> ListaMedias {get; private set;} = new List<string> {"m1","m2","m3","m4","m5","m6","m7","m8","m9","m10"};
    public static List<string> ListaPantalones {get; private set;} = new List<string> {"p1","p2","p3","p4","p5","p6","p7","p8","p9","p10"};
    public static List<string> ListaRemeras {get; private set;} = new List<string> {"r1","r2","r3","r4","r5","r6","r7","r8","r9","r10"};
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