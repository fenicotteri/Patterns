
namespace ProxyPattern;

class Page
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string Text { get; set; } = string.Empty;
}
class PageContext 
{
    public List<Page> Pages { get; set; } = new List<Page>();

    public PageContext()
    {
        Pages.Add(new Page()
        {
            Id = 1,
            Number = 1,
            Text = "Hi"
        });
        Pages.Add(new Page()
        {
            Id = 2,
            Number = 2,
            Text = "Buy"
        });
    }
}

interface IBook 
{
    Page? GetPage(int number);
}

class BookStore : IBook
{
    PageContext Context;
    public BookStore()
    {
        Context = new PageContext();
    }

    public Page GetPage(int number)
    {
        return Context.Pages.FirstOrDefault(p => p.Number == number);
    }
}

class BookStoreProxy : IBook
{
    List<Page> Pages;
    BookStore BookStore;
    public BookStoreProxy()
    {
        Pages = new List<Page>();
    }

    public Page? GetPage(int number)
    {
        Page page = Pages.FirstOrDefault(p => p.Number == number);

        if (page is null)
        {
            if (BookStore == null)
                BookStore = new BookStore();
            page = BookStore.GetPage(number);
            Pages.Add(page);
        }
        return page;
    }
}

