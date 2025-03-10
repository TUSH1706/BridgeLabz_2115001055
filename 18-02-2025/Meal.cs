using System;
using System.Collections.Generic;
public interface IMealPlan
{
    string GetPlan();
}
public class VegetarianMeal : IMealPlan
{
    public string GetPlan()
    {
        return "Vegetarian Meal Plan: Includes fruits, vegetables, grains, and legumes.";
    }
}
public class VeganMeal : IMealPlan
{
    public string GetPlan()
    {
        return "Vegan Meal Plan: Excludes all animal products, including dairy and eggs.";
    }
}

public class KetoMeal : IMealPlan
{
    public string GetPlan()
    {
        return "Keto Meal Plan: High-fat, low-carb diet to promote ketosis.";
    }
}
public class HighProteinMeal : IMealPlan
{
    public string GetPlan()
    {
        return "High-Protein Meal Plan: Focuses on protein-rich foods like meat, eggs, and legumes.";
    }
}
public class Meal<T> where T : IMealPlan
{
    private T _mealPlan;

    public Meal(T mealPlan)
    {
        _mealPlan = mealPlan;
    }

    public void DisplayPlan()
    {
        Console.WriteLine(_mealPlan.GetPlan());
    }
}
public class MealPlanGenerator
{
    public static void GenerateMealPlan<T>(T mealPlan) where T : IMealPlan
    {
        Console.WriteLine("Generating your personalized meal plan...");
        Console.WriteLine(mealPlan.GetPlan());
        Console.WriteLine("Meal plan generated successfully!\n");
    }
}
class Program
{
    static void Main(string[] args)
    {
        var vegetarianMeal = new VegetarianMeal();
        var veganMeal = new VeganMeal();
        var ketoMeal = new KetoMeal();
        var highProteinMeal = new HighProteinMeal();
        var meal1 = new Meal<VegetarianMeal>(vegetarianMeal);
        var meal2 = new Meal<VeganMeal>(veganMeal);
        var meal3 = new Meal<KetoMeal>(ketoMeal);
        var meal4 = new Meal<HighProteinMeal>(highProteinMeal);
        meal1.DisplayPlan();
        meal2.DisplayPlan();
        meal3.DisplayPlan();
        meal4.DisplayPlan();
        MealPlanGenerator.GenerateMealPlan(vegetarianMeal);
        MealPlanGenerator.GenerateMealPlan(veganMeal);
        MealPlanGenerator.GenerateMealPlan(ketoMeal);
        MealPlanGenerator.GenerateMealPlan(highProteinMeal);
    }
}