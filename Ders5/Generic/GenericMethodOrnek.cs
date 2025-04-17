using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5.Generic
{
	public class GenericMethodOrnek
	{
		public void save<T>(T obj)
		{
			Console.WriteLine(obj.ToString()+"Kaydedildi");
		}
		public void Yazdir<T>(List<T> list) where T : struct
		{
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
