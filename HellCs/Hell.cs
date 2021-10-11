using System;
using System.Dynamic;

namespace HellCs
{
	public class Hell: DynamicObject
	{
		public static string Compile(Func<dynamic, Hell> hell) => hell(new Hell(""))._dataSoFar;

		private readonly string _dataSoFar;

		private Hell(string data) => _dataSoFar = data;

		// handles dynamic binding
		public override bool TryGetMember(GetMemberBinder binder, out object? result)
		{
			result = GetMember(binder.Name);
			return true;
		}
		
		private Hell GetMember(string member)
		{
			if (member.Length > 1)
			{
				throw new InvalidOperationException("Hell.cs disallows using multiple characters at once for performance reasons");
			}
			
			return new Hell(_dataSoFar + member);
		}
		
		public Hell this[string index] => GetMember(index);
	}
}