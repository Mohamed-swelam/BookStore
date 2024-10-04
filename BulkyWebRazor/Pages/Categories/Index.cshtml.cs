namespace BulkyWebRazor.Pages.Categories;

public class IndexModel : PageModel
{
    private readonly ApplicationContext context;
    public List<Category> categories {  get; set; }

    public IndexModel(ApplicationContext context)
    {
        this.context = context;
    }

    public void OnGet()
    {
        categories = context.Categories.ToList();
    }
}
