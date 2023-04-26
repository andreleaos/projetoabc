using ConsoleAppExemplo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExemplo.Domain.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string DataCadastro { get; set; }
        public int StatusClienteId { get; set; }
        public string StatusCliente { get; set; }
    }
}
