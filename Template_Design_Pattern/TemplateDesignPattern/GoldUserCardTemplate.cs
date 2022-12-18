using System.Text;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class GoldUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#' style='float:left; margin-left:5px;' class='btn btn-sm  btn-warning'>Profili Gör</a>");
            sb.Append("<a href='#' style='float:left; margin-left:5px;' class='btn btn-sm ms-2 btn-danger'>Mesaj Gönder</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src='{AppUser.Image}' style='width:150px; height:150px;'>";
        }
    }
}
