using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Runtime;

namespace AndroidAppEx3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAdd;
        EditText txtVal1;
        EditText txtVal2;
        TextView txtSum;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            txtVal1 = FindViewById<EditText>(Resource.Id.txtVal1);
            txtVal2 = FindViewById<EditText>(Resource.Id.txtVal2);
            txtSum = FindViewById<TextView>(Resource.Id.txtSum);

            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            //Toast.MakeText(this, txtVal1.Text + " + " + txtVal2.Text, ToastLength.Short).Show();
            txtSum.Text = "Calculating...";

            var intent = new Intent(this, typeof(CalculateActivity));
            intent.PutExtra("val1", txtVal1.Text);
            intent.PutExtra("val2", txtVal2.Text);
            StartActivityForResult(intent, 493);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            if (resultCode == Result.Ok && requestCode == 493) {                
                int result = data.GetIntExtra("vresult", -1);
                txtSum.Text = " Sum is " + result;
            }
        }
    }
}

