using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Interfaces
{
    public interface IUoW
    {
        IRepository<HomePage> HomePage { get; }
        IRepository<LoginPage> LoginPage { get; }
    }
}
