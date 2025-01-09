namespace praktikaRecipes;

class Program
{
    static void Main(string[] args)
    {
    }
}

class Ingredients
{
    public static List<Ingredients> AvailableIngredients { get; set; } = new List<Ingredients>();
}

class Recipes
{
    public string NameOfRecipe { get; set; }
    public string Description { get; set; }
    public List<Ingredients> IngredientsList { get; set; } = new List<Ingredients>();
    public string CookingOrder { get; set; }
    public Users Chef { get; set; }
    public Dish TypeOfDish { get; set; }
    public int Rating { get; set; }
}

class Dish
{
    public string NameOfDish { get; set; }
    public DateTime Date { get; set; }
    public List<Recipes> Recipes { get; set; }
    public int Rating { get; set; }
}

class Users
{
    public string Name { get; set; }
}