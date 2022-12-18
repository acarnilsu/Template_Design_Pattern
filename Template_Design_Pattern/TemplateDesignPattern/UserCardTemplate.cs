using System.Text;
using Template_Design_Pattern.DAL.Entities;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public abstract class UserCardTemplate
    {
        protected AppUser AppUser { get; set; }  // protected --> kullandığım classlar da(referans aldıklarım) bunu görüyor olacak

        public void SetUser(AppUser appUser)
        {
            AppUser = appUser;
        }


        public string Build()
        {
            var sb = new StringBuilder();       //String builder --> Metinsel ifadeleri birleştirmek
            sb.Append("<div class='card'>");
            sb.Append(SetImage());
            sb.Append($@"<div class='card-body'>
                        <h4>{AppUser.UserName}</h4>
                        <p>{AppUser.Description}</p>");
            sb.Append(SetFooter());
            sb.Append("</div>");
            sb.Append("</div>");
            return sb.ToString();
        }

        protected abstract string SetImage();
        protected abstract string SetFooter();  
    }
}
