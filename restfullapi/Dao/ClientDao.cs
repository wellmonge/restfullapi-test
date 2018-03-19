using Microsoft.Extensions.Configuration;
using restfullapi.Models;

using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace restfullapi.Dao
{
    public class ClientDao
    {
        private IConfiguration _config;

        private SqlConnection _conn;

        public ClientDao(IConfiguration config)
        {
            _config = config;
            _conn = new SqlConnection(_config.GetConnectionString("BaseTeste"));

        }

        public Client ClientById(long id)
        {

            using (var con = _conn)
            {
                return con.QueryFirstOrDefault<Client>(@"
                    select 
                        client_id, 
                        client_name, 
                        client_desc, 
                        cpf 
                    from client
                    where client_id = @client_id",
                    new { client_id = id });

            }

        }

        public IList<Client> AllClients()
        {
            var teste = _config.GetConnectionString("BaseTeste");

            using (var con = new SqlConnection(_config.GetConnectionString("BaseTeste")))
            {
                return con.Query<Client>(@"
                    select 
                        client_id, 
                        client_name, 
                        client_desc, 
                        cpf 
                    from client").AsList<Client>();

            }

        }


        public bool CreateClient(Client client)
        {
            try
            {
                using (var con = _conn)
                {
                    con.Execute(@"insert client 
                                ( client_name, client_desc, cpf) 
                                values 
                                ( @client_name, @client_desc, @cpf)", client);
                }

                return true;
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }
    }
}
