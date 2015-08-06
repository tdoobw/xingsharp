using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class TRRequest
	{
		public delegate void OnComplete(TRResult tr_res);
		public OnComplete CompleteCB;


		public TRRequest()
		{
		}

		public void PushResult<T>(T inst, string obj_name, ref TRResult result)
		{
			Dictionary<string, string> kv = new Dictionary<string, string>();
			foreach (FieldInfo field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Instance))
			{
				if (field.FieldType.Name == "Byte[]")
				{
					byte[] ori_val = (byte[])field.GetValue(inst);

					string utf8_str = Encoding.GetEncoding(51949).GetString((byte[])ori_val, 0, ori_val.Length - 1).Trim();
					kv.Add(field.Name, utf8_str);
				}
			}
			result.map_.Add(obj_name, kv);
		}
	}
}
