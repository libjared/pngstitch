namespace PNGStitch
{
    partial class MainForm
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxOrientation = new System.Windows.Forms.GroupBox();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButtonHoriz = new System.Windows.Forms.RadioButton();
            this.buttonStitch = new System.Windows.Forms.Button();
            this.groupBoxAnchor = new System.Windows.Forms.GroupBox();
            this.radioButtonAnchorCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonAnchorTopLeft = new System.Windows.Forms.RadioButton();
            this.groupBoxResSize = new System.Windows.Forms.GroupBox();
            this.radioButtonResSum = new System.Windows.Forms.RadioButton();
            this.radioButtonResConstant = new System.Windows.Forms.RadioButton();
            this.groupBoxOrientation.SuspendLayout();
            this.groupBoxAnchor.SuspendLayout();
            this.groupBoxResSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 13);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(109, 34);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxOrientation
            // 
            this.groupBoxOrientation.Controls.Add(this.radioButtonVert);
            this.groupBoxOrientation.Controls.Add(this.radioButtonHoriz);
            this.groupBoxOrientation.Location = new System.Drawing.Point(13, 54);
            this.groupBoxOrientation.Name = "groupBoxOrientation";
            this.groupBoxOrientation.Size = new System.Drawing.Size(109, 79);
            this.groupBoxOrientation.TabIndex = 1;
            this.groupBoxOrientation.TabStop = false;
            this.groupBoxOrientation.Text = "Orientation";
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(7, 43);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(60, 17);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.Text = "Vertical";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.radioButtonVert_CheckedChanged);
            // 
            // radioButtonHoriz
            // 
            this.radioButtonHoriz.AutoSize = true;
            this.radioButtonHoriz.Checked = true;
            this.radioButtonHoriz.Location = new System.Drawing.Point(7, 20);
            this.radioButtonHoriz.Name = "radioButtonHoriz";
            this.radioButtonHoriz.Size = new System.Drawing.Size(72, 17);
            this.radioButtonHoriz.TabIndex = 0;
            this.radioButtonHoriz.TabStop = true;
            this.radioButtonHoriz.Text = "Horizontal";
            this.radioButtonHoriz.UseVisualStyleBackColor = true;
            this.radioButtonHoriz.CheckedChanged += new System.EventHandler(this.radioButtonHoriz_CheckedChanged);
            // 
            // buttonStitch
            // 
            this.buttonStitch.Enabled = false;
            this.buttonStitch.Location = new System.Drawing.Point(128, 14);
            this.buttonStitch.Name = "buttonStitch";
            this.buttonStitch.Size = new System.Drawing.Size(109, 34);
            this.buttonStitch.TabIndex = 3;
            this.buttonStitch.Text = "Stitch";
            this.buttonStitch.UseVisualStyleBackColor = true;
            this.buttonStitch.Click += new System.EventHandler(this.buttonStitch_Click);
            // 
            // groupBoxAnchor
            // 
            this.groupBoxAnchor.Controls.Add(this.radioButtonAnchorCenter);
            this.groupBoxAnchor.Controls.Add(this.radioButtonAnchorTopLeft);
            this.groupBoxAnchor.Location = new System.Drawing.Point(128, 54);
            this.groupBoxAnchor.Name = "groupBoxAnchor";
            this.groupBoxAnchor.Size = new System.Drawing.Size(109, 79);
            this.groupBoxAnchor.TabIndex = 4;
            this.groupBoxAnchor.TabStop = false;
            this.groupBoxAnchor.Text = "Anchor";
            // 
            // radioButtonAnchorCenter
            // 
            this.radioButtonAnchorCenter.AutoSize = true;
            this.radioButtonAnchorCenter.Checked = true;
            this.radioButtonAnchorCenter.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAnchorCenter.Name = "radioButtonAnchorCenter";
            this.radioButtonAnchorCenter.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAnchorCenter.TabIndex = 1;
            this.radioButtonAnchorCenter.TabStop = true;
            this.radioButtonAnchorCenter.Text = "Center";
            this.radioButtonAnchorCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnchorTopLeft
            // 
            this.radioButtonAnchorTopLeft.AutoSize = true;
            this.radioButtonAnchorTopLeft.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAnchorTopLeft.Name = "radioButtonAnchorTopLeft";
            this.radioButtonAnchorTopLeft.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAnchorTopLeft.TabIndex = 0;
            this.radioButtonAnchorTopLeft.Text = "Top";
            this.radioButtonAnchorTopLeft.UseVisualStyleBackColor = true;
            // 
            // groupBoxResSize
            // 
            this.groupBoxResSize.Controls.Add(this.radioButtonResSum);
            this.groupBoxResSize.Controls.Add(this.radioButtonResConstant);
            this.groupBoxResSize.Location = new System.Drawing.Point(13, 139);
            this.groupBoxResSize.Name = "groupBoxResSize";
            this.groupBoxResSize.Size = new System.Drawing.Size(224, 79);
            this.groupBoxResSize.TabIndex = 5;
            this.groupBoxResSize.TabStop = false;
            this.groupBoxResSize.Text = "Resulting Width";
            // 
            // radioButtonResSum
            // 
            this.radioButtonResSum.AutoSize = true;
            this.radioButtonResSum.Location = new System.Drawing.Point(7, 43);
            this.radioButtonResSum.Name = "radioButtonResSum";
            this.radioButtonResSum.Size = new System.Drawing.Size(139, 17);
            this.radioButtonResSum.TabIndex = 1;
            this.radioButtonResSum.TabStop = true;
            this.radioButtonResSum.Text = "Dynamic (sum of widths)";
            this.radioButtonResSum.UseVisualStyleBackColor = true;
            // 
            // radioButtonResConstant
            // 
            this.radioButtonResConstant.AutoSize = true;
            this.radioButtonResConstant.Checked = true;
            this.radioButtonResConstant.Location = new System.Drawing.Point(7, 20);
            this.radioButtonResConstant.Name = "radioButtonResConstant";
            this.radioButtonResConstant.Size = new System.Drawing.Size(156, 17);
            this.radioButtonResConstant.TabIndex = 0;
            this.radioButtonResConstant.TabStop = true;
            this.radioButtonResConstant.Text = "Constant (first width times n)";
            this.radioButtonResConstant.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 228);
            this.Controls.Add(this.groupBoxResSize);
            this.Controls.Add(this.groupBoxAnchor);
            this.Controls.Add(this.buttonStitch);
            this.Controls.Add(this.groupBoxOrientation);
            this.Controls.Add(this.buttonLoad);
            this.Name = "MainForm";
            this.Text = "PNG Stitch";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.groupBoxOrientation.ResumeLayout(false);
            this.groupBoxOrientation.PerformLayout();
            this.groupBoxAnchor.ResumeLayout(false);
            this.groupBoxAnchor.PerformLayout();
            this.groupBoxResSize.ResumeLayout(false);
            this.groupBoxResSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxOrientation;
        private System.Windows.Forms.RadioButton radioButtonVert;
        private System.Windows.Forms.RadioButton radioButtonHoriz;
        private System.Windows.Forms.Button buttonStitch;
        private System.Windows.Forms.GroupBox groupBoxAnchor;
        private System.Windows.Forms.RadioButton radioButtonAnchorCenter;
        private System.Windows.Forms.RadioButton radioButtonAnchorTopLeft;
        private System.Windows.Forms.GroupBox groupBoxResSize;
        private System.Windows.Forms.RadioButton radioButtonResSum;
        private System.Windows.Forms.RadioButton radioButtonResConstant;
    }
}