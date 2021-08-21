using System;

namespace Record
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

    public override string ToString()
    {
        return $"{From,-10} -> {To,-10} : ${Amount}";
    }
}
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
    
        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    

    

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
