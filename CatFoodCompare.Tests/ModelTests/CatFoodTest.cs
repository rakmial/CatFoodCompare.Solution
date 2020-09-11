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
    static string testName = "Chicken & Salmon Rustic Blend";
    static string testBrand = "Open Farm";
    static double testPrice = 2.19;
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

    [TestMethod]
    public void Initialize_ReaderProperties_PropertyValues()
    {
      Assert.AreEqual(testName, testFood.Name);
      Assert.AreEqual(testBrand, testFood.Brand);
      Assert.AreEqual(testPrice, testFood.Price);
      Assert.AreEqual(testKCalKG, testFood.KCalKG);
      Assert.AreEqual(testUnitMassG, testFood.UnitMassG);
      Assert.AreEqual(testIngredients, testFood.Ingredients);
      Assert.AreEqual(testGuaranteedAnalysis, testFood.GuaranteedAnalysis);
    }
    // [TestMethod]
    // public void MethodTested_Behavior_ExpectedResult()
    // {
    //   // Test Assert.AreEqual(ExpectedResult, method to elicit ExpectedResult)
    // }

  }
}