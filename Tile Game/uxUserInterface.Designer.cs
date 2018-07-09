namespace Tile_Game
{
    partial class uxUserInterface
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
            this.uxGameBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uxTurnLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuStrip.SuspendLayout();
            this.uxStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxGameBoard
            // 
            this.uxGameBoard.Location = new System.Drawing.Point(12, 27);
            this.uxGameBoard.Name = "uxGameBoard";
            this.uxGameBoard.Size = new System.Drawing.Size(200, 100);
            this.uxGameBoard.TabIndex = 0;
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(228, 24);
            this.uxMenuStrip.TabIndex = 1;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxSaveGame,
            this.uxLoadGame,
            this.uxNewGame});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxSaveGame
            // 
            this.uxSaveGame.Name = "uxSaveGame";
            this.uxSaveGame.Size = new System.Drawing.Size(180, 22);
            this.uxSaveGame.Text = "Save Game...";
            // 
            // uxLoadGame
            // 
            this.uxLoadGame.Name = "uxLoadGame";
            this.uxLoadGame.Size = new System.Drawing.Size(180, 22);
            this.uxLoadGame.Text = "Load Game...";
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "uxOpenFileDialog";
            // 
            // uxStatusStrip
            // 
            this.uxStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxTurnLabel});
            this.uxStatusStrip.Location = new System.Drawing.Point(0, 152);
            this.uxStatusStrip.Name = "uxStatusStrip";
            this.uxStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxStatusStrip.Size = new System.Drawing.Size(228, 22);
            this.uxStatusStrip.TabIndex = 2;
            this.uxStatusStrip.Text = "uxStatusStrip";
            // 
            // uxTurnLabel
            // 
            this.uxTurnLabel.Name = "uxTurnLabel";
            this.uxTurnLabel.Size = new System.Drawing.Size(35, 17);
            this.uxTurnLabel.Text = ":Turn";
            // 
            // uxNewGame
            // 
            this.uxNewGame.Name = "uxNewGame";
            this.uxNewGame.Size = new System.Drawing.Size(180, 22);
            this.uxNewGame.Text = "New Game...";
            // 
            // uxUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 174);
            this.Controls.Add(this.uxStatusStrip);
            this.Controls.Add(this.uxGameBoard);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "uxUserInterface";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.uxStatusStrip.ResumeLayout(false);
            this.uxStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSaveGame;
        private System.Windows.Forms.ToolStripMenuItem uxLoadGame;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.StatusStrip uxStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel uxTurnLabel;
        private System.Windows.Forms.FlowLayoutPanel uxGameBoard;
        private System.Windows.Forms.ToolStripMenuItem uxNewGame;
    }
}

