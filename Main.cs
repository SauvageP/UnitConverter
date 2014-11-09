using System;

namespace UnitConverter
{
	class UnitConverter
	{
		int ratio;
		public UnitConverter (int unitRatio) {ratio = unitRatio;}
		public int Convert (int unit) {return unit * ratio;}
	}
	class Test 
	{
		public static void Main (string[] args)
		{
			UnitConverter feetToInchesConverter = new UnitConverter(12);
			UnitConverter milesToFeetConverter = new UnitConverter(5280);

			Console.WriteLine(feetToInchesConverter.Convert(30));
			Console.WriteLine(feetToInchesConverter.Convert(100));
			Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
		}
	}
}
