using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidAppEx3
{
    [Activity(Label = "CalculateActivity")]
    public class CalculateActivity : Activity
    {
        TextView txtResult;
        Button btnDone;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Calculate);

            txtResult = FindViewById<TextView>(Resource.Id.txtResult);
            btnDone = FindViewById<Button>(Resource.Id.btnDone);
            
            Intent myIntent = new Intent();
            int val1 = int.Parse(Intent.GetStringExtra("val1"));
            int val2 = int.Parse(Intent.GetStringExtra("val2"));

            int vresult = val1 + val2;
            txtResult.Text = "Result is " + vresult;
            myIntent.PutExtra("vresult", vresult);
            SetResult(Result.Ok, myIntent);

            btnDone.Click += BtnDone_Click;            
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}