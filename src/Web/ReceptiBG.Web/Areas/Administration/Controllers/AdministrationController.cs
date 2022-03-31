namespace ReceptiBG.Web.Areas.Administration.Controllers
{
    using ReceptiBG.Common;
    using ReceptiBG.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
