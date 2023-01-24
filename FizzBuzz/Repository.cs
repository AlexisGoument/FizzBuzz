using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IRepository
    {
        void Log(int nb, string result);
    }

    public class Repository : IRepository
    {
        public void Log(int nb, string result)
        {
            //throw new NotImplementedException();
        }
    }
}
