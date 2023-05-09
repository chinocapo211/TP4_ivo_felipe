public static class equipos{
    public static List<string> ListaEquipos {get; private set;} = new List<string> {"CABJ","CARP","Colo Colo","Argentinos Jr.","Banfield","Racing","Velez","Defensa y Justicia","Independiente","Chaco For Ever" };
    public static List<string> ListaMedias {get; private set;} = new List<string> {"m1.png","m2.png","m3.png","m4.png","m5.png","m6.png","m7.png","m8.png","m9.png","m10.png"};
    public static List<string> ListaPantalones {get; private set;} = new List<string> {"p1.jpg","p2.jpg","p3.jpg","p4.jpg","p5.jpg","p6.jpg","p7.jpg","p8.jpg","p9.jpg","p10.jpg"};
    public static List<string> ListaRemeras {get; private set;} = new List<string> {"r1.jpg","r2.jpg","r3.jpg","r4.jpg","r5.jpg","r6.jpg","r7.jpeg","r8.jpg","r9.jpg","r10.jpg"};
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