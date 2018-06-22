using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public class Perro : Mamifero {

        public Perro(String nombre) : base(4, nombre) {
        }

        public override string Hablar() {
            return Nombre + " dice: Guau!!!";
        }
    }
}