using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public class Serpiente : Animal {

        private String nombre;

        public Serpiente(String nombre) {
            this.nombre = nombre;
        }

        public string Caminar {

            get {

                return Nombre + " se arrastra...";
            }
        }

        public string Hablar {

            get {
                return Nombre + " dice: ZZZ!!!";
            }
        }

        public string Respirar {
            get {

                return Nombre + " suspira...";
            }
        }

        protected String Nombre => nombre;
    }
}