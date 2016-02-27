using System;
using Xunit;

namespace UnitTestProject2
{
	public class UnitTest1 : IClassFixture<BaseClass>
	{
		[Fact]
		public void PassingTest()
		{
			Assert.Equal(4, Add(2, 2));
		}

		[Fact]
		public void FailingTest()
		{
			Assert.Equal(5, Add(2, 2));
		}

		private int Add(int x, int y)
		{
			return x + y;
		}
	}

	public class BaseClass : IDisposable
	{
		public BaseClass()
		{
		}

		public void Dispose()
		{
		}
	}
}