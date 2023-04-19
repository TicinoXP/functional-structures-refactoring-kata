namespace FunctionalRefactoring
{
    internal interface IStorage<in T>
    {
        void Flush(T item);
    }
}
