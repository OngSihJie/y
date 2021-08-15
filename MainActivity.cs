using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.IO;

namespace w2d5_Friday_Activity_City
{
    [Activity(Label ="Auckland Activity")]
    public class AucklandActivity : Activity
    {
        ImageView imgCity;
        WebView web_view;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Auckland);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            imgCity = FindViewById<ImageView>(Resource.Id.imgCity);

            imgCity.SetImageResource(Resource.Drawable.Auckland);
            web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.SetWebViewClient(new HelloWebViewClient());
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("https://www.newzealand.com/nz/auckland/");


        }
        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }
        }
    }
    [Activity(Label = "Wellington Activity")]
    public class WellingtonActivity : Activity
    {
        ImageView imgCity;
        WebView web_view;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Wellington);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            imgCity = FindViewById<ImageView>(Resource.Id.imgCity);

            imgCity.SetImageResource(Resource.Drawable.Wellington);
            web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.SetWebViewClient(new HelloWebViewClient());
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("https://www.wellingtonnz.com/");


        }
        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }
        }
    }
    [Activity(Label = "Hamilton Activity")]
    public class HamiltonActivity : Activity
    {
        ImageView imgCity;
        WebView web_view;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Hamilton);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            imgCity = FindViewById<ImageView>(Resource.Id.imgCity);

            imgCity.SetImageResource(Resource.Drawable.Hamilton);
            web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.SetWebViewClient(new HelloWebViewClient());
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("https://www.newzealand.com/nz/hamilton/");


        }
        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }
        }
    
    }
    [Activity(Label = "Christchurch Activity")]
    public class ChristchurchActivity : Activity
    {
    ImageView imgCity;
    WebView web_view;
    protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Christchurch);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            imgCity = FindViewById<ImageView>(Resource.Id.imgCity);

            imgCity.SetImageResource(Resource.Drawable.Christchurch);
            web_view = FindViewById<WebView>(Resource.Id.webView1);
            web_view.SetWebViewClient(new HelloWebViewClient());
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("https://www.newzealand.com/nz/christchurch/");


        }
        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }
        }
    }
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : TabActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);
            TabHost.TabSpec tabSpec;
            Intent intent;

            intent = new Intent(this, typeof(AucklandActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Auckland");
            tabSpec.SetIndicator("Auckland");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);

            intent = new Intent(this, typeof(WellingtonActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Wellington");
            tabSpec.SetIndicator("Wellington");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);

            intent = new Intent(this, typeof(HamiltonActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Hamilton");
            tabSpec.SetIndicator("Hamilton");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);

            intent = new Intent(this, typeof(ChristchurchActivity));
            intent.AddFlags(ActivityFlags.NewTask);
            tabSpec = TabHost.NewTabSpec("Christchurch");
            tabSpec.SetIndicator("Christchurch");
            tabSpec.SetContent(intent);
            TabHost.AddTab(tabSpec);


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
//[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
//public class MainActivity : TabActivity
//{

//    protected override void OnCreate(Bundle savedInstanceState)
//    {
//        base.OnCreate(savedInstanceState);
//        //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
//        // Set our view from the "main" layout resource
//        //SetContentView(Resource.Layout.activity_main);
//        TabHost.TabSpec tabSpec;
//        Intent intent;

//        intent = new Intent(this, typeof(AucklandActivity));
//        intent.AddFlags(ActivityFlags.NewTask);
//        tabSpec = TabHost.NewTabSpec("Auckland");
//        tabSpec.SetIndicator("Auckland");
//        tabSpec.SetContent(intent);
//        TabHost.AddTab(tabSpec);
//    }
//    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
//    {
//        Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

//        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
//    }