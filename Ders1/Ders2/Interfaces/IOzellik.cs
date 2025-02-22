using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2.Interfaces
{
	//Interfacenin özellikleri
	//1. multiple inheritance destek sağlar (çoklu kalıtıma destek sağlar )
	//2. strandartlara uymamızı zorunlu kılar
	//3. interface içindeki tüm methodlar public olmak zorundadır
	public interface IOzellik
	{

		public void Oku(string isim);
	}
}
