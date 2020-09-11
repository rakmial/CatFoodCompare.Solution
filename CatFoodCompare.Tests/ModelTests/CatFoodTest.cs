using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatFoodCompare.Models;
using System;
using System.Collections.Generic;

namespace CatFoodCompare.Tests
{
  [TestClass]
  public class CatFoodTests // : IDisposable
  {
    //public void Dispose()
    //{
    //  CatFood.ClearAll();
    //}
    // Test Food Object 1
    static string testName = "Chicken & Salmon Rustic Blend";
    static string testBrand = "Open Farm";
    static float testPrice = 2.19F;
    static int testKCalKG = 900;
    static int testUnitMassG = 156;

    static List<string> testIngredients = new List<string> {
      "Chicken", "Chicken Bone Broth", "Salmon", "Pumpkin", "Carrots", 
      "Spinach", "Red Lentils", "Agar Agar", "Cranberries", "Chickpeas", 
      "Chicory Root", "Sunflower Oil", "Coconut Oil", "Salt"
      };

    static Dictionary<string, int> testGuaranteedAnalysis = new Dictionary<string, int> {
      {"Crude Protein", 8}, {"Crude Fat", 6}, {"Crude Fiber", 2}, {"Moisture", 82}};

    CatFood testFood = new CatFood(testName, testBrand, testPrice, testKCalKG,
      testUnitMassG, testIngredients, testGuaranteedAnalysis);

    // Test Food Object 2
    static string testName2 = "Chicken & Tuna Dinner";
    static string testBrand2 = "Friskies";
    static float testPrice2 = 0.85F;
    static int testKCalKG2 = 1244;
    static int testUnitMassG2 = 156;

    static List<string> testIngredients2 = new List<string> {
      "Meat By-products", "Poultry By-products", "Water", "Chicken", "Liver", "Tuna", "Rice", 
      "Artificial and Natural Flavors", "Added Color", "Guar Gum"
      };

    static Dictionary<string, int> testGuaranteedAnalysis2 = new Dictionary<string, int> {
      {"Crude Protein", 10}, {"Crude Fat", 5}, {"Crude Fiber", 1}, {"Moisture", 78}};

    CatFood testFood2 = new CatFood(testName2, testBrand2, testPrice2, testKCalKG2,
      testUnitMassG2, testIngredients2, testGuaranteedAnalysis2);


    [TestMethod]
    public void CatFoodConstructor_CreatesInstanceOfCatFood_CatFood()
    {
      Assert.AreEqual(typeof(CatFood), testFood.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnsValues_PropertyValues()
    {
      Assert.AreEqual(testName, testFood.Name);
      Assert.AreEqual(testBrand, testFood.Brand);
      Assert.AreEqual(testPrice, testFood.Price);
      Assert.AreEqual(testKCalKG, testFood.KCalKG);
      Assert.AreEqual(testUnitMassG, testFood.UnitMassG);
      Assert.AreEqual(testIngredients, testFood.Ingredients);
      Assert.AreEqual(testGuaranteedAnalysis, testFood.GuaranteedAnalysis);
    }
    [TestMethod]
    public void ProteinFatRatio_ReturnsProteinToFatRatio_Float()
    {
      float testProteinFloatValue = Convert.ToSingle(testGuaranteedAnalysis["Crude Protein"]);
      int testFat = testGuaranteedAnalysis["Crude Fat"];
      float testRatio = testProteinFloatValue / testFat;
      Assert.AreEqual(testRatio, testFood.ProteinFatRatio);
    }
    [TestMethod]
    public void KCalPrice_ReturnsKCalToPriceRatio_Float()
    {
      float testKCalToPrice = testKCalKG * (testUnitMassG / 1000) / testPrice;
      Assert.AreEqual(testKCalToPrice, testFood.KCalPrice);
    }
    [TestMethod]
    public void ComparePrice_ReturnsFormattedStringOfBrandNameAndKCalPrice_String()
    {
      List<CatFood> CatFoodList = new List<CatFood> {testFood, testFood2};
      string testFormattedCompare = "";
      foreach (CatFood food in CatFoodList)
      {
        testFormattedCompare += String.Format("{0} {1}: {0:C2}", food.Brand, food.Name, food.KCalPrice);
      }
      Assert.AreEqual(testFormattedCompare, CatFood.ComparePrice());
    }
    // [TestMethod]
    // public void MethodTested_Behavior_ExpectedResult()
    // {
    //   // Test Assert.AreEqual(ExpectedResult, method to elicit ExpectedResult)
    // }

  }
}