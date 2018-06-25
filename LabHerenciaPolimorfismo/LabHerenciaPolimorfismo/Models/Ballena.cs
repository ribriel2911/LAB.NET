using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public class Ballena : Mamifero {

        public Ballena(string nombre) : base(0, nombre) {
        }

        public override string Hablar {

            get {

                return Nombre + " canta♪♪♪";
            }
        }
    }
}