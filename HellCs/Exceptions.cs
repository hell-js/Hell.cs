using System;

// ReSharper disable once CheckNamespace
namespace HellCs.Exceptions
{
	public class BadPerformanceException : Exception
	{
		private const string Msg = "Why are you trying to break Hell.cs by passing empty strings???";

		public override string Message => Msg;
		internal BadPerformanceException() {}
	}
	
	public class YouAreAnIdiotException : Exception
	{
		private const string Msg = "Hell.cs disallows using multiple characters at once for performance reasons";

		public override string Message => Msg;
		internal YouAreAnIdiotException() {}
	}
	
}