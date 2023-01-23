using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection.Metadata;

namespace WebApplication5.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string BannerHeader { get; set; }
        public string Title { get; set; }
        public string RedirectUrl { get; set; }
        public string Images { get; set; }
        [NotMapped]
        public IFormFile ImagesFile { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ButtonredirectText { get; set; }
        public string ButtonRedirectUrl { get; set; }

    }
}
