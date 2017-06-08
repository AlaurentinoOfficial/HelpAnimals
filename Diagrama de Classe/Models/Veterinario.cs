using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj1_2bimestre.Models
{
    class Veterinario
    {
        public string Nome { get; set; }
        public string Local { get; set; }

        public HelpAnimals.Item Item
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
