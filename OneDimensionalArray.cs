using System;
using System.Collections.Generic;
namespace HW_4 {


public class OneDimensionalArray<T>
{
    private T[] array;
    private int capacity;
    private int size;


    public void Simple()
    {
        if (capacity <= 0)
        {
        Console.WriteLine("Емкость должна быть положительной.");

        this.capacity = capacity;
        array = new T[capacity];
        size = 0;
    }
}

    public void Add(T elem)
    {
        if (size == capacity)
        {
            capacity = capacity * 2 + 1;
            
        }

        array[size] = elem;
        size++;
    }

    public void Remove(T elem)
    {
        

        int index = Array.IndexOf(array, elem);
        for (int i = index; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }

        size--;

        
    }

    public void Sort()
    {
        Array.Sort(array, 0, size);
    }

    public int Count()
    {
        return size;
    }

    public int Count(Func<T, bool> condition )
    {
        int count = 0;
        for (int i = 0; i < count; i++)
        {
            if (condition(array[i]))
                count++;
        }
        return count;
    }

    public bool Any(Func<T, bool> condition)
    {
        for(int i = 0; i < capacity; i++)
        {
            if(condition(array[i]))
            return true;
        }
        return false;
    }

    public bool All(Func<T, bool> condition)
    {
        return array.Any();
    }
    
     public bool Availability(T elem)
     {
        return Array.IndexOf(array, elem) != -1;
    
     }

    public T FirstElem(Func<T, bool> conditiopn)
    {
        for(int i = 0; i < capacity; i++)
        {
            if(conditiopn(array[i]))
            {
                return array[i];
            }
        }

        return  default(T);
    }

    public void ForEachAction(Action<T> action)
    {
       for ( int i = 0; i < capacity; i++)
       {
        action(array[i]);
       }
    } 


  public void Reverse()
    {
        Array.Reverse(array, 0, size);
    }

 public T Min()
    {
        T min = array[0]; 
        for (int i = 0 ; i < capacity; i++)
        {
            if (Comparer<T>.Default.Compare(array[i], min) < 0)
            {
                min = array[i];
            }
           
        }
        return min;
}

public T Max()
{
    T max = array[0];
    for(int i = 0; i < capacity; i++)
    {
        if(Comparer<T>.Default.Compare(array[i], max) > 0)
        {
            max = array[i];
        }
    }
    return max;
}

}

} 

    

   

   
