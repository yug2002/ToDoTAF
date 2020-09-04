using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.Interfaces
{
    public interface IRepository<T> where T: IBasePage
    {
        T Get();
    }
}
