using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Generics.Interface;

namespace Generics.Models;

public class Container<T> : IContainer<T>
{
    public List<T> GoggenFIles = new();
    public void Add(T Items) => GoggenFIles.Add(Items);

    public T[] GetAll()
    {
        return GoggenFIles.ToArray();
    }
    
    public T GetByIndex(int index)
    {
        if (index < 0 || index >= GoggenFIles.Count)
        {
            throw new IndexOutOfRangeException("Nothing to select");
        }
        return GoggenFIles[index];
    }

}
