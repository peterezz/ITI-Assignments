namespace ExaminationSystem
{
    public class Answer<T> 
    {
        public T data { get; set; }

        public Answer(T data)
        {
            this.data = data;
        }



      
        public override string ToString()
        {
            return $"{data}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
