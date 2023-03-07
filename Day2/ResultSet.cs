namespace Day2
{
    internal class ResultSet
    {
        public int item { get; set; }
        public int initIndex { get; set; }
        public int lastIndex { get; set; }
        public int distance { get { return lastIndex==initIndex? 0: lastIndex - initIndex - 1; }  }
    }
}
