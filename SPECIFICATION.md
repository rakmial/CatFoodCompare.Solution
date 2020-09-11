# English Specification

CatFood - an object model for comparison of different cat foods.

### _Tests & Functions_

1. CatFood initializes with string values [name, brand], double unitPrice, int [kCalKG, unitMassG], List<string> Ingredients, Dictionary<string, int> GuaranteedAnalysis associating protein, fat, fiber, and moisture to their percentages,  provides reader fields for each. 
2. ProteinFatRatio is calculated and reader provided as well.
3. KCalPrice is calculated, which returns KCal per dollar price.
4. CatFood provides public class method ComparePrice(sortOrder), which calls KCal$ on its constituent instances to create a Dictionary<string, float> associating {brand, name, KCalPrice} and sorting by alpha, price asc, or price desc. 
5. CatFood generates a private variable Dictionary<string, List<string>> _ingredientXRef that contains each ingredient from each CatFood as keys, with each CatFood containing that ingredient contained in a List<string> value.
6. CatFood provides public class method MostLike(catFood) that returns a descending order list of CatFoods that share the most ingredients with the input CatFood object.

### _Specs for Specs_
1. Plain English specs were committed in a text file or README before coding.
2. Specs include specific input and output values and a descriptive sentence.
3. Specs begin with the simplest possible behavior and progress to more complex cases, covering different input values.
4. All specs are translated correctly as test methods.
All tests are passing, and described functionality is present.