using System.ComponentModel.DataAnnotations;

namespace PizzaAppClassLib
{
    public class IngredientType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}