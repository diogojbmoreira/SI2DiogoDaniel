﻿using System.Collections.Generic;

namespace ConferenceManager.Model
{
    class Instituicao
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Pais { get; set; }
        public virtual List<Utilizador> UtilizadoresAssociados { get; set; }
    }
}
