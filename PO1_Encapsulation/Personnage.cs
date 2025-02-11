using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int attaque;

        public int PointDeVie { get => pointDeVie; set { if (value<0)
                {value=0 
                { 

} } =>  pointDeVie = value; }
        public int Attaque { get => attaque; set => attaque = value; }
    }
}
