using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5.Generic
{
	public class Animal
	{
		public string nickName;

		public override string ToString()
		{
			return "Animal [nickName=" + nickName + "]";
			// return $"nickName : {nickName}";
		}

		public void save(Animal a)
		{
			Console.WriteLine(a.ToString() + " kaydedildi");
		}
	}
}
