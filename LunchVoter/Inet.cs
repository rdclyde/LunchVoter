using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LunchVoter
{
    public class Inet
    {
        private static String mClassName = "Inet";
        private static String mReqUrl = "https://interview-project-17987.herokuapp.com/api/";
        //private static HttpClient client;

        public static String BallotCreate(String jsonPost)
        {
            String retVal = "";
            //try
            //{
                var httpReq = (HttpWebRequest)WebRequest.Create(mReqUrl + "create-ballot");
                httpReq.ContentType = "application/json";
                httpReq.Method = "POST";
                using (var sw = new StreamWriter(httpReq.GetRequestStream()))
                {
                    sw.Write(jsonPost);
                    sw.Flush();
                    sw.Close();
                }
                var resp = (HttpWebResponse)httpReq.GetResponse();
                using (var sr = new StreamReader(resp.GetResponseStream()))
                {
                    retVal = sr.ReadToEnd();
                }
            /*}
            catch (Exception ex)
            {
                Common.LogSave(mClassName + ".BallotCreate", ex.Message);
            }
            finally
            {
            }*/
            return retVal;
        }

        public static String RestaurantsBallotGet(String ballotId)
        {
            var httpReq = (HttpWebRequest)WebRequest.Create(mReqUrl + "ballot/{" + ballotId + "}");
            httpReq.ContentType = "application/json";
            httpReq.Method = "GET";
            var resp = (HttpWebResponse)httpReq.GetResponse();
            using (var sr = new StreamReader(resp.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }

        public static String RestaurantsAllGet()
        {
            var httpReq = (HttpWebRequest)WebRequest.Create(mReqUrl + "restaurants");
            httpReq.ContentType = "application/json";
            httpReq.Method = "GET";
            var resp = (HttpWebResponse)httpReq.GetResponse();
            using (var sr = new StreamReader(resp.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }






    }
}