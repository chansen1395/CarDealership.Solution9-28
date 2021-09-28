using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _cars = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        _cars.Add(this);

    }

    public static Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    public static Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    public static Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    public static Car amc = new Car("1976 AMC Pacer", 400, 198000);

    public static List<Car> GetAll()
    {
      return _cars;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }
}