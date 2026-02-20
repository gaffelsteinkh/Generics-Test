using System;
using System.Numerics;

namespace Generics.Models;

public static class GenericCalc<T> where T : INumber<T>
{
    public static T Add(T n1, T n2) => n1 + n2;
    public static T Sub(T n1, T n2) => n1 - n2;
    public static T Mul(T n1, T n2) => n1 * n2;
    public static T Div(T n1, T n2)
    {
        if (n2 == T.Zero)
        {
            throw new DivideByZeroException();
        }
        else
            return n1 / n2;
    }
    
}
