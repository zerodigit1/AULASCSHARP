using Aula02_module.BLL.Business;
using Aula02_module.DAL.Database;
using Aula02_module.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_module.BLL.Facade
{
    public class PessoasFacade
    {
        private PessoasBusiness pessoasBusiness;
        public PessoaFisica Get(int id)
        {
            // chamar outra classe para obter o banco ce dados
            return null;
        }

        public List<PessoaFisica> GetAllDBPessoasFisicas()
        {
            List<PessoaFisica> allpf = new List<PessoaFisica>();
            var dbCon = DBConnection.Instance();
            dbCon.Server = "Serversql10.freesqldatabase.com";
            dbCon.DatabaseName = "sql10733542";
            dbCon.UserName = "sql10733542";
            dbCon.Password = "ac1VlfvwVE";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "select id,nome,cpf from Pessoas";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allpf.Add(new PessoaFisica { Cpf = reader.GetString(2), Nome = reader.GetString(1) });
                    Console.WriteLine($"ID:{reader.GetString(0)},NOME:{reader.GetString(1)},CPF:{reader.GetString(3)}");
                }

                dbCon.Close();
            }
            return allpf;
        }
        public List<Pessoa> ListAllPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Fonts";
            pessoaFisica.Cpf = "1234567";
            pessoas.Add(pessoaFisica);
            pessoas.Add(new PessoaFisica { Cpf = "33445566", Nome = "Joao" });
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "CD6";
            pessoaJuridica.Cnpj = "58142003000133";
            pessoas.Add(pessoaJuridica);
            return pessoas;
        }
    }
}
