using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabHerenciaPolimorfismo.Models {

    public abstract class Mamifero {

        private int cantidadPatas;
        private String nombre;

        protected Mamifero(int patas, String nombre) {
            cantidadPatas = patas;
            this.nombre = nombre;
        }

        public abstract String Hablar();

        public String Respirar() {
            return Nombre + " suspira...";
        }

        public String Caminar() {
            return Nombre + " avanza unos pasos con sus " + CantidadPatas +" patas...";
        }

        protected int CantidadPatas => cantidadPatas;
        protected String Nombre => nombre;
    }
}