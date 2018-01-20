namespace MP3_BatchEditor
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
            this.splDirTree = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvDirTree = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splDirTree)).BeginInit();
            this.splDirTree.Panel1.SuspendLayout();
            this.splDirTree.Panel2.SuspendLayout();
            this.splDirTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splDirTree
            // 
            this.splDirTree.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splDirTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splDirTree.Location = new System.Drawing.Point(0, 0);
            this.splDirTree.Name = "splDirTree";
            // 
            // splDirTree.Panel1
            // 
            this.splDirTree.Panel1.Controls.Add(this.tvDirTree);
            // 
            // splDirTree.Panel2
            // 
            this.splDirTree.Panel2.Controls.Add(this.splitContainer2);
            this.splDirTree.Size = new System.Drawing.Size(1335, 968);
            this.splDirTree.SplitterDistance = 445;
            this.splDirTree.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(886, 968);
            this.splitContainer2.SplitterDistance = 492;
            this.splitContainer2.TabIndex = 0;
            // 
            // tvDirTree
            // 
            this.tvDirTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDirTree.Location = new System.Drawing.Point(0, 0);
            this.tvDirTree.Name = "tvDirTree";
            this.tvDirTree.Size = new System.Drawing.Size(445, 968);
            this.tvDirTree.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 968);
            this.Controls.Add(this.splDirTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splDirTree.Panel1.ResumeLayout(false);
            this.splDirTree.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splDirTree)).EndInit();
            this.splDirTree.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splDirTree;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvDirTree;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

