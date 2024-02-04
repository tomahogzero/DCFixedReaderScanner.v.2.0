using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCRFIDReader.Models;

namespace DCRFIDReader
{
    public class ReadTags
    {
        public static void AddTag(frmAppForm appForm, string RFID, int Antenna)
        {
            ReadTagsModel md = new ReadTagsModel
            {
                RFID = RFID,
                Antenna = Antenna,
                isProcess = false
            };

            var exists = appForm.Tags.Where(x => x.isProcess == false && x.RFID == RFID && x.Antenna == Antenna);

            if (exists != null)
            {
                appForm.Tags.Add(md);
            }
        }

        public static void StartProcess(frmAppForm appForm)
        {
            var tagsToUpdate = appForm.Tags.Where(tag => tag.isProcess == false).ToList();

            foreach (var tag in tagsToUpdate)
            {
                tag.isProcess = true;
            }
        }

        public static List<ReadTagsModel> GetProcess(frmAppForm appForm)
        {
            return appForm.Tags.Where(x => x.isProcess == true).ToList();
        }

        public static void DeleteCompleted(frmAppForm appForm)
        {
            appForm.Tags.RemoveAll(tag => tag.isProcess == true);
        }
    }
}
