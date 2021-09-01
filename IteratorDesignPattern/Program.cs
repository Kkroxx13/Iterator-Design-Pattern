using System;

namespace IteratorDesignPattern
{
    public class Program
    {
        public static void Main(String[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (IIterator iter = namesRepository.getIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                Console.WriteLine("Name : " + name);
            }
        }

    }

}
