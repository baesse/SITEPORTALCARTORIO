using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDesktop.Models
{
    public class JustificativadePonto
    {
        public DateTime dataocorrencia { get; set; }
        public string colaborador { get; set; }
        public string setor { get; set; }
        public string motivo { get; set; }
        public string jsutificativa { get; set; }
        public string abonado { get; set; }
        public string jsutificativadoabono { get; set; }
        public string caminhoarquivo { get; set; }

    }
}