using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica4.Models
{
    public class UltraExcepcion : Exception
    {
        public UltraExcepcion(String message) : base(message) { }

        public override string Message => "UltraExcepcion: " + base.Message;
    }
}