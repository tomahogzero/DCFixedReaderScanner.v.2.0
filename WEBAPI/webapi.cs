using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using webAPI.Models;
using System.Collections.Specialized;

namespace webAPI
{
    public class WebAPI
    {
        public static model_Res_Login Login(string url, string username, string password, ref CookieCollection Cookies, ref string message)
        {
            model_Res_Login lg = new model_Res_Login();
            message = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/auth/token");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                //httpWebRequest.UserAgent = "Koala Admin";

              
                httpWebRequest.CookieContainer = new CookieContainer();

                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        userName = username,
                        password = password,
                        grantType = "password",
                        audience = "TescoLotus.SupplyLine.ApplicationApi"
                    });
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    Cookies = httpResponse.Cookies;

                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<model_Res_Login>(result);

                    if (lg.access_token != null)
                    {
                        return lg;
                    }
                    else
                    {
                        message = "Username หรือ Password ผิดพลาด";
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }

        public static string get_container(string url,string token, string cid, ref string err)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/v1/container/" + cid.Trim());
                httpWebRequest.Headers.Add("Authorization", token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }

                //using (var streamWriter = new

                //StreamWriter(httpWebRequest.GetRequestStream()))
                //{
                //    string json = new JavaScriptSerializer().Serialize(new
                //    {
                //        rfidTags = TAGS
                //    });
                //    streamWriter.Write(json);
                //}
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception ex)
            {
                err = url + "-" + ex.Message;
                return "";
            }
        }

        public static string physicalPack(string url, string token, string cid,
                    Array TAGS,ref string err)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/v1/container/" + cid.Trim() + "/physicalPack");
                httpWebRequest.Headers.Add("Authorization", token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                //if (httpWebRequest.CookieContainer == null)
                //{
                //    httpWebRequest.CookieContainer = new CookieContainer();
                //}

                //httpWebRequest.CookieContainer.Add(Cookies);

                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        rfidTags = TAGS
                    });
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return "";
            }
        }



        public static object ListPerson(string url, CookieCollection Cookies, string category, ref string message)
        {

            //Employee: Employee, visitor: Visitor, yellowlist: Yellow list

            modelResult lg = new modelResult();
            message = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/subject/list?category=" + category.ToLower());
                //httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }

                httpWebRequest.CookieContainer.Add(Cookies);


                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<modelResult>(result);
                    return lg;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }


        public static object ListPerson(string url, CookieCollection Cookies, string category, int page, ref string message)
        {

            //Employee: Employee, visitor: Visitor, yellowlist: Yellow list

            modelResult lg = new modelResult();
            message = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/subject/list?category=" + category.ToLower() + "&page=" + page.ToString());
                //httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }

                httpWebRequest.CookieContainer.Add(Cookies);


                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<modelResult>(result);
                    return lg;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }

        public static object upload_imagexxxx(string url, CookieCollection Cookies, string filename, ref string message)
        {

            //Employee: Employee, visitor: Visitor, yellowlist: Yellow list

            modelResultUploadImage lg = new modelResultUploadImage();
            message = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/subject/photo");
                httpWebRequest.ContentType = "multipart/form-data";
                httpWebRequest.Method = "POST";

                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }
                httpWebRequest.CookieContainer.Add(Cookies);

                var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());



                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<modelResultUploadImage>(result);
                    return lg;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }

        public static object PostMultipart(string url, CookieCollection Cookies, string filename, ref string message)
        {

            try
            {
                string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
                byte[] boundaryBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/subject/photo");
                request.ContentType = "multipart/form-data; boundary=" + boundary;
                request.Method = "POST";
                request.KeepAlive = true;

                if (request.CookieContainer == null)
                {
                    request.CookieContainer = new CookieContainer();
                }
                request.CookieContainer.Add(Cookies);

                string name = "photo";
                string content_type = "image/jpeg";


                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                    string header = "Content-Disposition: form-data; name=\"" + name + "\"; filename=\"" + filename + "\"\r\nContent-Type: " + content_type + "\r\n\r\n";
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(header);
                    requestStream.Write(bytes, 0, bytes.Length);
                    byte[] buffer = new byte[32768];
                    int bytesRead;
                    // upload from file
                    using (FileStream fileStream = File.OpenRead(filename))
                    {
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                            requestStream.Write(buffer, 0, bytesRead);
                        fileStream.Close();
                    }


                    //string data = "Content-Disposition: form-data; name=\"" + param + "\"\r\n\r\n" + filename;
                    //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                    //requestStream.Write(bytes, 0, bytes.Length);

                    byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                    requestStream.Write(trailer, 0, trailer.Length);
                    requestStream.Close();



                    //string data = "Content-Disposition: form-data; name=\"" + pair.Key + "\"\r\n\r\n" + pair.Value;
                    //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                    //requestStream.Write(bytes, 0, bytes.Length);
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        var result = reader.ReadToEnd();
                        object lg = JsonConvert.DeserializeObject<modelResultUploadImage>(result);

                        return lg;
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }


        public static object register_emp(string url,
                CookieCollection Cookies,
                int[] imageid,
                string job_number,
                string name,
                string phone,
                string email,
                string department,
                string position,
                string note,
                ref string message)
        {

            //Employee: Employee, visitor: Visitor, yellowlist: Yellow list

            modelResult lg = new modelResult();
            message = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/subject");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }

                httpWebRequest.CookieContainer.Add(Cookies);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        subject_type = 0,
                        job_number = job_number,
                        name = name,
                        phone = phone,
                        email = email,
                        department = department,
                        title = position,
                        remark = note,
                        photo_ids = imageid
                    });
                    streamWriter.Write(json);
                }


                //               "subject_type": 0,
                //"job_number": "J001",
                //"name": "ธนกร  เมธเศรษฐ",
                //   "phone": "phone",
                //   "email": "email@test.om",
                //   "department": "dept1",
                //   "title": "pos1",
                //   "remark": "note",
                //   "photo_ids":[74]

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<modelResult>(result);
                    return lg;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }


        public static object delete_emp(string url, CookieCollection Cookies, int id, ref string message)
        {

            //Employee: Employee, visitor: Visitor, yellowlist: Yellow list

            modelResult lg = new modelResult();
            message = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/subject/" + id.ToString());
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Method = "DELETEx";

                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }

                httpWebRequest.CookieContainer.Add(Cookies);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<modelResult>(result);
                    return lg;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return null;
            }
        }


        public static string Post(string url,string SSNO,
                            string TITLE,
                            string FIRSTNAME,
                            string LASTNAME,
                            string DEPARTMENT,
                            string DIVISION,
                            string BUILDING,
                            string FLOOR_NAME,
                            string LOCATION_NAME,
                            string EVENT_STATUS,
                            string READERDESC,
                            string CARDNUM,
                            string EVENT_TIME,
                            string IMAGE_SNAP,
                            string IMAGE_MASTER)
        {
            try
            {


                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        SSNO = SSNO,
                        TITLE = TITLE,
                        FIRSTNAME = FIRSTNAME,
                        LASTNAME = LASTNAME,
                        DEPARTMENT = DEPARTMENT,
                        DIVISION = DIVISION,
                        BUILDING = BUILDING,
                        FLOOR_NAME = FLOOR_NAME,
                        LOCATION_NAME = LOCATION_NAME,
                        EVENT_STATUS = EVENT_STATUS,
                        READERDESC = READERDESC,
                        CARDNUM = CARDNUM,
                        EVENT_TIME = EVENT_TIME,
                        IMAGE_SNAP = IMAGE_SNAP,
                        IMAGE_MASTER = IMAGE_MASTER
                    });
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return url + "-" + ex.Message;
            }
        }
    }
}
