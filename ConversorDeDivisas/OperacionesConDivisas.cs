using System;
namespace ConversorDeDivisas
{
	class Conversion
	{
		public static decimal ToDolares(decimal euros)
		{
			decimal dolares = euros * 1.3M;
			return dolares;
		}
		public static decimal ToLibras(decimal euros)
		{
			decimal libras = euros * 1.42M;
			return libras;
		}
	}
}

