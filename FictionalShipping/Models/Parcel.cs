namespace FictionalShipping.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Height { get; set; }

    public Parcel(int length, int height)
    {
      Length = length;
      Height = height;
    }
  }
}