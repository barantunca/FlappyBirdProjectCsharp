namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBird = new DevExpress.XtraEditors.PictureEdit();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeBot1 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeTop1 = new DevExpress.XtraEditors.PictureEdit();
            this.picGround = new DevExpress.XtraEditors.PictureEdit();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.pipeBot3 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeBot2 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeTop2 = new DevExpress.XtraEditors.PictureEdit();
            this.pipeTop3 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picBird
            // 
            this.picBird.EditValue = global::WindowsFormsApp1.Properties.Resources.yellowbird_midflap;
            this.picBird.Location = new System.Drawing.Point(17, 137);
            this.picBird.Name = "picBird";
            this.picBird.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picBird.Properties.Appearance.Options.UseBackColor = true;
            this.picBird.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picBird.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picBird.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picBird.Size = new System.Drawing.Size(44, 33);
            this.picBird.TabIndex = 0;
            // 
            // pipeBot1
            // 
            this.pipeBot1.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBot1.Location = new System.Drawing.Point(221, 291);
            this.pipeBot1.Name = "pipeBot1";
            this.pipeBot1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBot1.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBot1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBot1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBot1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBot1.Size = new System.Drawing.Size(59, 386);
            this.pipeBot1.TabIndex = 3;
            // 
            // pipeTop1
            // 
            this.pipeTop1.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green1;
            this.pipeTop1.Location = new System.Drawing.Point(221, -142);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop1.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop1.Size = new System.Drawing.Size(59, 333);
            this.pipeTop1.TabIndex = 4;
            // 
            // picGround
            // 
            this.picGround.EditValue = global::WindowsFormsApp1.Properties.Resources._base;
            this.picGround.Location = new System.Drawing.Point(-8, 444);
            this.picGround.Name = "picGround";
            this.picGround.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picGround.Properties.Appearance.Options.UseBackColor = true;
            this.picGround.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picGround.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picGround.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picGround.Size = new System.Drawing.Size(827, 159);
            this.picGround.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Appearance.Options.UseFont = true;
            this.lblScore.Location = new System.Drawing.Point(12, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(116, 35);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "score: 0";
            // 
            // pipeBot3
            // 
            this.pipeBot3.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBot3.Location = new System.Drawing.Point(712, 291);
            this.pipeBot3.Name = "pipeBot3";
            this.pipeBot3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBot3.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBot3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBot3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBot3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBot3.Size = new System.Drawing.Size(59, 386);
            this.pipeBot3.TabIndex = 10;
            // 
            // pipeBot2
            // 
            this.pipeBot2.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.pipeBot2.Location = new System.Drawing.Point(458, 291);
            this.pipeBot2.Name = "pipeBot2";
            this.pipeBot2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBot2.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBot2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBot2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBot2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBot2.Size = new System.Drawing.Size(59, 386);
            this.pipeBot2.TabIndex = 11;
            this.pipeBot2.EditValueChanged += new System.EventHandler(this.pictureEdit2_EditValueChanged);
            // 
            // pipeTop2
            // 
            this.pipeTop2.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green1;
            this.pipeTop2.Location = new System.Drawing.Point(458, -142);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop2.Size = new System.Drawing.Size(59, 333);
            this.pipeTop2.TabIndex = 12;
            // 
            // pipeTop3
            // 
            this.pipeTop3.EditValue = global::WindowsFormsApp1.Properties.Resources.pipe_green1;
            this.pipeTop3.Location = new System.Drawing.Point(712, -142);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop3.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop3.Size = new System.Drawing.Size(59, 333);
            this.pipeTop3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_day;
            this.ClientSize = new System.Drawing.Size(810, 507);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.pipeBot2);
            this.Controls.Add(this.pipeBot3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.pipeBot1);
            this.Controls.Add(this.picBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBird.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBot2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picBird;
        private System.Windows.Forms.Timer gameTimer;
        private DevExpress.XtraEditors.PictureEdit pipeBot1;
        private DevExpress.XtraEditors.PictureEdit pipeTop1;
        private DevExpress.XtraEditors.PictureEdit picGround;
        private DevExpress.XtraEditors.LabelControl lblScore;
        private DevExpress.XtraEditors.PictureEdit pipeBot3;
        private DevExpress.XtraEditors.PictureEdit pipeBot2;
        private DevExpress.XtraEditors.PictureEdit pipeTop2;
        private DevExpress.XtraEditors.PictureEdit pipeTop3;
    }
}

