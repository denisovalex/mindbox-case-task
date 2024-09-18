namespace AreaCalculationLibTests
{
	[TestClass]
	public class CircleTests
	{
		[TestMethod]
		public void CalculateAreaTest()
		{
			var circle = new Circle(5);

			Assert.AreEqual(Math.PI * Math.Pow(5, 2), circle.CalculateArea());
		}

		[TestMethod]
		public void CalculateAreaExceptionTest()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
		}
	}
}
