using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHerenciaPolimorfismo.Models
{
    interface Animal
    {
        String GetNombre { get; }

        String Hablar { get; }

        String Caminar { get; }

        String Respirar { get; }
    }
}
