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
        [Display(Name = "Bake Syle")]
        public BakeStyle BakeStyle { get; set; }
        [Display(Name = "Crust")]
        public Crust Crust { get; set; }
        [Display(Name = "Crust Style")]
        public CutStyle CutStyle { get; set; }
        public PizzaSide? LeftPizzaSide { get; set; }
        public PizzaSide? RightPizzaSide { get; set; }

        [Display(Name ="Size")]
        public PizzaSize PizzaSize { get; set; }
        public Sauce Sauce { get; set; }

    }
}
