using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestShannonAPI_UI
{   
    // class BrightnessAlgo: Algorithm
    class BrightnessAlgoTest
    {
        // private TextFIle g_output = new TextFile();
        public string g_url = "";


        public BrightnessAlgoTest()
        {
        }

        public bool CreateInstance()
        {
            return true;
        }

        public bool DoInitializatioin()
        {
            return true;
        }

        public bool Release()
        {
            return true;
        }

        public bool Run(string image_path, string location_path)
        {
            try
            {
                /* 
                //原本的 Run(IOFile input1, IOFile input2)
                //TextFile imgFilePaths = (TextFile)fileList;
                //DataFilePortwellTrain infos = (DataFilePortwellTrain)infoList;
                //infos.m_inputQueue[0].crodX
                //infos.m_inputQueue[0].crodY
                //infos.m_inputQueue[0].width;
                //infos.m_inputQueue[0].height;
                */

                string directory_path = Path.GetDirectoryName(image_path);
                string image_name = Path.GetFileNameWithoutExtension(image_path);
                string result_string = "";

                using (var web_client = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["image"] = image_path;
                    data["item_locations"] = location_path;
                    data["working_dir"] = Path.GetDirectoryName(image_path);
                    var response = web_client.UploadValues(url, "POST", data);
                    result_string = Encoding.UTF8.GetString(response);
                }
                SetResult(directory_path, image_name);
                Console.WriteLine(result_string);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        // 先想成每一次只拿一張大圖的結果
        private void SetResult(string directory_path, string file_name)
        {
            string target_file_name = file_name + "_prediction";
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
