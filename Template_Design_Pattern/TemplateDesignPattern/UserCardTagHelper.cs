using Microsoft.AspNetCore.Razor.TagHelpers;
using Template_Design_Pattern.DAL.Entities;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class UserCardTagHelper:TagHelper
    {
        public AppUser AppUser { get; set; }
    }
}
