using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationContext context;
        public Category? category { get; set; }
        public DeleteModel(ApplicationContext context)
        {
            this.context = context;
        }
        public void OnGet(int Id)
        {
            category = context.Categories.Find(Id);
            
        }
        public IActionResult OnPost()
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
