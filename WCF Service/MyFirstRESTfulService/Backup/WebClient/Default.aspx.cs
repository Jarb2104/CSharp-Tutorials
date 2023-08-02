using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Runtime.Serialization;

namespace WebClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //var request = (HttpWebRequest)WebRequest.Create("http://localhost:8090/MyService/EmployeeService/Employee");
            //request.Method = "GET";
            //request.ContentType = "application/json";
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Response.Write(response.GetResponseStream() );
        }

        public void PutObject(string postUrl, object payload)
        {
            //var request = (HttpWebRequest)WebRequest.Create(postUrl);
            //request.Method = "PUT";
            //request.ContentType = "application/xml";
            //if (payload != null)
            //{
            //    request.ContentLength = Size(payload);
            //    Stream dataStream = request.GetRequestStream();
            //    Serialize(dataStream, payload);
            //    dataStream.Close();
            //}

            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //string returnString = response.StatusCode.ToString();
        }

        public void Serialize(Stream output, object input)
        {
            var ser = new DataContractSerializer(input.GetType());
            ser.WriteObject(output, input);
        }

      

    }
}
