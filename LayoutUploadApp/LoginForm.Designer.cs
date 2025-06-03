namespace LayoutUploadApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LoginCard = new ReaLTaiizor.Controls.MaterialCard();
            LoginProgress = new ProgressBar();
            UserNameTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            LoginBtn = new ReaLTaiizor.Controls.MaterialButton();
            PasswordTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            LoginErrorProvider = new ErrorProvider(components);
            LoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // LoginCard
            // 
            LoginCard.BackColor = Color.FromArgb(255, 255, 255);
            LoginCard.Controls.Add(LoginProgress);
            LoginCard.Controls.Add(UserNameTxt);
            LoginCard.Controls.Add(LoginBtn);
            LoginCard.Controls.Add(PasswordTxt);
            LoginCard.Depth = 0;
            LoginCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            LoginCard.Location = new Point(3, 5);
            LoginCard.Margin = new Padding(14);
            LoginCard.MinimumSize = new Size(126, 50);
            LoginCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LoginCard.Name = "LoginCard";
            LoginCard.Padding = new Padding(14);
            LoginCard.Size = new Size(881, 724);
            LoginCard.TabIndex = 3;
            // 
            // LoginProgress
            // 
            LoginProgress.Location = new Point(218, 444);
            LoginProgress.Name = "LoginProgress";
            LoginProgress.Size = new Size(497, 47);
            LoginProgress.Style = ProgressBarStyle.Marquee;
            LoginProgress.TabIndex = 3;
            LoginProgress.Visible = false;
            // 
            // UserNameTxt
            // 
            UserNameTxt.AllowPromptAsInput = true;
            UserNameTxt.Anchor = AnchorStyles.None;
            UserNameTxt.AnimateReadOnly = false;
            UserNameTxt.AsciiOnly = false;
            UserNameTxt.BackgroundImageLayout = ImageLayout.None;
            UserNameTxt.BeepOnError = false;
            UserNameTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            UserNameTxt.Depth = 0;
            UserNameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserNameTxt.HelperText = "User Name";
            UserNameTxt.HidePromptOnLeave = false;
            UserNameTxt.HideSelection = true;
            UserNameTxt.Hint = "User Name";
            UserNameTxt.InsertKeyMode = InsertKeyMode.Default;
            UserNameTxt.LeadingIcon = null;
            UserNameTxt.Location = new Point(296, 77);
            UserNameTxt.Mask = "";
            UserNameTxt.MaxLength = 32767;
            UserNameTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.PasswordChar = '\0';
            UserNameTxt.PrefixSuffixText = null;
            UserNameTxt.PromptChar = '_';
            UserNameTxt.ReadOnly = false;
            UserNameTxt.RejectInputOnFirstFailure = false;
            UserNameTxt.ResetOnPrompt = true;
            UserNameTxt.ResetOnSpace = true;
            UserNameTxt.RightToLeft = RightToLeft.No;
            UserNameTxt.SelectedText = "";
            UserNameTxt.SelectionLength = 0;
            UserNameTxt.SelectionStart = 0;
            UserNameTxt.ShortcutsEnabled = true;
            UserNameTxt.Size = new Size(312, 48);
            UserNameTxt.SkipLiterals = true;
            UserNameTxt.TabIndex = 0;
            UserNameTxt.TabStop = false;
            UserNameTxt.TextAlign = HorizontalAlignment.Left;
            UserNameTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            UserNameTxt.TrailingIcon = null;
            UserNameTxt.UseSystemPasswordChar = false;
            UserNameTxt.ValidatingType = null;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.AutoSize = false;
            LoginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginBtn.Depth = 0;
            LoginBtn.HighEmphasis = true;
            LoginBtn.Icon = null;
            LoginBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            LoginBtn.Location = new Point(385, 314);
            LoginBtn.Margin = new Padding(4, 6, 4, 6);
            LoginBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LoginBtn.Name = "LoginBtn";
            LoginBtn.NoAccentTextColor = Color.Empty;
            LoginBtn.Size = new Size(156, 64);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginBtn.UseAccentColor = false;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_ClickAsync;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AllowPromptAsInput = true;
            PasswordTxt.Anchor = AnchorStyles.None;
            PasswordTxt.AnimateReadOnly = false;
            PasswordTxt.AsciiOnly = false;
            PasswordTxt.BackgroundImageLayout = ImageLayout.None;
            PasswordTxt.BeepOnError = false;
            PasswordTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            PasswordTxt.Depth = 0;
            PasswordTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTxt.HelperText = "Password";
            PasswordTxt.HidePromptOnLeave = false;
            PasswordTxt.HideSelection = true;
            PasswordTxt.Hint = "Password";
            PasswordTxt.InsertKeyMode = InsertKeyMode.Default;
            PasswordTxt.LeadingIcon = null;
            PasswordTxt.Location = new Point(296, 204);
            PasswordTxt.Mask = "";
            PasswordTxt.MaxLength = 32767;
            PasswordTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PrefixSuffixText = "Password";
            PasswordTxt.PromptChar = '_';
            PasswordTxt.ReadOnly = false;
            PasswordTxt.RejectInputOnFirstFailure = false;
            PasswordTxt.ResetOnPrompt = true;
            PasswordTxt.ResetOnSpace = true;
            PasswordTxt.RightToLeft = RightToLeft.No;
            PasswordTxt.SelectedText = "";
            PasswordTxt.SelectionLength = 0;
            PasswordTxt.SelectionStart = 0;
            PasswordTxt.ShortcutsEnabled = true;
            PasswordTxt.Size = new Size(312, 48);
            PasswordTxt.SkipLiterals = true;
            PasswordTxt.TabIndex = 1;
            PasswordTxt.TabStop = false;
            PasswordTxt.TextAlign = HorizontalAlignment.Left;
            PasswordTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            PasswordTxt.TrailingIcon = null;
            PasswordTxt.UseSystemPasswordChar = false;
            PasswordTxt.ValidatingType = null;
            // 
            // LoginErrorProvider
            // 
            LoginErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1776, 739);
            Controls.Add(LoginCard);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoginErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard LoginCard;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox UserNameTxt;
        private ReaLTaiizor.Controls.MaterialButton LoginBtn;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox PasswordTxt;
        private ErrorProvider LoginErrorProvider;
        private ProgressBar LoginProgress;
    }
}
