using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.Mapping.Repo
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit(bool state = true);
    }
}
