using System;
using System.ComponentModel;

namespace Generics.Interface;

public interface IContainer<T>
{
    void Add(T Items);
    T GetByIndex(int index);
    T[] GetAll();
}
