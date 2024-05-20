using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintAgro
{
    static class ConexaoBanco
    {
         
        private const string servidor = "Local instance MySQL80";
        private const string bancoDados = "dbagro";
        private const string usuario = "root";
        private const string senha = "nathinha";

        static public string bancoServidor = $"server={servidor}; user id={usuario};database={bancoDados};password={senha}";

        //label1.Text = $"A conexao com o banco {bancoDados} foi bem sucessida";
    }
          
}
