﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_VeriGetirme.Entities
{
	public class Urun
	{
		public int UrunID { get; set; }
		public string UrunAdi { get; set; }
		public float Fiyat { get; set; }
		public ICollection<Parca> Parcalar { get; set; }
	}
}
