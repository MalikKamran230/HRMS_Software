using Domain.HR.Attendance;
using Domain.HR.EmployeeProfile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRMS.Pages.HR
{
    public class ShiftMasterCreateModel : PageModel
    {
        [BindProperty]
        public cls_Shift cls_Shift { get; set; } = default!;
        public void OnGet()
        {
        }
    }
}
