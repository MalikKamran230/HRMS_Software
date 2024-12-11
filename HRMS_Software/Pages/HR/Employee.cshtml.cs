using Domain.HR.EmployeeProfile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRMS.Pages.HR
{
    public class EmployeeModel : PageModel
    {
		[BindProperty]
		public cls_Employee cls_Employee { get; set; } = default!;
		public void OnGet()
        {

		}
	}
}
