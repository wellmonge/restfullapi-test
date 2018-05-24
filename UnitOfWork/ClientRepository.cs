using System.Data;

namespace UnitOfWork
{
    internal class ClientRepository : IClientRepository
    {
        private IDbTransaction _transaction;

        public ClientRepository(IDbTransaction transaction)
        {
            _transaction = transaction;
        }
    }
}