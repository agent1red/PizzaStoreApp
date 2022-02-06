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
        [Display(Name = "Bake Style")]
        public int BakeStyleId { get; set; }
        public virtual BakeStyle BakeStyle { get; set; }
        [Display(Name = "Crust")]
        public int CrustId { get; set; }
        public virtual Crust Crust { get; set; }
        [Display(Name = "Cut Style")]
        public int CutStyleId { get; set; }
        public virtual CutStyle CutStyle { get; set; }
        [Display(Name = "Left Side")]
        public int LeftPizzaSideId { get; set; }
        public virtual PizzaSide? LeftPizzaSide { get; set; }
        [Display(Name = "Right Side")]
        public int RightPizzaSideId { get; set; }
        public virtual PizzaSide? RightPizzaSide { get; set; }

        [Display(Name ="Size")]
        public int PizzaSizeId { get; set; }
        public virtual PizzaSize PizzaSize { get; set; }
        [Display(Name = "Sauce")]
        public int? SauceId { get; set; }
        public virtual Sauce Sauce { get; set; }

    }
}
