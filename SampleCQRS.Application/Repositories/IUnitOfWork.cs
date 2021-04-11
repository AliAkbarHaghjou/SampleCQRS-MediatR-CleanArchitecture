using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository Products { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}
