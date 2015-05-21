using Sdl.Web.Common.Models;
using Sdl.Web.Modules.Impress.Models;
using Sdl.Web.Mvc.Configuration;

namespace Sdl.Web.Modules.Impress
{
    public class ImpressAreaRegistration : BaseAreaRegistration
    {
        public override string AreaName
        {
            get { return "Impress"; }
        }

        protected override void RegisterAllViewModels()
        {
            RegisterViewModel("Presentation", typeof(Region), "Region");
            RegisterViewModel("Fallback", typeof(Region), "Region");
            RegisterViewModel("Hint", typeof(Region), "Region");
            RegisterViewModel("ImpressPage", typeof(WebPage), "Page");
            RegisterViewModel("Slide", typeof(Slide));
            RegisterViewModel("FreeText", typeof(Slide));
            RegisterViewModel("Overview", typeof(Slide));
            RegisterViewModel("Message", typeof(Message));
        }
    }
}
