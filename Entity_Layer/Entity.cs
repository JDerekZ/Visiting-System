using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Entity
    {
        
        private string _built;
        private string _classroom;


        public string Built { get => _built; set => _built = value; }
        public string Classroom { get => _classroom; set => _classroom = value; }

    }
}
