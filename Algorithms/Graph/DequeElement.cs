namespace Algotithms
{
    ///<summary>
    /// Элемент двусвязного списка
    ///</summary>
    public class DequeElement<T>
    { 
        ///<summary>
        /// Данные
        ///</summary>
        public T Data {get;set;}
        ///<summrary>
        /// Предыдущий элемент
        ///</summrary>
        public DequeElement<T> Previous {get;set;}
        ///<summrary>
        /// Следующий элемент
        ///</summrary>
        public DequeElement<T> Next {get;set;}

        public DequeElement(T data){
            Data = data;
        }
    }
}