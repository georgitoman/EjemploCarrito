using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploCarrito.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, String key, object value)
        {
            String data = JsonConvert.SerializeObject(value);
            session.SetString(key, data);
        }

        public static T GetObject<T>(this ISession session, String key)
        {
            String data = session.GetString(key);
            if (data == null)
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
