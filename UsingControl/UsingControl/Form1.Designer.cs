namespace UsingControl
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.IbIFont = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.grpFont.SuspendLayout();
            this.grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpForm.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.txtSampleText);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Controls.Add(this.IbIFont);
            this.grpFont.Font = new System.Drawing.Font("굴림", 10F);
            this.grpFont.Location = new System.Drawing.Point(38, 29);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(420, 141);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox,CheckBox,TextBox";
            this.grpFont.Enter += new System.EventHandler(this.GrpFont_Enter);
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(19, 84);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(366, 23);
            this.txtSampleText.TabIndex = 4;
            this.txtSampleText.Text = "Hello, C#";
            this.txtSampleText.TextChanged += new System.EventHandler(this.TxtSampleText_TextChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(317, 31);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(68, 18);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이텔릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(237, 33);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(54, 18);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(82, 31);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 21);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.CboFont_SelectedIndexChanged);
            // 
            // IbIFont
            // 
            this.IbIFont.AutoSize = true;
            this.IbIFont.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IbIFont.Location = new System.Drawing.Point(16, 35);
            this.IbIFont.Name = "IbIFont";
            this.IbIFont.Size = new System.Drawing.Size(46, 14);
            this.IbIFont.TabIndex = 0;
            this.IbIFont.Text = "Font :";
            this.IbIFont.Click += new System.EventHandler(this.IbIFont_Click);
            // 
            // grpBar
            // 
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Location = new System.Drawing.Point(38, 176);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(420, 117);
            this.grpBar.TabIndex = 1;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar && ProgressBar";
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(19, 71);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(376, 23);
            this.pgDummy.TabIndex = 3;
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(19, 20);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(376, 45);
            this.tbDummy.TabIndex = 2;
            this.tbDummy.Scroll += new System.EventHandler(this.TbDummy_Scroll);
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnModaless);
            this.grpForm.Controls.Add(this.btnMsgBox);
            this.grpForm.Controls.Add(this.btnModal);
            this.grpForm.Location = new System.Drawing.Point(38, 299);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(420, 71);
            this.grpForm.TabIndex = 4;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Modal && Modaless";
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(121, 20);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(95, 32);
            this.btnModaless.TabIndex = 0;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(222, 20);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(163, 32);
            this.btnMsgBox.TabIndex = 0;
            this.btnMsgBox.Text = "MessageBox";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(19, 20);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(96, 32);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.btnAddChild);
            this.grpTreeList.Controls.Add(this.btnAddRoot);
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Location = new System.Drawing.Point(38, 376);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Size = new System.Drawing.Size(420, 215);
            this.grpTreeList.TabIndex = 5;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "TreeView && ListView";
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(108, 186);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(83, 23);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(19, 186);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(83, 23);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(209, 21);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(176, 154);
            this.lvDummy.TabIndex = 1;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(19, 21);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(184, 154);
            this.tvDummy.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 619);
            this.Controls.Add(this.grpTreeList);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.grpBar);
            this.Controls.Add(this.grpFont);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Name = "MainForm";
            this.Text = "Control Text";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpForm.ResumeLayout(false);
            this.grpTreeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label IbIFont;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.GroupBox grpTreeList;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
    }
}

