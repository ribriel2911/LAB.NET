using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public abstract class Mamifero : Animal {

        private int cantidadPatas;
        private String nombre;

        protected Mamifero(int patas, String nombre) {
            cantidadPatas = patas;

            if (!String.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Unknown";
            }
        }

        public virtual String Hablar {

            get {

                return Nombre + " dice: ";
            }
        }

        public String Respirar {

            get {

                return Nombre + " suspira...";
            }
        }

        public String Caminar {
            get {

                return Nombre + " avanza unos pasos...";
            }
        }

        public string GetNombre => Nombre;

        protected int CantidadPatas => cantidadPatas;
        protected String Nombre => nombre;
    }
}