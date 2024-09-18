namespace AreaCalculationLibTests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void CalculateAreaTest()
		{
			var triangle = new Triangle(3, 4, 5);

			Assert.AreEqual(6, triangle.CalculateArea());
		}

		[TestMethod]
		public void CalculateAreaAOORExceptionTest()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
		}

		[TestMethod]
		public void CalculateAreaArgumentExceptionTest()
		{
			Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 70));
		}
	}
}
