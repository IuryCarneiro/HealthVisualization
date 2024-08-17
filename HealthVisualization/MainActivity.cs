using Android.Content;
using HealthVisualization.Activities;
using HealthVisualization.BaseClasses;

namespace HealthVisualization
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : Activity
    {
        static public Usuario _usuario = null;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
        }

        private void DefineActivityExibicao()
        {
            if (_usuario == null)
            {
                Intent intent = new Intent(this, typeof(LoginActivity));
                StartActivity(intent);
            }
            else
            {
                Intent intent = new Intent(this, typeof(LocalizacaoActivity));
                StartActivity(intent);
            }
        }

        protected override void OnResume()
        {
            base.OnResume();
            DefineActivityExibicao();
        }

    }
}