namespace FictionalShipping.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public Parcel(int length, int height, int width)
    {
      Length = length;
      Height = height;
      Width = 0;
    }
  }
}