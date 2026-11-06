using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyValidaterLib.Model;
using MyValidaterLib.Repo;

namespace WebApplication1.Pages
{
	public class IndexModel : PageModel
	{
	[BindProperty]
	public string FirstName { get; set; }
	public string SirName { get; set; }
	public string Street { get; set; }
	public int Number { get; set; }
	public int ZipCode { get; set; }
	public string City { get; set; }
	public int Phone { get; set; }
	public string Email { get; set; }




	public void OnGet()
		{

		}
	public void OnPostValidate()
		{
			Validator validate = new Validator();
			if (!validate.ValidateFirstName(FirstName))
			{
				ModelState.AddModelError(nameof(FirstName), "Name do not accept numbers");
			}
		
		}

	}
}
