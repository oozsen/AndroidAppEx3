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
using Newtonsoft.Json;

namespace AndroidAppEx3
{
    public static class Helper
    {
        static public string ToJson(this object item)
        {
            var value = JsonConvert.SerializeObject(item);
            return value;
        }

        static public T FromJson<T>(string item)
        {
            return JsonConvert.DeserializeObject<T>(item);
        }
    }
}