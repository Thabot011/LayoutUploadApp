namespace LayoutUploadApp
{
    partial class UploadLayoutFrom
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
            components = new System.ComponentModel.Container();
            UploadLayoutCard = new ReaLTaiizor.Controls.MaterialCard();
            UploadLayoutProgress = new ProgressBar();
            UploadBtn = new ReaLTaiizor.Controls.Button();
            UploadTemplateBtn = new ReaLTaiizor.Controls.MaterialButton();
            DownloadTemplateBtn = new ReaLTaiizor.Controls.MaterialButton();
            LayoutFolderTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            BuildingnameDDl = new ReaLTaiizor.Controls.MaterialComboBox();
            ProjectNameDDL = new ReaLTaiizor.Controls.MaterialComboBox();
            LayoutUploadErrorProvider = new ErrorProvider(components);
            UploadHintLabel = new ReaLTaiizor.Controls.MaterialLabel();
            UploadLayoutCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LayoutUploadErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // UploadLayoutCard
            // 
            UploadLayoutCard.BackColor = Color.FromArgb(255, 255, 255);
            UploadLayoutCard.Controls.Add(UploadHintLabel);
            UploadLayoutCard.Controls.Add(UploadLayoutProgress);
            UploadLayoutCard.Controls.Add(UploadBtn);
            UploadLayoutCard.Controls.Add(UploadTemplateBtn);
            UploadLayoutCard.Controls.Add(DownloadTemplateBtn);
            UploadLayoutCard.Controls.Add(LayoutFolderTxt);
            UploadLayoutCard.Controls.Add(BuildingnameDDl);
            UploadLayoutCard.Controls.Add(ProjectNameDDL);
            UploadLayoutCard.Depth = 0;
            UploadLayoutCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            UploadLayoutCard.Location = new Point(23, 23);
            UploadLayoutCard.Margin = new Padding(14);
            UploadLayoutCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            UploadLayoutCard.Name = "UploadLayoutCard";
            UploadLayoutCard.Padding = new Padding(14);
            UploadLayoutCard.Size = new Size(994, 664);
            UploadLayoutCard.TabIndex = 0;
            // 
            // UploadLayoutProgress
            // 
            UploadLayoutProgress.Location = new Point(132, 526);
            UploadLayoutProgress.Name = "UploadLayoutProgress";
            UploadLayoutProgress.Size = new Size(497, 47);
            UploadLayoutProgress.Style = ProgressBarStyle.Marquee;
            UploadLayoutProgress.TabIndex = 8;
            UploadLayoutProgress.Visible = false;
            // 
            // UploadBtn
            // 
            UploadBtn.BackColor = Color.FromArgb(128, 255, 128);
            UploadBtn.BorderColor = Color.FromArgb(32, 34, 37);
            UploadBtn.Enabled = false;
            UploadBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            UploadBtn.EnteredColor = Color.Lime;
            UploadBtn.Font = new Font("Microsoft Sans Serif", 12F);
            UploadBtn.Image = null;
            UploadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UploadBtn.InactiveColor = Color.Lime;
            UploadBtn.Location = new Point(295, 417);
            UploadBtn.Name = "UploadBtn";
            UploadBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            UploadBtn.PressedColor = Color.FromArgb(165, 37, 37);
            UploadBtn.Size = new Size(150, 50);
            UploadBtn.TabIndex = 7;
            UploadBtn.Text = "Upload";
            UploadBtn.TextAlignment = StringAlignment.Center;
            UploadBtn.Click += UploadBtn_Click;
            // 
            // UploadTemplateBtn
            // 
            UploadTemplateBtn.AutoSize = false;
            UploadTemplateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UploadTemplateBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            UploadTemplateBtn.Depth = 0;
            UploadTemplateBtn.Enabled = false;
            UploadTemplateBtn.HighEmphasis = true;
            UploadTemplateBtn.Icon = null;
            UploadTemplateBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            UploadTemplateBtn.Location = new Point(132, 332);
            UploadTemplateBtn.Margin = new Padding(4, 6, 4, 6);
            UploadTemplateBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            UploadTemplateBtn.Name = "UploadTemplateBtn";
            UploadTemplateBtn.NoAccentTextColor = Color.Empty;
            UploadTemplateBtn.Size = new Size(167, 45);
            UploadTemplateBtn.TabIndex = 6;
            UploadTemplateBtn.Text = "Upload Template";
            UploadTemplateBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            UploadTemplateBtn.UseAccentColor = false;
            UploadTemplateBtn.UseVisualStyleBackColor = true;
            UploadTemplateBtn.Click += UploadTemplateBtn_Click;
            // 
            // DownloadTemplateBtn
            // 
            DownloadTemplateBtn.AutoSize = false;
            DownloadTemplateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DownloadTemplateBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            DownloadTemplateBtn.Depth = 0;
            DownloadTemplateBtn.Enabled = false;
            DownloadTemplateBtn.HighEmphasis = true;
            DownloadTemplateBtn.Icon = null;
            DownloadTemplateBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            DownloadTemplateBtn.Location = new Point(422, 170);
            DownloadTemplateBtn.Margin = new Padding(4, 6, 4, 6);
            DownloadTemplateBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DownloadTemplateBtn.Name = "DownloadTemplateBtn";
            DownloadTemplateBtn.NoAccentTextColor = Color.Empty;
            DownloadTemplateBtn.Size = new Size(167, 45);
            DownloadTemplateBtn.TabIndex = 5;
            DownloadTemplateBtn.Text = "Download template";
            DownloadTemplateBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            DownloadTemplateBtn.UseAccentColor = false;
            DownloadTemplateBtn.UseVisualStyleBackColor = true;
            DownloadTemplateBtn.Click += DownloadTemplateBtn_Click;
            // 
            // LayoutFolderTxt
            // 
            LayoutFolderTxt.AllowPromptAsInput = true;
            LayoutFolderTxt.AnimateReadOnly = false;
            LayoutFolderTxt.AsciiOnly = false;
            LayoutFolderTxt.BackgroundImageLayout = ImageLayout.None;
            LayoutFolderTxt.BeepOnError = false;
            LayoutFolderTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            LayoutFolderTxt.Depth = 0;
            LayoutFolderTxt.Enabled = false;
            LayoutFolderTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LayoutFolderTxt.HidePromptOnLeave = false;
            LayoutFolderTxt.HideSelection = true;
            LayoutFolderTxt.Hint = "Layout Folder Path";
            LayoutFolderTxt.InsertKeyMode = InsertKeyMode.Default;
            LayoutFolderTxt.LeadingIcon = null;
            LayoutFolderTxt.Location = new Point(132, 245);
            LayoutFolderTxt.Mask = "";
            LayoutFolderTxt.MaxLength = 32767;
            LayoutFolderTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            LayoutFolderTxt.Name = "LayoutFolderTxt";
            LayoutFolderTxt.PasswordChar = '\0';
            LayoutFolderTxt.PrefixSuffixText = null;
            LayoutFolderTxt.PromptChar = '_';
            LayoutFolderTxt.ReadOnly = false;
            LayoutFolderTxt.RejectInputOnFirstFailure = false;
            LayoutFolderTxt.ResetOnPrompt = true;
            LayoutFolderTxt.ResetOnSpace = true;
            LayoutFolderTxt.RightToLeft = RightToLeft.No;
            LayoutFolderTxt.SelectedText = "";
            LayoutFolderTxt.SelectionLength = 0;
            LayoutFolderTxt.SelectionStart = 0;
            LayoutFolderTxt.ShortcutsEnabled = true;
            LayoutFolderTxt.Size = new Size(457, 48);
            LayoutFolderTxt.SkipLiterals = true;
            LayoutFolderTxt.TabIndex = 4;
            LayoutFolderTxt.TabStop = false;
            LayoutFolderTxt.TextAlign = HorizontalAlignment.Left;
            LayoutFolderTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            LayoutFolderTxt.TrailingIcon = null;
            LayoutFolderTxt.UseSystemPasswordChar = false;
            LayoutFolderTxt.ValidatingType = null;
            // 
            // BuildingnameDDl
            // 
            BuildingnameDDl.AutoResize = false;
            BuildingnameDDl.BackColor = Color.FromArgb(255, 255, 255);
            BuildingnameDDl.Depth = 0;
            BuildingnameDDl.DisplayMember = "Name";
            BuildingnameDDl.DrawMode = DrawMode.OwnerDrawVariable;
            BuildingnameDDl.DropDownHeight = 174;
            BuildingnameDDl.DropDownStyle = ComboBoxStyle.DropDownList;
            BuildingnameDDl.DropDownWidth = 121;
            BuildingnameDDl.Enabled = false;
            BuildingnameDDl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            BuildingnameDDl.ForeColor = Color.FromArgb(222, 0, 0, 0);
            BuildingnameDDl.FormattingEnabled = true;
            BuildingnameDDl.Hint = "Buiding Name";
            BuildingnameDDl.IntegralHeight = false;
            BuildingnameDDl.ItemHeight = 43;
            BuildingnameDDl.Location = new Point(132, 166);
            BuildingnameDDl.MaxDropDownItems = 4;
            BuildingnameDDl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            BuildingnameDDl.Name = "BuildingnameDDl";
            BuildingnameDDl.Size = new Size(250, 49);
            BuildingnameDDl.StartIndex = 0;
            BuildingnameDDl.TabIndex = 2;
            BuildingnameDDl.ValueMember = "Id";
            BuildingnameDDl.SelectedIndexChanged += BuildingnameDDl_SelectedIndexChanged;
            // 
            // ProjectNameDDL
            // 
            ProjectNameDDL.AutoResize = false;
            ProjectNameDDL.BackColor = Color.FromArgb(255, 255, 255);
            ProjectNameDDL.Depth = 0;
            ProjectNameDDL.DisplayMember = "Name";
            ProjectNameDDL.DrawMode = DrawMode.OwnerDrawVariable;
            ProjectNameDDL.DropDownHeight = 174;
            ProjectNameDDL.DropDownStyle = ComboBoxStyle.DropDownList;
            ProjectNameDDL.DropDownWidth = 121;
            ProjectNameDDL.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ProjectNameDDL.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ProjectNameDDL.FormattingEnabled = true;
            ProjectNameDDL.Hint = "Project Name";
            ProjectNameDDL.IntegralHeight = false;
            ProjectNameDDL.ItemHeight = 43;
            ProjectNameDDL.Location = new Point(132, 65);
            ProjectNameDDL.MaxDropDownItems = 4;
            ProjectNameDDL.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ProjectNameDDL.Name = "ProjectNameDDL";
            ProjectNameDDL.Size = new Size(457, 49);
            ProjectNameDDL.StartIndex = 0;
            ProjectNameDDL.TabIndex = 1;
            ProjectNameDDL.ValueMember = "Id";
            ProjectNameDDL.SelectedIndexChanged += ProjectNameDDL_SelectedIndexChanged;
            // 
            // LayoutUploadErrorProvider
            // 
            LayoutUploadErrorProvider.ContainerControl = this;
            // 
            // UploadHintLabel
            // 
            UploadHintLabel.AutoSize = true;
            UploadHintLabel.Depth = 0;
            UploadHintLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            UploadHintLabel.Location = new Point(595, 260);
            UploadHintLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            UploadHintLabel.Name = "UploadHintLabel";
            UploadHintLabel.Size = new Size(200, 19);
            UploadHintLabel.TabIndex = 9;
            UploadHintLabel.Text = "Max 500kb size for each file";
            // 
            // UploadLayoutFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1776, 700);
            Controls.Add(UploadLayoutCard);
            Name = "UploadLayoutFrom";
            Text = "UploadLayoutFrom";
            UploadLayoutCard.ResumeLayout(false);
            UploadLayoutCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LayoutUploadErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard UploadLayoutCard;
        private ReaLTaiizor.Controls.MaterialComboBox BuildingnameDDl;
        private ReaLTaiizor.Controls.MaterialComboBox ProjectNameDDL;
        private ReaLTaiizor.Controls.MaterialButton DownloadTemplateBtn;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox LayoutFolderTxt;
        private ReaLTaiizor.Controls.MaterialButton UploadTemplateBtn;
        private ReaLTaiizor.Controls.Button UploadBtn;
        private ErrorProvider LayoutUploadErrorProvider;
        private ProgressBar UploadLayoutProgress;
        private ReaLTaiizor.Controls.MaterialLabel UploadHintLabel;
    }
}