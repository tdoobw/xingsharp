using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class MultiMap<K, V>
	{
		private Dictionary<K, List<V>> dic_ = new Dictionary<K, List<V>>();

		public void Add(K key, V val)
		{
			List<V> temp_list;

			if (dic_.TryGetValue(key, out temp_list) == true)
			{
				temp_list.Add(val);
			}
			else
			{
				temp_list = new List<V>();
				temp_list.Add(val);
				dic_[key] = temp_list;
			}
		}


		public IEnumerable<K> Keys
		{
			get { return dic_.Keys; }
		}


		public List<V> this[K key]
		{
			get
			{
				List<V> list;
				if (!dic_.TryGetValue(key, out list))
				{
					list = new List<V>();
					dic_[key] = list;
				}
				return list;
			}
		}


		public int Count
		{
			get { return dic_.Count; }
		}
	}
}
