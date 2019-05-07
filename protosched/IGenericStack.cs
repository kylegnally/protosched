namespace protosched
{
    interface IGenericStack<T>
    {
        void Push(T Data);
        T Pop();

        bool IsEmpty { get; }
        int Size { get; }
    }
}
