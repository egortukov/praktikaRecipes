namespace praktikaRecipes;

class Program
{
    static void Main(string[] args)
    {
    }
}

public class Ingredients
{
    public string NameOfInridient { get; set; }
}

public class Recipes
{
    public string NameOfRecipe { get; set; }
    public string Description { get; set; }
    public List<Ingredients> IngredientsList { get; set; }
    public string CookingOrder { get; set; }
    public Users Chef { get; set; }
    public Dish TypeOfDish { get; set; }
    public int Rating { get; set; }
}

public enum Dish
{
    Dessert,
    Pervoe,
    Vtoroe,
    Soup
}

public class Users
{
    public string Name { get; set; }
    public string NameOfDish { get; set; }
    public DateTime Date { get; set; }
    public List<Recipes> Recipes { get; set; }
    public int Rating { get; set; }
}