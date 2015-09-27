namespace ImlSampleDialog.UI.Controllers
{        
    using Incoding.MvcContrib.MVD;    
	
    public class DispatcherController : DispatcherControllerBase
    {
        public DispatcherController()
                : base(typeof(Bootstrapper).Assembly) { }
    }
}