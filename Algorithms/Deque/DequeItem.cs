namespace Algorithms
{
    public class DequeItem<T>
    {
        public T Data { get; set; }
        public DequeItem<T> Previous { get; set; }
        public DequeItem<T> Next { get; set; }
        
        public DequeItem(T data){
            Data = data;
        }
    }
}