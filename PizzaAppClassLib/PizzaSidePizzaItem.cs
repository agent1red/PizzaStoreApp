using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PizzaAppClassLib
{
    [Keyless]
    public class PizzaSidePizzaItem
    {
    
        public PizzaSide PizzaSide { get; set; }
        public PizzaItem PizzaItems { get; set; }
    }
}