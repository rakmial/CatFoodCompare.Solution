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

    private static List<CatFood> _instances = new List<CatFood> {};

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
        _instances.Add(this);
    }

    public static string ComparePrice()
    {
      string formattedCompare = "";
      foreach(CatFood catFood in _instances)
      {
        formattedCompare += String.Format("{0} {1}: {2:0} calories/$\n", 
          catFood.Brand, catFood.Name, catFood.KCalPrice);
      }
      return formattedCompare;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    private float calculateProteinFatRatio(int proteinValue, int fatValue)
    {
      return Convert.ToSingle(proteinValue) / fatValue;
    }

    private float calculateKCalPriceRatio(float price, int unitMassG, int kCalKG)
    {
      return kCalKG * unitMassG / 1000 / price;
    }
  }
}