﻿namespace Menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price {  get; set; }
        public List<DishIngredeient>? DishIngredeient { get; set; }
    }
}
