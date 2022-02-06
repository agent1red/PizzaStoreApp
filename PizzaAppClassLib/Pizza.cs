using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAppClassLib
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="BakeStyle is Required")]
        [Display(Name = "Bake Style")]
        public int? BakeStyleId { get; set; }
        public virtual BakeStyle BakeStyle { get; set; }
        [Required]
        [Display(Name = "Crust")]
        public int? CrustId { get; set; }
        public virtual Crust Crust { get; set; }
        [Required]
        [Display(Name = "Cut Style")]
        public int? CutStyleId { get; set; }
        public virtual CutStyle CutStyle { get; set; }
        [Required]
        [Display(Name = "Left Side")]
        public int? LeftPizzaSideId { get; set; }
        public virtual PizzaSide LeftPizzaSide { get; set; }
        [Required]
        [Display(Name = "Right Side")]
        public int? RightPizzaSideId { get; set; }
        public virtual PizzaSide RightPizzaSide { get; set; }
        [Required]
        [Display(Name ="Size")]
        public int? PizzaSizeId { get; set; }
        public virtual PizzaSize PizzaSize { get; set; }
        [Required]
        [Display(Name = "Sauce")]
        public int? SauceId { get; set; }
        public virtual Sauce Sauce { get; set; }

    }
}
