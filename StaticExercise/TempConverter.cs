using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FarenheitToCelsius(double farenheit)
		{
			double celsius = (farenheit - 32) / 1.8;
			return celsius;
		}

		public static double CelsiusToFarenheit(double celsius)
		{
			double farenheit = ((celsius * 9) / 5 + 32);
			return farenheit;
		}
	}
}

