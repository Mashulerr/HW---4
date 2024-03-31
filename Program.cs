using HW_4;
public class Program
{
    public static void Main(string[] args)
    {
        OneDimensionalArray<int> intArr = new OneDimensionalArray<int>();
        intArr.Add(5);
        intArr.Add(3);
        intArr.Add(8);
        intArr.Add(1);

        intArr.Sort();

        OneDimensionalArray<string> stringArr = new OneDimensionalArray<string>();
        stringArr.Add("apple");
        stringArr.Add("banana");
        stringArr.Add("cherry");

        stringArr.Reverse();
        
    }
}
