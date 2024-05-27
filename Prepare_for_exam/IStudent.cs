using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepare_for_exam
{
    public interface IStudent
    {
        string Name { get; }
        int Age { get; }
        string Major { get; }
    }
}
