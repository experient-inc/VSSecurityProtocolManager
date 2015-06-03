using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProtocolManagerVS2013
{
	public static class EnumHelper<TEnum>
	{
		#region static InnerList<TEnum>

		private static object _innerListLock = new object();
		private static List<TEnum> _innerList { get; set; }
		private static List<TEnum> InnerList
		{
			get
			{
				lock ( _innerListLock )
				{
					if ( _innerList == null )
					{
						_innerList = new List<TEnum>();

						IEnumerator eenum = Enum.GetValues(typeof(TEnum)).GetEnumerator();
						while ( eenum.MoveNext() )
							_innerList.Add((TEnum)eenum.Current);
					}

					return _innerList;
				}
			}
		}

		#endregion

		public static IEnumerable<TEnum> EnumToIEnumerable()
		{
			return InnerList.AsEnumerable();
		}

		public static TEnum GetAllValuesAsSingleInstance(Func<TEnum, TEnum, TEnum> flagOp)
		{
			TEnum e = EnumHelper<TEnum>.EnumToIEnumerable().FirstOrDefault();

			foreach ( TEnum i in EnumHelper<TEnum>.EnumToIEnumerable() )
				e = flagOp.Invoke(e, i);

			return e;
		}

		public static TEnum GetValuesAsSingleInstance(Func<TEnum, TEnum, TEnum> flagOp, params TEnum[] valueArray)
		{
			TEnum e = valueArray.FirstOrDefault();

			foreach ( TEnum i in valueArray )
				e = flagOp.Invoke(e, i);

			return e;
		}
	}
}
