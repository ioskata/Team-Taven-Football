using System.Windows.Forms;

namespace TeamTavenFootball
{
    partial class FootballEngine
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
            this.update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 10;
            this.update.Tick += new System.EventHandler(this.Update);
            // 
            // FootballEngine
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FootballEngine";
            this.ResumeLayout(false);

        }

        #endregion

        private Timer update;
    }
}

