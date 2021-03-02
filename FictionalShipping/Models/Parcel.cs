using System.Numerics;
using System.Collections.Generic;

namespace FictionalShipping.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }

    private static List<Parcel> _parcels = new List<Parcel> {};

    public Parcel(int length, int height, int width)
    {
      Length = length;
      Height = height;
      Width = width;
      _parcels.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _parcels;
    }

    public Parcel(int length, int height, int width, int weight)
      : this (length, height, width)
    {
      Weight = weight;
    }

    public int GetVolume()
    {
      return Length * Height * Width;
    }

    public double GetPrice()
    {
      int volume = this.GetVolume();
      if (volume <= 100)
      {
        return volume * 0.2 + this.Weight;
      }
      else if (volume <= 10000)
      {
        return volume * 0.005 + this.Weight * 0.5;
      }
      else if (volume <= 100000)
      {
        return volume * 0.002 + this.Weight * 0.3;   
      }
      else 
      {
        return 0;
      }   
    }
  }
}