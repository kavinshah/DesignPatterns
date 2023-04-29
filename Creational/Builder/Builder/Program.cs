// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Builder;

MealBuilder stegosaurusMealBuilder = new StegosaurusMealBuilder();
Meal meal = stegosaurusMealBuilder.BuildMeal();
meal.ServeMeal();
