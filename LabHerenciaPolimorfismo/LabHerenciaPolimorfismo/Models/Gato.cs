using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public class Gato : Mamifero {

        public Gato(String nombre) : base(4, nombre) {
        }

        public override string Hablar() {
            return Nombre + " dice: Miau!!!";
        }
    }
}