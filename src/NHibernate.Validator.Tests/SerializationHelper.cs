using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NHibernate.Validator.Tests
{
	public static class SerializationHelper
	{
		public static byte[] Serialize(object obj)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(ms, obj);
				return ms.ToArray();
			}
		}

		public static object Deserialize(byte[] data)
		{
			using (MemoryStream ms = new MemoryStream(data))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				return formatter.Deserialize(ms);
			}
		}
	}
}
