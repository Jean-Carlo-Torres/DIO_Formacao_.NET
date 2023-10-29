using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.model;

public static class intExtensions
{
    public static bool EhPar(this int numero){
        return numero % 2 == 0;
    }
}