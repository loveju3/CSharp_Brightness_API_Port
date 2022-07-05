namespace TestShannonAPI_UI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RunConnectBtn = new System.Windows.Forms.Button();
            this.RunTrainBtn = new System.Windows.Forms.Button();
            this.TrainImagePathTbx = new System.Windows.Forms.TextBox();
            this.TrainImagePathLabel = new System.Windows.Forms.Label();
            this.TesrImageLabel = new System.Windows.Forms.Label();
            this.TestImagePathTbx = new System.Windows.Forms.TextBox();
            this.RunTestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Train_Lacation_Tbx = new System.Windows.Forms.TextBox();
            this.Test_Location_Tbx = new System.Windows.Forms.TextBox();
            this.TrainResultTbx = new System.Windows.Forms.TextBox();
            this.TestResultTbx = new System.Windows.Forms.TextBox();
            this.ConnectResultTbx = new System.Windows.Forms.TextBox();
            this.CreateinstanceBtn = new System.Windows.Forms.Button();
            this.DoInitializationBtn = new System.Windows.Forms.Button();
            this.ReleaseBtn = new System.Windows.Forms.Button();
            this.CreateInstanceTbx = new System.Windows.Forms.TextBox();
            this.DoInitializationTbx = new System.Windows.Forms.TextBox();
            this.ReleaseTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RunConnectBtn
            // 
            this.RunConnectBtn.Location = new System.Drawing.Point(576, 151);
            this.RunConnectBtn.Name = "RunConnectBtn";
            this.RunConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.RunConnectBtn.TabIndex = 0;
            this.RunConnectBtn.Text = "Run_Connect";
            this.RunConnectBtn.UseVisualStyleBackColor = true;
            this.RunConnectBtn.Click += new System.EventHandler(this.RunConnectBtn_Click);
            // 
            // RunTrainBtn
            // 
            this.RunTrainBtn.Location = new System.Drawing.Point(323, 86);
            this.RunTrainBtn.Name = "RunTrainBtn";
            this.RunTrainBtn.Size = new System.Drawing.Size(75, 23);
            this.RunTrainBtn.TabIndex = 1;
            this.RunTrainBtn.Text = "Run_Train";
            this.RunTrainBtn.UseVisualStyleBackColor = true;
            this.RunTrainBtn.Click += new System.EventHandler(this.RunTrainBtn_Click);
            // 
            // TrainImagePathTbx
            // 
            this.TrainImagePathTbx.Location = new System.Drawing.Point(50, 87);
            this.TrainImagePathTbx.Name = "TrainImagePathTbx";
            this.TrainImagePathTbx.Size = new System.Drawing.Size(229, 22);
            this.TrainImagePathTbx.TabIndex = 2;
            this.TrainImagePathTbx.Text = "C:\\Users\\Leo7_Liu\\Postman\\files\\test_trainer\\src5.png";
            // 
            // TrainImagePathLabel
            // 
            this.TrainImagePathLabel.AutoSize = true;
            this.TrainImagePathLabel.Location = new System.Drawing.Point(48, 72);
            this.TrainImagePathLabel.Name = "TrainImagePathLabel";
            this.TrainImagePathLabel.Size = new System.Drawing.Size(91, 12);
            this.TrainImagePathLabel.TabIndex = 3;
            this.TrainImagePathLabel.Text = "Train_Image_Path";
            // 
            // TesrImageLabel
            // 
            this.TesrImageLabel.AutoSize = true;
            this.TesrImageLabel.Location = new System.Drawing.Point(48, 173);
            this.TesrImageLabel.Name = "TesrImageLabel";
            this.TesrImageLabel.Size = new System.Drawing.Size(85, 12);
            this.TesrImageLabel.TabIndex = 4;
            this.TesrImageLabel.Text = "Test_Image_Path";
            // 
            // TestImagePathTbx
            // 
            this.TestImagePathTbx.Location = new System.Drawing.Point(50, 188);
            this.TestImagePathTbx.Name = "TestImagePathTbx";
            this.TestImagePathTbx.Size = new System.Drawing.Size(229, 22);
            this.TestImagePathTbx.TabIndex = 5;
            this.TestImagePathTbx.Text = "C:\\Users\\Leo7_Liu\\Postman\\files\\test_trainer\\src5.png";
            // 
            // RunTestBtn
            // 
            this.RunTestBtn.Location = new System.Drawing.Point(323, 188);
            this.RunTestBtn.Name = "RunTestBtn";
            this.RunTestBtn.Size = new System.Drawing.Size(75, 23);
            this.RunTestBtn.TabIndex = 6;
            this.RunTestBtn.Text = "Run_Test";
            this.RunTestBtn.UseVisualStyleBackColor = true;
            this.RunTestBtn.Click += new System.EventHandler(this.RunTestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Train_location_Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test_locaton_Path";
            // 
            // Train_Lacation_Tbx
            // 
            this.Train_Lacation_Tbx.Location = new System.Drawing.Point(50, 127);
            this.Train_Lacation_Tbx.Name = "Train_Lacation_Tbx";
            this.Train_Lacation_Tbx.Size = new System.Drawing.Size(229, 22);
            this.Train_Lacation_Tbx.TabIndex = 9;
            this.Train_Lacation_Tbx.Text = "C:\\Users\\Leo7_Liu\\Postman\\files\\test_trainer\\location.json";
            // 
            // Test_Location_Tbx
            // 
            this.Test_Location_Tbx.Location = new System.Drawing.Point(50, 228);
            this.Test_Location_Tbx.Name = "Test_Location_Tbx";
            this.Test_Location_Tbx.Size = new System.Drawing.Size(229, 22);
            this.Test_Location_Tbx.TabIndex = 10;
            this.Test_Location_Tbx.Text = "C:\\Users\\Leo7_Liu\\Postman\\files\\test_trainer\\location.json";
            // 
            // TrainResultTbx
            // 
            this.TrainResultTbx.Location = new System.Drawing.Point(416, 86);
            this.TrainResultTbx.Name = "TrainResultTbx";
            this.TrainResultTbx.Size = new System.Drawing.Size(69, 22);
            this.TrainResultTbx.TabIndex = 11;
            // 
            // TestResultTbx
            // 
            this.TestResultTbx.Location = new System.Drawing.Point(416, 188);
            this.TestResultTbx.Name = "TestResultTbx";
            this.TestResultTbx.Size = new System.Drawing.Size(69, 22);
            this.TestResultTbx.TabIndex = 12;
            // 
            // ConnectResultTbx
            // 
            this.ConnectResultTbx.Location = new System.Drawing.Point(667, 151);
            this.ConnectResultTbx.Name = "ConnectResultTbx";
            this.ConnectResultTbx.Size = new System.Drawing.Size(69, 22);
            this.ConnectResultTbx.TabIndex = 13;
            // 
            // CreateinstanceBtn
            // 
            this.CreateinstanceBtn.Location = new System.Drawing.Point(323, 282);
            this.CreateinstanceBtn.Name = "CreateinstanceBtn";
            this.CreateinstanceBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateinstanceBtn.TabIndex = 14;
            this.CreateinstanceBtn.Text = "Create_Instance";
            this.CreateinstanceBtn.UseVisualStyleBackColor = true;
            this.CreateinstanceBtn.Click += new System.EventHandler(this.CreateinstanceBtn_Click);
            // 
            // DoInitializationBtn
            // 
            this.DoInitializationBtn.Location = new System.Drawing.Point(323, 327);
            this.DoInitializationBtn.Name = "DoInitializationBtn";
            this.DoInitializationBtn.Size = new System.Drawing.Size(75, 23);
            this.DoInitializationBtn.TabIndex = 15;
            this.DoInitializationBtn.Text = "Do_Initization";
            this.DoInitializationBtn.UseVisualStyleBackColor = true;
            this.DoInitializationBtn.Click += new System.EventHandler(this.DoInitializationBtn_Click);
            // 
            // ReleaseBtn
            // 
            this.ReleaseBtn.AllowDrop = true;
            this.ReleaseBtn.Location = new System.Drawing.Point(323, 371);
            this.ReleaseBtn.Name = "ReleaseBtn";
            this.ReleaseBtn.Size = new System.Drawing.Size(75, 23);
            this.ReleaseBtn.TabIndex = 16;
            this.ReleaseBtn.Text = "Release";
            this.ReleaseBtn.UseVisualStyleBackColor = true;
            this.ReleaseBtn.Click += new System.EventHandler(this.ReleaseBtn_Click);
            // 
            // CreateInstanceTbx
            // 
            this.CreateInstanceTbx.Location = new System.Drawing.Point(416, 282);
            this.CreateInstanceTbx.Name = "CreateInstanceTbx";
            this.CreateInstanceTbx.Size = new System.Drawing.Size(69, 22);
            this.CreateInstanceTbx.TabIndex = 17;
            // 
            // DoInitializationTbx
            // 
            this.DoInitializationTbx.Location = new System.Drawing.Point(416, 327);
            this.DoInitializationTbx.Name = "DoInitializationTbx";
            this.DoInitializationTbx.Size = new System.Drawing.Size(69, 22);
            this.DoInitializationTbx.TabIndex = 18;
            // 
            // ReleaseTbx
            // 
            this.ReleaseTbx.Location = new System.Drawing.Point(416, 373);
            this.ReleaseTbx.Name = "ReleaseTbx";
            this.ReleaseTbx.Size = new System.Drawing.Size(69, 22);
            this.ReleaseTbx.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReleaseTbx);
            this.Controls.Add(this.DoInitializationTbx);
            this.Controls.Add(this.CreateInstanceTbx);
            this.Controls.Add(this.ReleaseBtn);
            this.Controls.Add(this.DoInitializationBtn);
            this.Controls.Add(this.CreateinstanceBtn);
            this.Controls.Add(this.ConnectResultTbx);
            this.Controls.Add(this.TestResultTbx);
            this.Controls.Add(this.TrainResultTbx);
            this.Controls.Add(this.Test_Location_Tbx);
            this.Controls.Add(this.Train_Lacation_Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunTestBtn);
            this.Controls.Add(this.TestImagePathTbx);
            this.Controls.Add(this.TesrImageLabel);
            this.Controls.Add(this.TrainImagePathLabel);
            this.Controls.Add(this.TrainImagePathTbx);
            this.Controls.Add(this.RunTrainBtn);
            this.Controls.Add(this.RunConnectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunConnectBtn;
        private System.Windows.Forms.Button RunTrainBtn;
        private System.Windows.Forms.TextBox TrainImagePathTbx;
        private System.Windows.Forms.Label TrainImagePathLabel;
        private System.Windows.Forms.Label TesrImageLabel;
        private System.Windows.Forms.TextBox TestImagePathTbx;
        private System.Windows.Forms.Button RunTestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Train_Lacation_Tbx;
        private System.Windows.Forms.TextBox Test_Location_Tbx;
        private System.Windows.Forms.TextBox TrainResultTbx;
        private System.Windows.Forms.TextBox TestResultTbx;
        private System.Windows.Forms.TextBox ConnectResultTbx;
        private System.Windows.Forms.Button CreateinstanceBtn;
        private System.Windows.Forms.Button DoInitializationBtn;
        private System.Windows.Forms.Button ReleaseBtn;
        private System.Windows.Forms.TextBox CreateInstanceTbx;
        private System.Windows.Forms.TextBox DoInitializationTbx;
        private System.Windows.Forms.TextBox ReleaseTbx;
    }
}

