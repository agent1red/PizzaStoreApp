


using System.ComponentModel.DataAnnotations;

namespace PizzaAppClassLib
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "The Price must Greater than 0 and less than 5")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Ingredient Type Required")]
        public int IngredientTypeId { get; set; }
        public virtual IngredientType IngredientType { get; set; }
    }
}