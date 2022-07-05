using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Collections.Specialized;

namespace TestShannonAPI_UI
{
    public class BrightnessAlgoTrain
    {
        // private TextFIle g_output = new TextFile();
        public string g_url = "";
        public BrightnessAlgoTrain()
        {
        }

        public bool CreateInstance()
        {
           return false;
        }

        public bool DoInitializatioin()
        {
            return false;
        }

        public bool Release()
        {
            return false;
        }

        public bool Run(string image_path, string location_path)
        {
            try
            {
                /*
                //TextFile imgFilePaths = (TextFile)fileList;
                //DataFilePortwellTrain infos = (DataFilePortwellTrain)infoList;
                //infos.m_inputQueue[0].crodX
                //infos.m_inputQueue[0].crodY
                //infos.m_inputQueue[0].width;
                //infos.m_inputQueue[0].height;
                */

                string result_string = "";
                string directory_path = Path.GetDirectoryName(image_path);
                string image_name = Path.GetFileNameWithoutExtension(image_path);

                using (var webclient = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["image"] = image_path;
                    data["item_locations"] = location_path;
                    data["working_dir"] = Path.GetDirectoryName(image_path);
                    var response = webclient.UploadValues(g_url, "POST", data);
                    result_string = Encoding.UTF8.GetString(response);
                }
                SetResult(directory_path, image_name);
                Console.WriteLine(result_string);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
           
        }

        private void SetResult(string directory_path, string file_name)
        {
            string target_file_name = file_name + "_brightnessInfo";
            string result_directory_path = Path.Combine(directory_path, "brightness");
            var output_file_path = Directory.GetFiles(result_directory_path).Where(x => Path.GetFileNameWithoutExtension(x) == target_file_name).First();
            // g_output.m_fileQueue.Add(output_file_path);
        }

        /*
        public IOFile GetResult()
        {
            return g_output;
        }
        */
    }
}
