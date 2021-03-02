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
      Parcel newParcel = new Parcel(0);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnsParcelLength_Int()
    {
      int length = 6;
      Parcel newParcel = new Parcel(length);
      int result = newParcel.Length;
      Assert.AreEqual(length, result);
    }
  }
}