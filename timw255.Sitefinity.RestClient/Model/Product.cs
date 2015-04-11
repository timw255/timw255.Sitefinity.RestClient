using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Product : CustomizableFieldObject, IDynamicFieldsContainer, IContent
    {
        public string __type { get; set; }
        public Lstring ApprovalWorkflowState { get; set; }
        public Guid AssociateBuyerWithRole { get; set; }
        public string[] AvailableLanguages { get; set; }
        public int BestSelling { get; set; }
        public string ClrType { get; set; }
        public Lstring Description { get; set; }
        public decimal DisplayPrice { get; set; }
        public string DisplayPriceFormatted { get; set; }
        public string DisplayPriceWithVatAndSale { get; set; }
        public bool DisplayTaxInPrice { get; set; }
        public List<ProductFile> DocumentsAndFiles { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool Featured { get; set; }
        public List<ProductFile> Files { get; set; }
        public bool HasDownloadableFiles { get; set; }
        public Guid Id { get; set; }
        public List<ProductImage> Images { get; set; }
        public int Inventory { get; set; }
        public string InventoryDisplay { get; set; }
        public string InventoryJson { get; set; }
        [Obsolete("use Status column to get the life cycle status of the product instead")]
        public bool IsActive { get; set; }
        public bool IsOnSale { get; set; }
        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }
        public Guid OriginalContentId { get; set; }
        public Guid OriginalOwner { get; set; }
        public Guid Owner { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithVatAndSale { get; set; }
        public DateTime PublicationDate { get; set; }
        public IList<ProductRating> Ratings { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SaleStartDate { get; set; }
        public string Sku { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public Guid TaxClassId { get; set; }
        public ProductImage Thumbnail { get; set; }
        public IList<ProductPrice> TierPrices { get; set; }
        public virtual Lstring Title { get; set; }
        public ContentUIStatus UIStatus { get; set; }
        public Lstring UrlName { get; set; }
        public int Version { get; set; }
        public bool Visible { get; set; }
        public double? Weight { get; set; }

        public Product() { }
    }
}
