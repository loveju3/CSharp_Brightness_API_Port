using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShannonAPI_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunConnectBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void RunTrainBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:5000/model/training/start";
            BrightnessAlgoTrain brightnessAlgoTrain = new BrightnessAlgoTrain();
            brightnessAlgoTrain.g_url = url;
            var  result = brightnessAlgoTrain.Run(TrainImagePathTbx.Text, Train_Lacation_Tbx.Text);
            TrainResultTbx.Text = result.ToString();
        }

        private void RunTestBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:5000/model/verify/start";
            BrightnessAlgoTest brightnessAlgoTest = new BrightnessAlgoTest();
            brightnessAlgoTest.g_url = url;
            var result = brightnessAlgoTest.Run(TestImagePathTbx.Text, Test_Location_Tbx.Text);
            TestResultTbx.Text = result.ToString();
        }

        private void CreateinstanceBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DoInitializationBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
           
        }

        // TODO
        /*         
         問題
         * trainer.py跟verifier.py要不要合併在同一支開server?
         * 最後save 什麼下來也是shannon決定嗎
         * 最後接真正的input的code 版本
         */
    }
}
