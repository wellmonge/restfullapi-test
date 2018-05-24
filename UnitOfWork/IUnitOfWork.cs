using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork
{

    public interface IUnitOfWork : IDisposable
    {
        IClientRepository BreedRepository { get; }

        void Commit();

    }
}
