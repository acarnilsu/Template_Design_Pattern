using System.Text;
using Template_Design_Pattern.DAL.Entities;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class PrimeUserCardTemplate : UserCardTemplate
    {
        protected AppUser AppUser { get; set; }

        public void SetUser(AppUser appUser)
        {
            AppUser = appUser;
        }

        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#' class='btn btn-warning'>Profili Gör</a>");
            sb.Append("<a href='#' class='btn btn-danger'>Mesaj Gönder</a>");
            sb.Append("<a href='#' class='btn btn-success'>Bağış Yap</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src='{AppUser.Image}' style='width:80px; height:80px;'>";
        }
    }
}
