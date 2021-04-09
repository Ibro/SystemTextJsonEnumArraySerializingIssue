using System;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SystemTextJsonEnumArraySerializingIssue
{
	public enum SimpleEnum
	{
		One,
		Two,
		Three
	}

	public class SimpleClass
	{
		public SimpleEnum Value;
	}

	public class Program
	{
		public static void Main()
		{
			SerializeClassArrayNewtonsoft();
			SerializeEnumArrayNewtonsoft();

			//try
			//{
			//	SerializeClassArray();
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e);
			//}

			//Console.WriteLine();
			//Console.WriteLine();
			//Console.WriteLine();

			//try
			//{
			//	SerializeEnumArray();
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e);
			//}
		}

		private static void SerializeClassArray()
		{
			var array = new SimpleClass[4, 3];

			for (var i = 0; i <= 3; i++)
			{
				for (var j = 0; j <= 2; j++)
				{
					array[i, j] = new SimpleClass();
				}
			}

			var serialized = JsonSerializer.Serialize(array);
			Console.WriteLine(serialized);
		}

		private static void SerializeEnumArray()
		{
			var array = new SimpleEnum[4, 3];

			for (var i = 0; i <= 3; i++)
			{
				for (var j = 0; j <= 2; j++)
				{
					array[i, j] = SimpleEnum.Two;
				}
			}

			var serialized = JsonSerializer.Serialize(array);
			Console.WriteLine(serialized);
		}


		private static void SerializeClassArrayNewtonsoft()
		{
			var array = new SimpleClass[4, 3];

			for (var i = 0; i <= 3; i++)
			{
				for (var j = 0; j <= 2; j++)
				{
					array[i, j] = new SimpleClass();
				}
			}

			var serialized = JsonConvert.SerializeObject(array);
			Console.WriteLine(serialized);
		}

		private static void SerializeEnumArrayNewtonsoft()
		{
			var array = new SimpleEnum[4, 3];

			for (var i = 0; i <= 3; i++)
			{
				for (var j = 0; j <= 2; j++)
				{
					array[i, j] = SimpleEnum.Two;
				}
			}

			var serialized = JsonConvert.SerializeObject(array);
			Console.WriteLine(serialized);
		}
	}
}
