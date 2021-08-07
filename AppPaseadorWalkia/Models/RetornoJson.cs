using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminAppTurismo.Models
{
    public class RetornoJson
    {

        [JsonProperty("conteo")]
        public int existe = 0;
        [JsonProperty("nombre")]
        public string nombre = "";
        [JsonProperty("apellido")]
        public string apellido = "";
        [JsonProperty("Correo")]
        public string Correo = "";
        [JsonProperty("Gen")]
        public string Gen = "";
        [JsonProperty("Fecha")]
        public string Fecha = "";
        [JsonProperty("id")]
        public string id = "";
        [JsonProperty("ruta")]
        public string ruta = "";
        [JsonProperty("ruta")]
        public string foto = "";
        [JsonProperty("pass")]
        public string pass = "";

    }
    public class RetornoCheckEmail
    {
        [JsonProperty("conteo")]
        public int existe = 0;
    }
}
