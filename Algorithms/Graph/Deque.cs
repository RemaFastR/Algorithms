namespace Algotithms
{
    ///<summary>
    /// Двусвязный список
    ///</summary>
    public class Deque<T> : IEnumerable<T> 
    { 
        ///<summary>
        /// Головной элемент (первый)
        ///</summary>
        DequeElement<T> head;
        ///<summary>
        /// Последний элемент (хвостовой)
        ///</summary>
        DequeElement<T> tail;
        ///<summary>
        /// Количество элементов
        ///</summary>
        int count;

        public void AddLast(T data){
            DequeElement<T> elem = new DequeElement<T>(data);

            if (head == null)
                head = elem;
            else
            {
                tail.Next = elem;
                elem.Previous = tail;
            }
            tail = node;
            count++;
        }
    }
}