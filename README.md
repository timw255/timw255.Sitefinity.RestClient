# timw255.Sitefinity.RestClient
C# client for Sitefinity REST services.

## Examples

Here's how to pull back information about a specific page

```C#
using (SitefinityRestClient sf = new SitefinityRestClient("admin", "password", "http://sf805700.local"))
{
    PagesServiceWrapper pagesService = new PagesServiceWrapper(sf);

    WcfPage page = pagesService.GetPage(Guid.Parse("6f9a72aa-1028-6203-846b-ff000072997b"), "", false).Item;

    Console.WriteLine(page.Title);
}
```

Here's how to create a new Image item and upload the associated data

```C#
using (SitefinityRestClient sf = new SitefinityRestClient("admin", "password", "http://sf805700.local/"))
{
    AlbumServiceWrapper albumService = new AlbumServiceWrapper(sf);

    var album = albumService.GetContentItems("", 0, 1, "", "", "").Items.First();

    ImageServiceWrapper imageService = new ImageServiceWrapper(sf);

    Image newImage = new Image();

    string newItemTitle = "Sitefinity Logo";

    newImage.Title = newItemTitle;
    newImage.UrlName = Regex.Replace(newItemTitle.ToLower(), @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-");
    newImage.AlternativeText = "";
    newImage.ApprovalWorkflowState = "";
    newImage.ThumbnailNames = new string[] { };
    newImage.Author = "";
    newImage.ItemDefaultUrl = "";
    newImage.Extension = "";
    newImage.DefaultPageId = null;
    newImage.MediaUrl = "";
    newImage.ThumbnailUrl = "";
    newImage.DateCreated = DateTime.UtcNow;
    newImage.PublicationDate = DateTime.UtcNow;

    ContentItemContext<Image> content = new ContentItemContext<Image>();
    content.Item = newImage;

    var response = imageService.SaveChildContent(content, album.Id, Guid.Empty, album.ProviderName, album.Id, "", true, false, "");
    var image = response.Item;

    Html5UploadHandlerWrapper uploader = new Html5UploadHandlerWrapper(sf);

    using (var webClient = new WebClient())
    {
        string imageUrl = "http://www.codemoar.com/images/default-source/demo/sitefinity-logo.png";
        byte[] imageBytes = webClient.DownloadData(imageUrl);

        var r = uploader.UploadContent(image.Album.Id, image.Id, imageBytes, "sitefinity-logo.png", response.ItemType, "");

        Console.WriteLine("Result: " + r.UploadResult);
    }
}
```