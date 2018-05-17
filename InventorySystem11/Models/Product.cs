using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem11.Models
{

    public class Product
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You have to have a name")]

        [StringLength(10, MinimumLength= 2, ErrorMessage = "A name must be between 2 and 10 long")]

        public string Name { get; set; }

        [Range(1, 10001, ErrorMessage = "Price must be between 1 and 10000")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please , specify the category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Shelf is required")]
        public string Shelf { get; set; }

        [Range(0, 1000000)]
        public int Count { get; set; }

        [Required(ErrorMessage ="Please, specify the description of the product")]
        public string Description { get; set; }
    //    public IEnumerable<SelectListItem> States { get; internal set; }
    //}
}