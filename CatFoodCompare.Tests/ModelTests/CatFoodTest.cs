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
      float testScaleUnitMassGtoKG = 1000/Convert.ToSingle(testUnitMassG);
      float testKCalToPrice = testKCalKG/testScaleUnitMassGtoKG*testPrice;
      Assert.AreEqual(testKCalToPrice, testFood.KCalPrice);
    }
    // [TestMethod]
    // public void MethodTested_Behavior_ExpectedResult()
    // {
    //   // Test Assert.AreEqual(ExpectedResult, method to elicit ExpectedResult)
    // }

  }
}