using System;
using System.Collections.Generic;

namespace CatFoodCompare.Models
{
  public class CatFood
  {
    public string Name { get; }
    public string Brand { get; }
    public float Price { get; }
    public int KCalKG { get; }
    public int UnitMassG { get; }
    public List<string> Ingredients { get; }
    public Dictionary<string, int> GuaranteedAnalysis { get; }
    public float ProteinFatRatio { get; }
    public float KCalPrice { get; }

    public CatFood(string name, string brand, float price, int kCalKG, int unitMassG, 
      List<string> ingredients, Dictionary<string, int> guaranteedAnalysis)
    {
        Name = name;
        Brand = brand;
        Price = price;
        KCalKG = kCalKG;
        UnitMassG = unitMassG;
        Ingredients = ingredients;
        GuaranteedAnalysis = guaranteedAnalysis;
        ProteinFatRatio = calculateProteinFatRatio(GuaranteedAnalysis["Crude Protein"], 
          GuaranteedAnalysis["Crude Fat"]);
        KCalPrice = calculateKCalPriceRatio(price, unitMassG, kCalKG);
    }

    private float calculateProteinFatRatio(int proteinValue, int fatValue)
    {
      return Convert.ToSingle(proteinValue) / fatValue;
    }

    private float calculateKCalPriceRatio(float price, int unitMassG, int kCalKG)
    {
      return kCalKG * (unitMassG / 1000) / price;
    }
  }
}