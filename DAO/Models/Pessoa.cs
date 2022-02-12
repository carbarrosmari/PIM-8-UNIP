using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLinq.Models
{
    public class Pessoa
    {
        internal string Bairro;

        public int Id { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public string Logradouro { get; internal set; }
        public string Numero { get; internal set; }
        public string Cep { get; internal set; }
        public string Cidade { get; internal set; }
        public string Estado { get; internal set; }
        public string DDD { get; internal set; }
        public string TipoTelefone { get; internal set; }
        public string NumeroTelefone { get; internal set; }
    }
}