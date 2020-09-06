using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Interfaces
{
    public interface IRepository<T> where T: IBasePage
    {
        T Get();
    }
}
