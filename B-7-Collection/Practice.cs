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
		//=====================================================================
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
			Console.WriteLine("= After arrayList.RemoveAt ==========================");
			songList.RemoveAt(songList.Count - 1);
			foreach (var song in songList)
			{
				Console.WriteLine(((Song)song).Lyrics);		//Явное указание типа объекта
			}
			Console.ReadLine();
		}
		//=====================================================================
		static public void B7_P3_5_GenericListOfSongsSort()
		{
			List<Song> songList = new List<Song>();
			for (int i = 5; i > 0; i--)
			{
				Console.WriteLine($"Введите текст добавляемой песни. Осталось добавить песен - {i}");
				Console.Write(" >> ");
				songList.Add(new Song(Console.ReadLine()));
			}
			Console.WriteLine("= After arrayList.Add ==========================");
			foreach (var song in songList)
			{
				Console.WriteLine(song.Lyrics);
			}
			Console.WriteLine("= After arrayList.RemoveAt ==========================");
			songList.RemoveAt(songList.Count - 1);
			foreach (var song in songList)
			{
				Console.WriteLine(song.Lyrics);     //А здесь ЯВНОЕ указание типа объекта уже не требуется
			}
			Console.ReadLine();
		}
		//=====================================================================
		static public void B7_P4_5_GenericListOfNeighborSearch()
		{
			// Создаем коллекцию 
			List<Neighbor> floorNeighbors = new List<Neighbor>();
			// Вводим данные воображаемых соседей в коллекцию
			Console.WriteLine($"Введите количество ваших соседей по этажу.");
			Console.Write($" >> ");
			int count = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Введите данные ваших соседей.");
			for (int i = count; i > 0; i--)
			{
				Console.WriteLine($"Осталось ввести - {i}");

				Console.Write("Введите имя соседа >> ");
				string name = Console.ReadLine();

				Console.Write("Введите номер квартиры соседа >> ");
				int flatNumber = Convert.ToInt32(Console.ReadLine());

				Console.Write("Введите номер телефона соседа >> ");
				int phoneNumber = Convert.ToInt32(Console.ReadLine());

				floorNeighbors.Add(new Neighbor(name, flatNumber, phoneNumber));
			}
			Console.WriteLine($"");
			Console.WriteLine($"Поиск по номеру квартиры");
			Console.WriteLine($"=========================");
			Console.WriteLine($"");
			Console.Write($"Введите номер квартиры >> ");
			int flatNum = Convert.ToInt32(Console.ReadLine());

			foreach(var sosed in floorNeighbors)
			{
				if(sosed.FlatNumber == flatNum)
				{
					Console.WriteLine($"Квартира - {sosed.FlatNumber}");
					Console.WriteLine($"Имя соседа - {sosed.FullName}");
					Console.WriteLine($"Номер телефона - {sosed.PhoneNumber}");
					break;
				}
			}
			Console.ReadLine();

		}
		public class Neighbor
		{
			public string FullName { get; set; }
			public int FlatNumber { get; set; }
			public int PhoneNumber { get; set; }

			public Neighbor(string FullName, int FlatNumber, int PhoneNumber)
			{
				this.FullName = FullName;
				this.FlatNumber = FlatNumber;
				this.PhoneNumber = PhoneNumber;
			}
		}
		//=====================================================================
		static public void B7_P5_5_DictionaryOfNeighborSearch()
		{
			Dictionary<int, Neighbor> floorNeighbors = new Dictionary<int, Neighbor>();
			floorNeighbors.Add(29, new Neighbor("Вася Пупкин", 29, 1234567));
			floorNeighbors.Add(30, new Neighbor("Петя Иванов", 30, 1230000));
			floorNeighbors.Add(31, new Neighbor("Вова Лопухов", 31, 9990088));

			Console.WriteLine($"Поиск по номеру квартиры");
			Console.WriteLine($"=========================");
			Console.WriteLine($"");
			Console.Write($"Введите номер квартиры >> ");
			int flatNum = Convert.ToInt32(Console.ReadLine());

			Neighbor selectedNeighbor;
			if (floorNeighbors.TryGetValue(flatNum, out selectedNeighbor))
			{
				Console.WriteLine($"В квартире {flatNum} живет {selectedNeighbor.FullName}, его номер телефона - {selectedNeighbor.PhoneNumber}");
			}
			else
			{
				Console.WriteLine("Key = \"tif\" is not found.");
			}
			Console.ReadLine();
		}

		
	}
}
