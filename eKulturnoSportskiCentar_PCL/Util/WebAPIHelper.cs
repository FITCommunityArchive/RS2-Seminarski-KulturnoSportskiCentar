using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eKulturnoSportskiCentar_PCL.Util
{
   public class WebAPIHelper
    {
        public HttpClient client { get; set; }
        public string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        #region GET

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }

        public HttpResponseMessage GetResponse(string parametar = "")
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }

        public HttpResponseMessage GetResponse(string parametar = "", string parametar2 = "")
        {
            return client.GetAsync(route + "/" + parametar + "/" + parametar2).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parametar = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }

        #endregion


        #region Post

        public HttpResponseMessage PostResponse(Object obj)
        {
           // return client.PostAsJsonAsync(route, obj).Result;
           var jsonObject=new StringContent(JsonConvert.SerializeObject(obj),Encoding.UTF8,"application/json");
           return client.PostAsync(route, jsonObject).Result;
        }

       public HttpResponseMessage PostActionResponse(string action, Object obj)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            return client.PostAsync(route + "/" + action, jsonObject).Result;
        }

        #endregion

        #region Put

        public HttpResponseMessage PutResponse(int id, Object obj)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
           return  client.PutAsync(route + "/" + id, jsonObject).Result;
           }
        //public HttpResponseMessage PutResponse(int id, Object obj)
        //{
        //    return client.PutAsJsonAsync(route + "/" + id, obj).Result;
        //}

        #endregion

        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }

        public HttpResponseMessage DeleteResponse(string parametar = "", string parametar2 = "")
        {
            return client.DeleteAsync(route + "/" + parametar + "/" + parametar2).Result;
        }

    }
}