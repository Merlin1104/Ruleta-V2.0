using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta_V2._0
{
    // enum musi mat nejake nazvoslovie, nie iba cisla
    public enum Farba
    {
        zelena,
        cerna,
        cervena
    }

    public enum Lichost
    {
        zadna,
        suda,
        licha
    }
    public enum Rada
    {
        zadna,
        prva,
        druha,
        tretia
    }
    public enum Rozsah
    {
        zadny, // nula, kt nikam nepatri
        R1_12,
        R13_24,
        R25_36,
        R1_18,
        R19_36

    }

}
