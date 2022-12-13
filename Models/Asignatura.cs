using System;

namespace platzi_asp_net_core.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        //public string Curso { get; set; }

        public List<Evaluación> Evaluaciones { get; set; }
    }
}