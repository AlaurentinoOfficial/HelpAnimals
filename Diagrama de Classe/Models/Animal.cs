using System;

namespace pj1_2bimestre.Models
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Raca { get; set; }
        public DateTime DataDeNascimento { get; set; }

        internal Usuario Usuario
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