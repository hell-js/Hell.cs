using HellCs.Exceptions;
using NUnit.Framework;

namespace HellCs.Test
{
	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void Setup() { }

		[Test]
		public void CompileTest()
			=> Assert.AreEqual("Test of Hell.c#", Hell.Compile(hell => hell.T.e.s.t[" "].o.f[" "].H.e.l.l["."].c["#"]));

		[Test]
		public void MultiCharCompileFailTest()
			=> Assert.Throws<BadPerformanceException>(() => Hell.Compile(hell => hell.tttttt));
		
		[Test]
		public void EmptyStringCompileFailTest()
			=> Assert.Throws<YouAreAnIdiotException>(() => Hell.Compile(hell => hell[""]));
		
		[Test]
		public void NullStringCompileFailTest()
			=> Assert.Throws<YouAreAnIdiotException>(() => Hell.Compile(hell => hell[null]));
	}
}