using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_TEST
{
    public interface IController
    {
        Task GroupBy(params string[] props);
        void AddSomething();
    }
}
