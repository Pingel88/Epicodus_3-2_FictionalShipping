using Microsoft.VisualStudio.TestTools.UnitTesting;
using FictionalShipping.Models;

namespace FictionalShipping.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(0, 0);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnsParcelLength_Int()
    {
      int length = 6;
      Parcel newParcel = new Parcel(length, 0);
      int result = newParcel.Length;
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void GetHeight_ReturnsParcelHeight_Int()
    {
      int height = 6;
      Parcel newParcel = new Parcel(0, height);
      int result = newParcel.Height;
      Assert.AreEqual(height, result);
    }
  }
}