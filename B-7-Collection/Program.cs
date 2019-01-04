using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
			//Practice.B7_P1_5_ArrayListPoemSort();
			Practice.B7_P2_5_ArrayListOfSongsSort();
			//ArrayListExample();
			//ArrayListExample2();

			Console.ReadLine();
        }

		static void ArrayListExample2()
		{
			var list = new ArrayList();
			for(int i = 0 ; i < 3; i++)
			{
				Console.WriteLine("Next row please");
				//var song = new ;
				list.Add(Console.ReadLine());
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			list.Sort();

			list.RemoveAt(list.Count - 1);
			foreach(var row in list)
			{
				Console.WriteLine(row);
			}
		}
		/*
		public class Song : //IComparable
		{
			public string Lyrics { get; set; }
			
		}
		*/
		/*
        public static void ArrayListExample()
        {
            var poem = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
            }

            //poem.Sort();
            poem.RemoveAt(poem.Count - 1);

            object[] myArray = poem.ToArray();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

        }
		*/
		/*
		public class Song
        {
            public string Lyrics;

            public override string ToString()
            {
                return this.Lyrics;
            }
        }
		*/
    }
}
