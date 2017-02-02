using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XLabs.Forms;
//using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Mvvm;
using MediaPicker.Forms.Plugin.Abstractions;
using XLabs.Ioc;
using XLabs.Platform.Services.Media;

namespace MyTICs.Droid
{
    [Activity(Label = "My TICs", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity :
        //XFormsAppCompatDroid
    //XFormsApplicationDroid
    //XFormsCompatAppDroid : XFormsApp<XFormsCompatApplicationDroid>
    //XFormsApplicationDroid
    global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity

    {
        //bool _initialized = false;
        protected override void OnCreate(Bundle bundle)
        {
            
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);


            //if (!_initialized) SetIoc();
            //if (!Resolver.IsSet)
            //{
            //    this.SetIoc();
            //}
            //else
            //{
            //    //var app = Resolver.Resolve<IXFormsApp>() as IXFormsApp<XFormsApplicationDroid>;
            //    //if (app != null) app.AppContext = this;


            //}


            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        private void SetIoc()
        {
            var resolverContainer = new SimpleContainer();
            


            var app = new XFormsAppDroid();

           // app.Init(this);

            resolverContainer.Register<IDevice>(t => AndroidDevice.CurrentDevice)
                .Register<IDisplay>(t => t.Resolve<IDevice>().Display)
                
                .Register<IDependencyContainer>(resolverContainer)
                .Register<IXFormsApp>(app);
                

            Resolver.SetResolver(resolverContainer.GetResolver());
            //_initialized = true;
            //resolverContainer.Register<IDevice>(t => AndroidDevice.CurrentDevice)

            //    .Register<IDisplay>(t => t.Resolve<IDevice>().Display)

            //    .Register<IXFormsApp>(app)

            //    .Register<IDependencyContainer>(t => resolverContainer);

            //Resolver.SetResolver(resolverContainer.GetResolver());

        }
    }
}

