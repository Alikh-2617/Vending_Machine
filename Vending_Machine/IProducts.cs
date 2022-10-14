using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public interface IProducts
    {
        int Price();
        string Name();
        object Description();

    }
}
