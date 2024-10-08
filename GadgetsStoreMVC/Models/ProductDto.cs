using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GadgetsStoreMVC.Models
{
	public class ProductDto
	{
		[Required,MaxLength(100)]
		public string Name { get; set; } = "";
		[Required, MaxLength(100)]
		public string Brand { get; set; } = "";
		[Required, MaxLength(100)]
		public string Category { get; set; } = "";
		[Required]
		public decimal Price { get; set; }
		[Required]
		public string Description { get; set; } = "";

		public IFormFile? ImageFile { get; set; }
		//we need file name loc
		//public string ImageFileName { get; set; } = "";

		//we will use ProductDto to add and update products.
		//whenever we  add product imgfile is needed but on edit it's optional therefore we added ? 
	}
}
