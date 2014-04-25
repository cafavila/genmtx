using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimagroup.Generador2012.jsonObject
{
    public class Servicio
    {
        public string Transaccion { get; set; }
        public string Requerimiento { get; set; }
        public string Descripcion { get; set; }
        public string Comando { get; set; }
        public List<string> Programa { get; set; }
        public string XmlTuxedo { get; set; }
        public string MetodoJava { get; set; }
        public string VersionEspecificacionMtx { get; set; }
        public string toJSON() { return Newtonsoft.Json.JsonConvert.SerializeObject(this); }
    }
}