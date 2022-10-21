using System.ComponentModel.DataAnnotations;
using System;

namespace RecipeBox.ViewModels
{
	public class RegisterViewModel
	{
		[Required]
		[Display(Name = "Username")]
		public string UserName {get; set;}
    
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email {get; set;}

		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Full Name")]
		public string FullName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password {get; set;}

		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword {get; set;}
	}
}