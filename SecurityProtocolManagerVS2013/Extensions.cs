using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProtocolManagerVS2013
{
	public static class Extensions
	{
		/// <summary>
		/// Produce a more extensive dump of exception, including inner
		/// exceptions, compared to Exception.ToString().
		/// </summary>
		public static string ExceptionDump(this Exception ex)
		{
			StringBuilder SB = new StringBuilder();
			for ( Exception e = ex; e != null; e = e.InnerException )
			{
				if ( SB.Length > 0 )
					SB.AppendLine();
				SB.AppendLine("Type: " + e.GetType().FullName);
				SB.AppendLine("Message: " + e.Message);
				if ( !string.IsNullOrEmpty(e.HelpLink) )
					SB.AppendLine("HelpLink: " + e.HelpLink);
				if ( !string.IsNullOrEmpty(e.Source) )
					SB.AppendLine("Source: " + e.Source);
				if ( e.TargetSite != null )
					SB.AppendLine("TargetSite: " + e.TargetSite.ToString());
				if ( !string.IsNullOrEmpty(e.StackTrace) )
					SB.AppendLine("StackTrace: " + e.StackTrace);
			}
			return SB.ToString();
		}

		/// <summary>
		/// Wraps a single object into an IEnumerable of that
		/// type, so single results can be returned from "Get
		/// List" functions, concatenated onto other Enumerables,
		/// etc.
		/// </summary>
		public static IEnumerable<T> Solo<T>(this T input)
		{
			if ( input == null )
				return new T[0];
			return new T[] { input };
		}
	}
}
