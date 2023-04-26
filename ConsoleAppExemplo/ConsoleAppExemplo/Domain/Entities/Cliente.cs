using ConsoleAppExemplo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExemplo.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public DateTime DataCadastro { get; set; }
        public StatusCliente StatusCliente { get; set; }

        public void Cadastrar()
        {
            DataCadastro = DateTime.Now;
            StatusCliente = StatusCliente.ATIVO;
        }
    }
}
