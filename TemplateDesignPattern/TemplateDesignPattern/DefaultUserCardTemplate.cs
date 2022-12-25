using System;
namespace WebApplication1.TemplateDesignPattern
{
	public class DefaultUserCardTemplate:UserCardTemplate
	{
        protected override string SetFooter()
        {
            return string.Empty;
        }
        protected override string SetImage()
        {
            //değişen image alanı
            return "<img class='car-img-top' src='/images/user.png' style='width:50px;height:50px;'>";
        }
    }
}

