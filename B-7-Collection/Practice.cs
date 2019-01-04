using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
	class Practice
	{
		/*public interface IComparable
		{
			int CompareTo(object o);
		}
		public class poemArray
		{
			public string Text { get; set; }
		}
		*/
		public static void B7_P1_5_ArrayListPoemSort()
		{
			
			ArrayList arrayList = new ArrayList();
			for (int i = 5; i > 0; i--)
			{
				Console.WriteLine($"Введите строку стихотворения. Осталось ввести строк - {i}");
				Console.Write(" >> ");
				arrayList.Add(Console.ReadLine());
			}
			Console.WriteLine("= After arrayList.Add ==========================");
			foreach (var str in arrayList )
			{
				Console.WriteLine(str);
			}
			Console.WriteLine("= After arrayList.Sort ==========================");
			arrayList.Sort();
			foreach (var str in arrayList)
			{
				Console.WriteLine(str);
			}
			Console.WriteLine("= After arrayList.RemoveAt ==========================");
			arrayList.RemoveAt(arrayList.Count - 1);
			foreach (var str in arrayList)
			{
				Console.WriteLine(str);
			}
			//var arraySorted = from str in arrayList orderby arrayList.
			Console.ReadLine();
		}

		public class Song
		{
			public string Name;
			public string Lyrics { get; set; }
			public Song()
			{
				Lyrics = "";
			}
			public Song(string lyrics)
			{
				Lyrics = lyrics;
			}
		}
		static public void B7_P2_5_ArrayListOfSongsSort()
		{

			ArrayList songList = new ArrayList();
			for (int i = 5; i > 0; i--)
			{
				Console.WriteLine($"Введите текст добавляемой песни. Осталось добавить песен - {i}");
				Console.Write(" >> ");
				songList.Add(new Song(Console.ReadLine()));
			}
			Console.WriteLine("= After arrayList.Add ==========================");
			foreach (var song in songList)
			{
				Console.WriteLine(((Song)song).Lyrics);
			}
			/*
			Console.WriteLine("= After arrayList.Sort ==========================");
			songList.Sort();
			foreach (var song in songList)
			{
				Console.WriteLine(((Song)song).Lyrics);
			}
			*/
			Console.WriteLine("= After arrayList.RemoveAt ==========================");
			songList.RemoveAt(songList.Count - 1);
			foreach (var song in songList)
			{
				Console.WriteLine(((Song)song).Lyrics);		//Явное указание типа объекта
			}
			//var arraySorted = from str in arrayList orderby arrayList.
			Console.ReadLine();
		}
	}
}
