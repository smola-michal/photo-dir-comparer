namespace WindowsFormsPhotoDirComparer
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
            this._textPathLeft = new System.Windows.Forms.TextBox();
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this._textPathRight = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._radioDuplicates = new System.Windows.Forms.RadioButton();
            this._radioOriginals = new System.Windows.Forms.RadioButton();
            this._buttonSaveLeft = new System.Windows.Forms.Button();
            this._buttonSaveRight = new System.Windows.Forms.Button();
            this._splitContainerResults = new System.Windows.Forms.SplitContainer();
            this._buttonCopyToRight = new System.Windows.Forms.Button();
            this._buttonCopyToLeft = new System.Windows.Forms.Button();
            this._buttonLoadLeft = new System.Windows.Forms.Button();
            this._buttonLoadRight = new System.Windows.Forms.Button();
            this._labelLoadTimeLeft = new System.Windows.Forms.Label();
            this._labelLoadTimeRight = new System.Windows.Forms.Label();
            this._listResultLeft = new System.Windows.Forms.ListBox();
            this._listResultRight = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerResults)).BeginInit();
            this._splitContainerResults.Panel1.SuspendLayout();
            this._splitContainerResults.Panel2.SuspendLayout();
            this._splitContainerResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // _textPathLeft
            // 
            this._textPathLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textPathLeft.Location = new System.Drawing.Point(73, 6);
            this._textPathLeft.Name = "_textPathLeft";
            this._textPathLeft.Size = new System.Drawing.Size(391, 20);
            this._textPathLeft.TabIndex = 0;
            this._textPathLeft.Text = "C:\\Users\\Michal\\Pictures\\temp";
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse1.Location = new System.Drawing.Point(470, 4);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse1.TabIndex = 1;
            this.buttonBrowse1.Text = "Browse";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.BrowseClick);
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse2.Location = new System.Drawing.Point(470, 32);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse2.TabIndex = 2;
            this.buttonBrowse2.Text = "Browse";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.BrowseClick);
            // 
            // _textPathRight
            // 
            this._textPathRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textPathRight.Location = new System.Drawing.Point(73, 34);
            this._textPathRight.Name = "_textPathRight";
            this._textPathRight.Size = new System.Drawing.Size(391, 20);
            this._textPathRight.TabIndex = 3;
            this._textPathRight.Text = "C:\\Users\\Michal\\Pictures\\temp2";
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(470, 61);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(225, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.GoClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path right:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // _radioDuplicates
            // 
            this._radioDuplicates.AutoSize = true;
            this._radioDuplicates.Checked = true;
            this._radioDuplicates.Location = new System.Drawing.Point(15, 65);
            this._radioDuplicates.Name = "_radioDuplicates";
            this._radioDuplicates.Size = new System.Drawing.Size(75, 17);
            this._radioDuplicates.TabIndex = 9;
            this._radioDuplicates.TabStop = true;
            this._radioDuplicates.Text = "Duplicates";
            this._radioDuplicates.UseVisualStyleBackColor = true;
            // 
            // _radioOriginals
            // 
            this._radioOriginals.AutoSize = true;
            this._radioOriginals.Location = new System.Drawing.Point(96, 65);
            this._radioOriginals.Name = "_radioOriginals";
            this._radioOriginals.Size = new System.Drawing.Size(65, 17);
            this._radioOriginals.TabIndex = 10;
            this._radioOriginals.Text = "Originals";
            this._radioOriginals.UseVisualStyleBackColor = true;
            // 
            // _buttonSaveLeft
            // 
            this._buttonSaveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonSaveLeft.Enabled = false;
            this._buttonSaveLeft.Location = new System.Drawing.Point(4, 297);
            this._buttonSaveLeft.Name = "_buttonSaveLeft";
            this._buttonSaveLeft.Size = new System.Drawing.Size(75, 23);
            this._buttonSaveLeft.TabIndex = 12;
            this._buttonSaveLeft.Text = "Save to file";
            this._buttonSaveLeft.UseVisualStyleBackColor = true;
            this._buttonSaveLeft.Click += new System.EventHandler(this.SaveLeft_Click);
            // 
            // _buttonSaveRight
            // 
            this._buttonSaveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSaveRight.Enabled = false;
            this._buttonSaveRight.Location = new System.Drawing.Point(263, 297);
            this._buttonSaveRight.Name = "_buttonSaveRight";
            this._buttonSaveRight.Size = new System.Drawing.Size(75, 23);
            this._buttonSaveRight.TabIndex = 13;
            this._buttonSaveRight.Text = "Save to file";
            this._buttonSaveRight.UseVisualStyleBackColor = true;
            this._buttonSaveRight.Click += new System.EventHandler(this.SaveRight);
            // 
            // _splitContainerResults
            // 
            this._splitContainerResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitContainerResults.Location = new System.Drawing.Point(12, 113);
            this._splitContainerResults.Name = "_splitContainerResults";
            // 
            // _splitContainerResults.Panel1
            // 
            this._splitContainerResults.Panel1.Controls.Add(this._listResultLeft);
            this._splitContainerResults.Panel1.Controls.Add(this._buttonCopyToRight);
            this._splitContainerResults.Panel1.Controls.Add(this._buttonSaveLeft);
            // 
            // _splitContainerResults.Panel2
            // 
            this._splitContainerResults.Panel2.Controls.Add(this._listResultRight);
            this._splitContainerResults.Panel2.Controls.Add(this._buttonCopyToLeft);
            this._splitContainerResults.Panel2.Controls.Add(this._buttonSaveRight);
            this._splitContainerResults.Size = new System.Drawing.Size(683, 323);
            this._splitContainerResults.SplitterDistance = 338;
            this._splitContainerResults.TabIndex = 14;
            // 
            // _buttonCopyToRight
            // 
            this._buttonCopyToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCopyToRight.Location = new System.Drawing.Point(260, 297);
            this._buttonCopyToRight.Name = "_buttonCopyToRight";
            this._buttonCopyToRight.Size = new System.Drawing.Size(75, 23);
            this._buttonCopyToRight.TabIndex = 13;
            this._buttonCopyToRight.Text = "Copy right";
            this._buttonCopyToRight.UseVisualStyleBackColor = true;
            this._buttonCopyToRight.Click += new System.EventHandler(this.CopyToRightClick);
            // 
            // _buttonCopyToLeft
            // 
            this._buttonCopyToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonCopyToLeft.Location = new System.Drawing.Point(3, 297);
            this._buttonCopyToLeft.Name = "_buttonCopyToLeft";
            this._buttonCopyToLeft.Size = new System.Drawing.Size(75, 23);
            this._buttonCopyToLeft.TabIndex = 14;
            this._buttonCopyToLeft.Text = "Copy left";
            this._buttonCopyToLeft.UseVisualStyleBackColor = true;
            this._buttonCopyToLeft.Click += new System.EventHandler(this.CopyToLeftClick);
            // 
            // _buttonLoadLeft
            // 
            this._buttonLoadLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonLoadLeft.Location = new System.Drawing.Point(551, 4);
            this._buttonLoadLeft.Name = "_buttonLoadLeft";
            this._buttonLoadLeft.Size = new System.Drawing.Size(75, 23);
            this._buttonLoadLeft.TabIndex = 15;
            this._buttonLoadLeft.Text = "Load";
            this._buttonLoadLeft.UseVisualStyleBackColor = true;
            this._buttonLoadLeft.Click += new System.EventHandler(this.LoadLeftClick);
            // 
            // _buttonLoadRight
            // 
            this._buttonLoadRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonLoadRight.Location = new System.Drawing.Point(551, 32);
            this._buttonLoadRight.Name = "_buttonLoadRight";
            this._buttonLoadRight.Size = new System.Drawing.Size(75, 23);
            this._buttonLoadRight.TabIndex = 16;
            this._buttonLoadRight.Text = "Load";
            this._buttonLoadRight.UseVisualStyleBackColor = true;
            this._buttonLoadRight.Click += new System.EventHandler(this.LoadRightClick);
            // 
            // _labelLoadTimeLeft
            // 
            this._labelLoadTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labelLoadTimeLeft.AutoSize = true;
            this._labelLoadTimeLeft.Location = new System.Drawing.Point(633, 12);
            this._labelLoadTimeLeft.Name = "_labelLoadTimeLeft";
            this._labelLoadTimeLeft.Size = new System.Drawing.Size(43, 13);
            this._labelLoadTimeLeft.TabIndex = 17;
            this._labelLoadTimeLeft.Text = "0:00:00";
            // 
            // _labelLoadTimeRight
            // 
            this._labelLoadTimeRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labelLoadTimeRight.AutoSize = true;
            this._labelLoadTimeRight.Location = new System.Drawing.Point(633, 37);
            this._labelLoadTimeRight.Name = "_labelLoadTimeRight";
            this._labelLoadTimeRight.Size = new System.Drawing.Size(43, 13);
            this._labelLoadTimeRight.TabIndex = 18;
            this._labelLoadTimeRight.Text = "0:00:00";
            // 
            // _listResultLeft
            // 
            this._listResultLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listResultLeft.FormattingEnabled = true;
            this._listResultLeft.Location = new System.Drawing.Point(4, 3);
            this._listResultLeft.Name = "_listResultLeft";
            this._listResultLeft.ScrollAlwaysVisible = true;
            this._listResultLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this._listResultLeft.Size = new System.Drawing.Size(331, 290);
            this._listResultLeft.TabIndex = 14;
            // 
            // _listResultRight
            // 
            this._listResultRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listResultRight.FormattingEnabled = true;
            this._listResultRight.Location = new System.Drawing.Point(3, 3);
            this._listResultRight.Name = "_listResultRight";
            this._listResultRight.ScrollAlwaysVisible = true;
            this._listResultRight.Size = new System.Drawing.Size(335, 290);
            this._listResultRight.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 448);
            this.Controls.Add(this._labelLoadTimeRight);
            this.Controls.Add(this._labelLoadTimeLeft);
            this.Controls.Add(this._buttonLoadRight);
            this.Controls.Add(this._buttonLoadLeft);
            this.Controls.Add(this._splitContainerResults);
            this.Controls.Add(this._radioOriginals);
            this.Controls.Add(this._radioDuplicates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this._textPathRight);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.buttonBrowse1);
            this.Controls.Add(this._textPathLeft);
            this.Name = "Form1";
            this.Text = "Find unique photos";
            this._splitContainerResults.Panel1.ResumeLayout(false);
            this._splitContainerResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerResults)).EndInit();
            this._splitContainerResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textPathLeft;
        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.TextBox _textPathRight;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton _radioDuplicates;
        private System.Windows.Forms.RadioButton _radioOriginals;
        private System.Windows.Forms.Button _buttonSaveLeft;
        private System.Windows.Forms.Button _buttonSaveRight;
        private System.Windows.Forms.SplitContainer _splitContainerResults;
        private System.Windows.Forms.Button _buttonLoadLeft;
        private System.Windows.Forms.Button _buttonLoadRight;
        private System.Windows.Forms.Button _buttonCopyToRight;
        private System.Windows.Forms.Button _buttonCopyToLeft;
        private System.Windows.Forms.Label _labelLoadTimeLeft;
        private System.Windows.Forms.Label _labelLoadTimeRight;
        private System.Windows.Forms.ListBox _listResultLeft;
        private System.Windows.Forms.ListBox _listResultRight;
    }
}

