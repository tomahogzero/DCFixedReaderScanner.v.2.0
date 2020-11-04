using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class modelSubject
    {
        public string avatar { get; set; }
        public int birthday { get; set; }
        public string come_from { get; set; }
        public int company_id { get; set; }
        public int create_time { get; set; }
        public string department { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public int end_time { get; set; }
        public int entry_date { get; set; }
        public int extra_id { get; set; }
        public int gender { get; set; }
        public int[] groups { get; set; }
        public int id { get; set; }
        public string interviewee { get; set; }
        public string interviewee_pinyin { get; set; }
        public string job_number { get; set; }
        public string name { get; set; }
        public string password_reseted { get; set; }
        public string phone { get; set; }
        public List<modelPhotos> photos { get; set; }
        public string pinyin { get; set; }
        public int purpose { get; set; }
        public string remark { get; set; }
        public int start_time { get; set; }
        public int subject_type { get; set; }
        public string title { get; set; }
        public bool visit_notify { get; set; }
        public string wg_number { get; set; }
    }

    public class modelPhotos
    {
        public int company_id { get; set; }
        public int id { get; set; }
        public string origin_url { get; set; }
        public float quality { get; set; }
        public int subject_id { get; set; }
        public int url { get; set; }
        public int version { get; set; }
    }

    public class modelPage
    {
       public int count { get; set; }
        public int current { get; set; }
        public int size { get; set; }
        public int total { get; set; }
    }

    public class modelDataUploadImage
    {
        public int company_id { get; set; }
        public int id { get; set; }
        public string origin_url { get; set; }
        public object quality { get; set; }
        public object subject_id { get; set; }
        public string url { get; set; }
        public int version { get; set; }
    }
}


//"data": [
//    {
//      "avatar": "/static/upload/avatar/2020-08-23/v2_0194194dba95e353ac068aa3cb10a97936cbb6fc.jpg",
//      "birthday": 1598025600,
//      "come_from": "",
//      "company_id": 1,
//      "create_time": 1598140659,
//      "department": "Manager",
//      "description": "",
//      "email": "th@gmail.com",
//      "end_time": 0,
//      "entry_date": 1598025600,
//      "extra_id": "1",
//      "gender": 1,
//      "groups": [],
//      "id": 1,
//      "interviewee": "",
//      "interviewee_pinyin": "",
//      "job_number": "0001",
//      "name": "Thanakorn",
//      "password_reseted": false,
//      "phone": "081-1234234",
//      "photos": [
//        {
//          "company_id": 1,
//          "id": 1,
//          "origin_url": "/static/upload/origin/2020-08-23/v2_0ea584be596118f586938cd6c61c8770273807a1.jpg",
//          "quality": 0.99598,
//          "subject_id": 1,
//          "url": "/static/upload/photo/2020-08-23/v2_718d83241d99f910dbdb7466c80f8ea2a88878f7.jpg",
//          "version": 7
//        }
//      ],
//      "pinyin": "Thanakorn",
//      "purpose": 0,
//      "remark": "",
//      "start_time": 0,
//      "subject_type": 0,
//      "title": "GM",
//      "visit_notify": false,
//      "wg_number": "123456897"
//    }
//  ]