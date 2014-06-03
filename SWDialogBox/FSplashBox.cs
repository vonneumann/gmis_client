using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SWDialogBox
{
	/// <summary>
	/// FSplash ��ժҪ˵����
	/// </summary>
	internal class FSplashBox : System.Windows.Forms.Form
	{
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		private System.Drawing.Font _informationFont;
		private System.Drawing.Color _informationColor;

		public String OwnerName;
		public String Organization;
		public String ProductID;
		public String Information;
		public System.Drawing.Rectangle AccreditRectangle;
		public System.Drawing.Rectangle InformationRectangle;

		//������Ϣ������������Դ����Դ�������
		private System.Resources.ResourceManager _ownerResource;

		public FSplashBox()
		{
			//Windows ���������֧���������
			InitializeComponent();

			this.OwnerName = String.Empty;
			this.Information = String.Empty;
			this.Organization = Application.CompanyName;
			this.ProductID = Application.ProductName;
			this.AccreditRectangle = new System.Drawing.Rectangle(100, 110, 250, 60);
			this.InformationRectangle = new System.Drawing.Rectangle(100, 185, 250, 20);

			_informationFont = this.Font;
			_informationColor = this.ForeColor;

			//������Ϣ������������Դ����Դ�������
			_ownerResource = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				if(components != null)
				{
					components.Dispose();
				}
			}

			//�ͷ�������Դ
			_ownerResource.ReleaseAllResources();
			//�ͷŻ����е���Դ
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FSplashBox));
			// 
			// FSplashBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(398, 243);
			this.ControlBox = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FSplashBox";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.FSplashBox_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FSplashBox_Paint);

		}
		#endregion

		internal System.Drawing.Color InformationColor
		{
			get
			{
				return _informationColor;
			}
			set
			{
				if(!value.IsEmpty)
					_informationColor = value;
			}
		}

		internal System.Drawing.Font InformationFont
		{
			get
			{
				return _informationFont;
			}
			set
			{
				if(value != null)
					_informationFont = value;
			}
		}

		/// <summary>
		/// �ڴ����Ĭ��λ����ʾ��ʾ��Ϣ��
		/// </summary>
		/// <param name="g">�ṩ��ʾ��ʾ��Ϣ��System.Drawing.Graphics����</param>
		private void DrawInformation(System.Drawing.Graphics g)
		{
			//���ָ������ʾλ��Ϊ���򷵻ء�
			if(this.InformationRectangle.IsEmpty)
				return;

			try
			{
				//���ָ���Ĳ���Ϊ�գ���Ϊ��ǰ���崴��Graphics����
				if(g == null)
					g = this.CreateGraphics();

				g.DrawString(this.Information, _informationFont, new System.Drawing.SolidBrush(_informationColor), (System.Drawing.RectangleF)this.InformationRectangle, new StringFormat(StringFormatFlags.NoWrap));
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// �ڴ����Ĭ��λ����ʾ��Ȩ��Ϣ��
		/// </summary>
		/// <param name="g">�ṩ��ʾ��ʾ��Ϣ��System.Drawing.Graphics����</param>
		private void DrawAccredit(System.Drawing.Graphics g)
		{
			//���ָ������ʾλ��Ϊ���򷵻ء�
			if(this.AccreditRectangle.IsEmpty)
				return;

			try
			{
				//���ָ���Ĳ���Ϊ�գ���Ϊ��ǰ���崴��Graphics����
				if(g == null)
					g = this.CreateGraphics();

				//������ʱ���νṹ��
				System.Drawing.RectangleF layoutRectangle = (System.Drawing.RectangleF)this.AccreditRectangle;
				//������ʾ�ı���Ϣ���ַ�����ʽ��
				System.Drawing.StringFormat layoutFormat = new StringFormat(StringFormatFlags.NoWrap);

				try
				{
					//����Դ���л�ȡ����Ȩ���⡱���ı����ݡ�
					String accreditTitle = _ownerResource.GetString("Accredit");

					//������Ȩ���⣨�����ʹ��Ȩ���ڣ����ַ�����
					g.DrawString(accreditTitle, this.Font, new SolidBrush(Color.DimGray), layoutRectangle, layoutFormat);

					//���÷ָ��ߵ�������λ�á�
					layoutRectangle.Y += g.MeasureString(accreditTitle, this.Font).Height - 1;

					//���ָ���
					g.DrawLine(new System.Drawing.Pen(Color.DarkGray), layoutRectangle.X, layoutRectangle.Y, layoutRectangle.Right, layoutRectangle.Y);

					//���������ı���ʾ��������λ�á�
					layoutRectangle.Y += 4;
				}
				catch
				{
				}

				//�������������ơ��ַ�����
				g.DrawString(this.OwnerName, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, layoutFormat);

				//���������ı���ʾ��������λ�á�
				layoutRectangle.Y += g.MeasureString(this.OwnerName, this.Font).Height;
				//������֯�����ơ��ַ�����
				g.DrawString(this.Organization, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, layoutFormat);

				//���������ı���ʾ��������λ�á�
				layoutRectangle.Y += g.MeasureString(this.Organization, this.Font).Height;
				//������Ʒ���кš��ַ�����
				g.DrawString(this.ProductID, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, layoutFormat);
			}
			catch
			{
				throw;
			}
		}

		internal void Refresh(String information, System.Drawing.Rectangle layoutRectangle, System.Drawing.Color foreColor, System.Drawing.Font font)
		{
			if(!layoutRectangle.IsEmpty)
				this.InformationRectangle = layoutRectangle;

			this.Information = information;
			this.InformationFont = font;
			this.InformationColor = foreColor;

			base.Refresh();
		}

		private void FSplashBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			this.DrawAccredit(e.Graphics);
			this.DrawInformation(e.Graphics);
		}

		private void FSplashBox_Load(object sender, System.EventArgs e)
		{
			this.TopLevel = true;

			if(this.BackgroundImage != null)
			{
				this.ClientSize = this.BackgroundImage.Size;

				if(this.Owner == null)
				{
					this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
					this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
				}
				else
				{
					this.Left = this.Owner.Left + (this.Owner.Width - this.Width) / 2;
					this.Top = this.Owner.Top + (this.Owner.Height - this.Height) / 2;
				}
			}
		}
	}
}
