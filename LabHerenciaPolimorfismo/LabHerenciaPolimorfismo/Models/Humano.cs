using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public class Humano : Mamifero {

        public Humano(String nombre) : base(2, nombre) {
        }

        public override string Hablar() {
            return Nombre + " dice: Hola Mundo!!!";
        }
    }
}