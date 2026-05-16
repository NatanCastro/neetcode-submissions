public class DynamicArray
{
    int[] list;
    int size = 0;

    public DynamicArray(int capacity)
    {
        list = new int[capacity];
    }

    public int Get(int i)
    {
        if (i >= size)
            throw new InvalidOperationException();
        return list[i];
    }

    public void Set(int i, int n)
    {
        if (i < 0 || i >= size)
            throw new InvalidOperationException();
        list[i] = n;
    }

    public void PushBack(int n)
    {
        if (size >= list.Length)
            Resize();
        list[size++] = n;
    }

    public int PopBack()
    {
        return list[--size];
    }

    private void Resize()
    {
        Array.Resize(ref list, list.Length * 2);
    }

    public int GetSize()
    {
        return size;
    }

    public int GetCapacity()
    {
        return list.Length;
    }
}