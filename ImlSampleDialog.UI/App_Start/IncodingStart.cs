using System;

[assembly: WebActivator.PreApplicationStartMethod(
    typeof(ImlSampleDialog.UI.App_Start.IncodingStart), "PreStart")]

namespace ImlSampleDialog.UI.App_Start {
    
    using ImlSampleDialog.UI.Controllers;

    public static class IncodingStart {
        public static void PreStart() {
            Bootstrapper.Start();
            new DispatcherController(); // init routes
        }
    }
}