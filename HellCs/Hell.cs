using System;
using System.Dynamic;
using HellCs.Exceptions;

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
			if (string.IsNullOrEmpty(member)) throw new YouAreAnIdiotException();
			
			if (member.Length != 1) throw new BadPerformanceException();

			return new Hell(_dataSoFar + member);
		}
		
		// ReSharper disable once UnusedMember.Global
		public Hell this[string index] => GetMember(index);
	}
}