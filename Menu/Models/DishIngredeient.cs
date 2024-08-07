namespace Menu.Models
{
    public class DishIngredeient
    {
        public int Id { get; set; }
        public Dish Dish { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
