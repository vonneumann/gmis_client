using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace SWDialogBox
{
	/// <summary>
	/// FMessageBox ��ժҪ˵����
	/// </summary>
	internal class FMessageBox : System.Windows.Forms.Form
	{
		private const Int32  ICONMASKWORD		=	0xE0;
		private const Int32  BUTTONMASKWORD		=	0x0F;

		private const String CAPTIONSUFFIX		=	"Caption";
		private const String MESSAGESUFFIX		=	"Message";
		private const String DESCRIPTIONSUFFIX	=	"Description";

		private const String CriticalFLAG		=	"*";
		private const String QuestionFLAG		=	"?";
		private const String InformationFLAG	=	"$";
		private const String ExclamationFLAG	=	"!";

		private const String OKBUTTON			=	"OK";
		private const String CANCELBUTTON		=	"Cancel";
		private const String RETRYBUTTON		=	"Retry";
		private const String YESBUTTON			=	"Yes";
		private const String NOBUTTON			=	"No";
		private const String DETAILBUTTON		=	"Detail";

		private const String URLLABEL			=	"URLLabel";
		private const String URL				=	"URL";
		private const String EMAILLABEL			=	"EMailLabel";
		private const String EMAIL				=	"EMail";
		

		private System.Windows.Forms.Label MessageIcon;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnDetail;
		private System.Windows.Forms.LinkLabel lnkURL;
		private System.Windows.Forms.LinkLabel lnkEMail;
		private System.Windows.Forms.TextBox txtDescription;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FMessageBox()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			if(this.ParentForm == null)
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			else
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.MessageIcon = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnDetail = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lnkURL = new System.Windows.Forms.LinkLabel();
			this.lnkEMail = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// MessageIcon
			// 
			this.MessageIcon.Location = new System.Drawing.Point(16, 16);
			this.MessageIcon.Name = "MessageIcon";
			this.MessageIcon.Size = new System.Drawing.Size(32, 32);
			this.MessageIcon.TabIndex = 0;
			this.MessageIcon.UseMnemonic = false;
			this.MessageIcon.DoubleClick += new System.EventHandler(this.MessageIcon_DoubleClick);
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
			this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblMessage.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblMessage.Location = new System.Drawing.Point(64, 24);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(392, 24);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.UseMnemonic = false;
			// 
			// btnDetail
			// 
			this.btnDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDetail.Location = new System.Drawing.Point(329, 80);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(80, 24);
			this.btnDetail.TabIndex = 5;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
			this.txtDescription.Location = new System.Drawing.Point(16, 144);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(440, 96);
			this.txtDescription.TabIndex = 6;
			this.txtDescription.TabStop = false;
			this.txtDescription.Text = "";
			this.txtDescription.Visible = false;
			// 
			// lnkURL
			// 
			this.lnkURL.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.lnkURL.BackColor = System.Drawing.SystemColors.Control;
			this.lnkURL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lnkURL.Location = new System.Drawing.Point(16, 248);
			this.lnkURL.Name = "lnkURL";
			this.lnkURL.Size = new System.Drawing.Size(440, 18);
			this.lnkURL.TabIndex = 8;
			this.lnkURL.TabStop = true;
			this.lnkURL.Text = "http://www.iLOOK100.net";
			this.lnkURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lnkURL.UseMnemonic = false;
			this.lnkURL.Visible = false;
			this.lnkURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
			// 
			// lnkEMail
			// 
			this.lnkEMail.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.lnkEMail.BackColor = System.Drawing.SystemColors.Control;
			this.lnkEMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lnkEMail.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
			this.lnkEMail.Location = new System.Drawing.Point(16, 268);
			this.lnkEMail.Name = "lnkEMail";
			this.lnkEMail.Size = new System.Drawing.Size(440, 18);
			this.lnkEMail.TabIndex = 10;
			this.lnkEMail.TabStop = true;
			this.lnkEMail.Text = "Support@iLOOK100.net";
			this.lnkEMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lnkEMail.UseMnemonic = false;
			this.lnkEMail.Visible = false;
			this.lnkEMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
			// 
			// FMessageBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(474, 295);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnDetail,
																		  this.lnkEMail,
																		  this.lnkURL,
																		  this.txtDescription,
																		  this.lblMessage,
																		  this.MessageIcon});
			this.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FMessageBox";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FMessageBox_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMessageBox_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		private void LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				String url = ((System.Windows.Forms.LinkLabel)sender).Text.Substring(e.Link.Start, e.Link.Length);

				if(sender == this.lnkEMail)
					url = "mailto:" + url;

				System.Diagnostics.Process.Start(url);
				e.Link.Visited = true;
			}
			catch
			{
				e.Link.Visited = false;
			}
		}

		private void MessageIcon_DoubleClick(object sender, System.EventArgs e)
		{
			try
			{
				if((Control.ModifierKeys & Keys.Control) == Keys.Control)
				{
					System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
					this.MessageIcon.Image = (System.Drawing.Bitmap)rm.GetObject("BITMAP-EasterEgg");
				}
			}
			catch{}
		}

		private void btnDetail_Click(object sender, System.EventArgs e)
		{
			txtDescription.Visible = !txtDescription.Visible;
			lnkURL.Visible = txtDescription.Visible;
			lnkEMail.Visible = txtDescription.Visible;

			if(txtDescription.Visible)
				this.Height += 168;
			else
				this.Height -= 168;

			this.Refresh();
		}

		private void FMessageBox_Load(object sender, System.EventArgs e)
		{
			try
			{
				if(this.AcceptButton != null)
					this.ActiveControl = (System.Windows.Forms.Control)this.AcceptButton;

				System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
				String urlLabel, urlValue;

				urlLabel = rm.GetString(URLLABEL);
				urlValue = rm.GetString(URL);

				lnkURL.Text = urlLabel + urlValue;
				lnkURL.LinkArea = new System.Windows.Forms.LinkArea(urlLabel.Length, urlValue.Length);

				urlLabel = rm.GetString(EMAILLABEL);
				urlValue = rm.GetString(EMAIL);

				lnkEMail.Text = urlLabel + urlValue;
				lnkEMail.LinkArea = new System.Windows.Forms.LinkArea(urlLabel.Length, urlValue.Length);
			}
			catch
			{
			}
		}

		private void FMessageBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(txtDescription.Visible)
			{
				e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.DimGray), txtDescription.Left, txtDescription.Top - 12, txtDescription.Left + txtDescription.Width, txtDescription.Top - 12);
				e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.White),   txtDescription.Left, txtDescription.Top - 11, txtDescription.Left + txtDescription.Width, txtDescription.Top - 11);
			}
		}

		internal System.Windows.Forms.DialogResult ShowDialog(String messageID)
		{
			return this.ShowDialog(messageID, null);
		}

		internal System.Windows.Forms.DialogResult ShowDialog(String messageID, params Object[] args)
		{
			try
			{
				SWDialogBox.MessageBoxIcon iconStyle = SWDialogBox.MessageBoxIcon.None;
				SWDialogBox.MessageBoxButton buttonStyle;
				System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);

				try
				{
					//����Դ���л�ȡָ����Ϣ��ŵ���Ϣ��������
					//���ָ������Ϣ�������Դ����û����������һ����Ч����Ϣ�����򲶻����쳣��
					iconStyle = (SWDialogBox.MessageBoxIcon)Int32.Parse(rm.GetString(messageID));
					buttonStyle = (SWDialogBox.MessageBoxButton)Int32.Parse(rm.GetString(messageID));
				}
				catch
				{
					//����ָ����Ϣ�����������Ϣ��ķ������
					switch(messageID.Substring(0, 1))
					{
						case CriticalFLAG:
							iconStyle = SWDialogBox.MessageBoxIcon.Critical;
							buttonStyle = SWDialogBox.MessageBoxButton.OK | SWDialogBox.MessageBoxButton.Detail;
							break;
						case QuestionFLAG:
							iconStyle = SWDialogBox.MessageBoxIcon.Question;
							buttonStyle = SWDialogBox.MessageBoxButton.YesNo | SWDialogBox.MessageBoxButton.Detail;
							break;
						case ExclamationFLAG:
							iconStyle = SWDialogBox.MessageBoxIcon.Exclamation;
							buttonStyle = SWDialogBox.MessageBoxButton.OK | SWDialogBox.MessageBoxButton.Detail;
							break;
						case InformationFLAG:
							iconStyle = SWDialogBox.MessageBoxIcon.Information;
							buttonStyle = SWDialogBox.MessageBoxButton.OK | SWDialogBox.MessageBoxButton.Detail;
							break;
						default:
							iconStyle = SWDialogBox.MessageBoxIcon.Information;
							buttonStyle = SWDialogBox.MessageBoxButton.OK | SWDialogBox.MessageBoxButton.Detail;
							break;
					}
				}

				if(messageID == "*999")
				{
					if(args == null)
						WriteLog(rm.GetString(messageID + CAPTIONSUFFIX),
										   rm.GetString(messageID + DESCRIPTIONSUFFIX));
					else
						WriteLog(String.Format(rm.GetString(messageID + CAPTIONSUFFIX), args),
										   String.Format(rm.GetString(messageID + DESCRIPTIONSUFFIX), args));
				}

				//����Դ���ж�ȡָ����Ϣ��ŵ��ı�����
				if(args == null)
					return this.ShowDialog(rm.GetString(messageID + MESSAGESUFFIX),
										   rm.GetString(messageID + CAPTIONSUFFIX),
										   rm.GetString(messageID + DESCRIPTIONSUFFIX),
										   buttonStyle, iconStyle);
				else
					return this.ShowDialog(String.Format(rm.GetString(messageID + MESSAGESUFFIX), args),
										   String.Format(rm.GetString(messageID + CAPTIONSUFFIX), args),
										   String.Format(rm.GetString(messageID + DESCRIPTIONSUFFIX), args),
										   buttonStyle, iconStyle);
			}
			catch
			{
				throw;
			}
		}

		internal System.Windows.Forms.DialogResult ShowDialog(String message, String caption, String description, SWDialogBox.MessageBoxButton button, SWDialogBox.MessageBoxIcon icon)
		{
			try
			{
				String iconKey = null;
				System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);

				//���ݵ�ǰ����Ϣ��ŵõ����Ӧ����Ϣ���ͣ�������Ϣ��ͼ�����ͣ�
				switch((icon & (SWDialogBox.MessageBoxIcon)ICONMASKWORD))
				{
					case SWDialogBox.MessageBoxIcon.Critical:
						iconKey = "ICON-Critical";
						break;
					case SWDialogBox.MessageBoxIcon.Question:
						iconKey = "ICON-Question";
						break;
					case SWDialogBox.MessageBoxIcon.Exclamation:
						iconKey = "ICON-Exclamation";
						break;
					case SWDialogBox.MessageBoxIcon.Information:
						iconKey = "ICON-Information";
						break;
				}

				//װ����Ϣ��ָʾͼ��
				if(iconKey != null && iconKey != String.Empty)
					this.MessageIcon.Image = ((System.Drawing.Icon)rm.GetObject(iconKey)).ToBitmap();

				//װ����Ϣ����ͼ��
//				if(this.Icon != null)
//					this.Icon = (System.Drawing.Icon)rm.GetObject("ICON-App");

				//������Ϣ���и�����Ϣ�ı�
				this.Text = caption;
				lblMessage.Text = message;
				txtDescription.Text = description;

				//�õ���Ϣ�ı����Graphics����
				Graphics g = lblMessage.CreateGraphics();

				//�õ�����ʾ����Ϣ�ı�����ʾ����/��С
				SizeF messageSize = new SizeF();
				messageSize = g.MeasureString(lblMessage.Text, lblMessage.Font, lblMessage.Width);

				//������Ϣ�ı���ĸ߶�
				lblMessage.Height = (Int32)messageSize.Height;
				//���ð�ť��λ��
				btnDetail.Top = lblMessage.Top + lblMessage.Height + 32;
				//������Ϣ����ĸ߶�
				this.ClientSize = new System.Drawing.Size(this.ClientSize.Width,
														  btnDetail.Top + btnDetail.Height + 16);

				//������Ϣ��İ�ť���Ű���Ϣ�������
				this.CreateButton(button);

				//��ģʽ�Ի���
				return this.ShowDialog();
			}
			catch
			{
				throw;
			}
		}

		private void CreateButton(SWDialogBox.MessageBoxButton buttonStyle)
		{
			System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
			System.Collections.ArrayList buttonList = new System.Collections.ArrayList(6);

			//�ж��Ƿ���Ҫ���á�ȷ��(OK)����ť
			if((buttonStyle & (SWDialogBox.MessageBoxButton)BUTTONMASKWORD) == SWDialogBox.MessageBoxButton.OK ||
			   (buttonStyle & SWDialogBox.MessageBoxButton.OKCancel) == SWDialogBox.MessageBoxButton.OKCancel)
			{
				System.Windows.Forms.Button btnOK = new System.Windows.Forms.Button();

				btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
				btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
				btnOK.Location = new System.Drawing.Point(-100, this.btnDetail.Top);
				btnOK.Name = "btnOK";
				btnOK.Size = new System.Drawing.Size(80, 24);
				btnOK.Text = rm.GetString(OKBUTTON);

				buttonList.Add(btnOK);
				this.Controls.Add(btnOK);
			}

			//�ж��Ƿ���Ҫ���á�����(Retry)����ť
			if((buttonStyle & SWDialogBox.MessageBoxButton.RetryCancel) == SWDialogBox.MessageBoxButton.RetryCancel)
			{
				System.Windows.Forms.Button btnRetry = new System.Windows.Forms.Button();

				btnRetry.Anchor = System.Windows.Forms.AnchorStyles.Top;
				btnRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
				btnRetry.Location = new System.Drawing.Point(-100, this.btnDetail.Top);
				btnRetry.Name = "btnRetry";
				btnRetry.Size = new System.Drawing.Size(80, 24);
				btnRetry.Text = rm.GetString(RETRYBUTTON);

				buttonList.Add(btnRetry);
				this.Controls.Add(btnRetry);
			}

			//�ж��Ƿ���Ҫ���á���(Yes)���͡���(No)����ť
			if((buttonStyle & SWDialogBox.MessageBoxButton.YesNo) == SWDialogBox.MessageBoxButton.YesNo ||
			   (buttonStyle & SWDialogBox.MessageBoxButton.YesNoCancel) == SWDialogBox.MessageBoxButton.YesNoCancel)
			{
				System.Windows.Forms.Button btnYes = new System.Windows.Forms.Button();
				System.Windows.Forms.Button btnNo = new System.Windows.Forms.Button();

				btnYes.Anchor = System.Windows.Forms.AnchorStyles.Top;
				btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
				btnYes.Location = new System.Drawing.Point(-100, this.btnDetail.Top);
				btnYes.Name = "btnYes";
				btnYes.Size = new System.Drawing.Size(80, 24);
				btnYes.Text = rm.GetString(YESBUTTON);

				btnNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
				btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
				btnNo.Location = new System.Drawing.Point(-100, this.btnDetail.Top);
				btnNo.Name = "btnNo";
				btnNo.Size = new System.Drawing.Size(80, 24);
				btnNo.Text = rm.GetString(NOBUTTON);

				buttonList.Add(btnYes);
				this.Controls.Add(btnYes);

				buttonList.Add(btnNo);
				this.Controls.Add(btnNo);
			}

			//�ж��Ƿ���Ҫ���á�ȡ��(Cancel)����ť
			if((buttonStyle & SWDialogBox.MessageBoxButton.OKCancel) == SWDialogBox.MessageBoxButton.OKCancel ||
			   (buttonStyle & SWDialogBox.MessageBoxButton.RetryCancel) == SWDialogBox.MessageBoxButton.RetryCancel ||
			   (buttonStyle & SWDialogBox.MessageBoxButton.YesNoCancel) == SWDialogBox.MessageBoxButton.YesNoCancel)
			{
				System.Windows.Forms.Button btnCancel = new System.Windows.Forms.Button();

				btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
				btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
				btnCancel.Location = new System.Drawing.Point(-100, this.btnDetail.Top);
				btnCancel.Name = "btnCancel";
				btnCancel.Size = new System.Drawing.Size(80, 24);
				btnCancel.Text = rm.GetString(CANCELBUTTON);

				buttonList.Add(btnCancel);
				this.Controls.Add(btnCancel);
			}

			//���á���ϸ(Detail)����ť����ʾ״̬
			btnDetail.Visible = (buttonStyle & SWDialogBox.MessageBoxButton.Detail) == SWDialogBox.MessageBoxButton.Detail;
			if((buttonStyle & SWDialogBox.MessageBoxButton.Detail) == SWDialogBox.MessageBoxButton.Detail)
			{
				btnDetail.Text = rm.GetString(DETAILBUTTON);
				buttonList.Add(btnDetail);
			}

			//������Ϣ���Ĭ�ϰ�ť����һ����ť��
			if(buttonList.Count >= 1)
				this.AcceptButton = (System.Windows.Forms.Button)buttonList[0];

			//������Ϣ���Ĭ�ϰ�ť���ڶ�����ť��
			if((buttonStyle & SWDialogBox.MessageBoxButton.DefaultButton2) == SWDialogBox.MessageBoxButton.DefaultButton2 && buttonList.Count >= 2)
				this.AcceptButton = (System.Windows.Forms.Button)buttonList[1];

			//������Ϣ���Ĭ�ϰ�ť����������ť��
			if((buttonStyle & SWDialogBox.MessageBoxButton.DefaultButton3) == SWDialogBox.MessageBoxButton.DefaultButton3 && buttonList.Count >= 3)
				this.AcceptButton = (System.Windows.Forms.Button)buttonList[2];

			//ѭ������ÿ����ť����߽�λ��
			for(int i=0; i<buttonList.Count; i++)
			{
				//��������ÿ����ť��TabIndex����
				((System.Windows.Forms.Button)buttonList[i]).TabIndex = 2 + i;

				if(i==0)
					((System.Windows.Forms.Button)buttonList[i]).Left = (this.ClientSize.Width - (80 * buttonList.Count + 8 * (buttonList.Count - 1))) / 2;
				else
					((System.Windows.Forms.Button)buttonList[i]).Left = ((System.Windows.Forms.Button)buttonList[i-1]).Left + ((System.Windows.Forms.Button)buttonList[i-1]).Width + 8;
			}
		}
	
		
		/*	Modified by LQF on 2005-12-03������д��־���� */
		private void WriteLog(String caption, String description)
		{		
		    using (StreamWriter sw = new StreamWriter("errorLog.txt",true))
				{
					// Add some text to the file.
					sw.WriteLine("{0}",DateTime.Now.ToString());				
					sw.WriteLine("{0}",caption);
					sw.WriteLine("{0}",description);								
					sw.WriteLine("----------------------");
				
				}					
		}	
		
	}
}
