namespace BulkyWebRazor.Pages.Categories;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly ApplicationContext context;
    public Category category {  get; set; }
    public CreateModel(ApplicationContext context)
    {
        this.context = context;
    }
    public void OnGet()
    {
    }
    public IActionResult OnPost()
    {
        context.Categories.Add(category);
        context.SaveChanges();
        return RedirectToPage("Index");
    }
}
