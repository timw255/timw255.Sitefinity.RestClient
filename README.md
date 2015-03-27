# timw255.Sitefinity.RestClient
C# client for Sitefinity REST services.

## Example
```C#
using (SitefinityRestClient sf = new SitefinityRestClient("admin", "password", "http://sf805700.local"))
{
    PagesServiceWrapper pagesService = new PagesServiceWrapper(sf);

    WcfPage page = pagesService.GetPage(Guid.Parse("6f9a72aa-1028-6203-846b-ff000072997b"), "", false).Item;

    Console.WriteLine(page.Title);
}
```
