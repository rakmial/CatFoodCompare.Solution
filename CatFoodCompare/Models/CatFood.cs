using System.Collections.Generic;

namespace CatFoodCompare.Models
{
  public class CatFood
  {
    public string Name { get; }
    public string Brand { get; }
    public double Price { get; }
    public int KCalKG { get; }
    public int UnitMassG { get; }
    public List<string> Ingredients { get; }
    public Dictionary<string, int> GuaranteedAnalysis { get; }

    public CatFood(string name, string brand, double price, int kCalKG, int unitMassG, 
      List<string> ingredients, Dictionary<string, int> guaranteedAnalysis)
    {
        Name = name;
        Brand = brand;
        Price = price;
        KCalKG = kCalKG;
        UnitMassG = unitMassG;
        Ingredients = ingredients;
        GuaranteedAnalysis = guaranteedAnalysis;
    }
  }
}