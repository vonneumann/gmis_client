using System;

namespace SWDialogBox
{
	/// <summary>
	/// ��ʾ������Ȩ�û�����֯�Ͳ�Ʒ���кŵķ��洰�ڡ�
	/// </summary>
	public class SplashBox : System.IDisposable
	{
		private SWDialogBox.FSplashBox _splashForm;

		/// <summary>
		/// ��ʼ�� SWSystem.Windows.Forms.DialogBoxs.SplashBox ���һ����ʵ����
		/// </summary>
		public SplashBox()
		{
			_splashForm = new SWDialogBox.FSplashBox();
		}

		/// <summary>
		/// �ͷ��� SWSystem.Windows.Forms.DialogBoxs.SplashBox ռ�õ�������Դ��
		/// </summary>
		public void Dispose()
		{
			if(_splashForm != null)
				_splashForm.Close();

			_splashForm.Dispose();
		}

		/// <summary>
		/// ��ȡ�����á����桱������ʾ���ı������塣
		/// </summary>
		public System.Drawing.Font Font
		{
			get
			{
				return _splashForm.Font;
			}
			set
			{
				_splashForm.Font = value;
			}
		}

		/// <summary>
		/// ��ȡ�����á����桱�����ǰ����ɫ��
		/// </summary>
		public System.Drawing.Color ForeColor
		{
			get
			{
				return _splashForm.ForeColor;
			}
			set
			{
				_splashForm.ForeColor = value;
			}
		}

		/// <summary>
		/// ��ȡ�����á����桱������ʾ�ı���ͼƬ��
		/// </summary>
		public System.Drawing.Image BackgroundImage
		{
			get
			{
				return _splashForm.BackgroundImage;
			}
			set
			{
				_splashForm.BackgroundImage = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�ǰ���ָ��λ�ڡ����桱������ʱ��ʾ�Ĺ�ꡣ
		/// </summary>
		public System.Windows.Forms.Cursor Cursor
		{
			get
			{
				return _splashForm.Cursor;
			}
			set
			{
				_splashForm.Cursor = value;
			}
		}

		/// <summary>
		/// �رա����桱���塣
		/// </summary>
		public void Close()
		{
			_splashForm.Hide();
		}

		/// <summary>
		/// ˢ�¡����桱���塣
		/// </summary>
		public void Refresh()
		{
			_splashForm.Refresh();
		}

		/// <summary>
		/// �ڡ����桱�����е�ָ��λ����ʾָ������Ϣ�ı���
		/// </summary>
		/// <param name="information">��ʾ����Ϣ�ı����ݡ�</param>
		public void Refresh(String information)
		{
			_splashForm.Refresh(information, System.Drawing.Rectangle.Empty, System.Drawing.Color.Empty, null);
		}

		/// <summary>
		/// �ڡ����桱�����е�ָ��λ����ʾָ������Ϣ�ı���
		/// </summary>
		/// <param name="information">��ʾ����Ϣ�ı����ݡ�</param>
		/// <param name="foreColor">��ʾ����Ϣ�ı�����ɫ��</param>
		public void Refresh(String information, System.Drawing.Color foreColor)
		{
			_splashForm.Refresh(information, System.Drawing.Rectangle.Empty, foreColor, null);
		}

		/// <summary>
		/// �ڡ����桱�����е�ָ��λ����ʾָ������Ϣ�ı���
		/// </summary>
		/// <param name="information">��ʾ����Ϣ�ı����ݡ�</param>
		/// <param name="foreColor">��ʾ����Ϣ�ı�����ɫ��</param>
		/// <param name="font">��ʾ����Ϣ�ı������塣</param>
		public void Refresh(String information, System.Drawing.Color foreColor, System.Drawing.Font font)
		{
			_splashForm.Refresh(information, System.Drawing.Rectangle.Empty, foreColor, font);
		}

		/// <summary>
		/// �ڡ����桱�����е�ָ��λ����ʾָ������Ϣ�ı���
		/// </summary>
		/// <param name="information">��ʾ����Ϣ�ı����ݡ�</param>
		/// <param name="layoutRectangle">��ʾ����Ϣλ������</param>
		public void Refresh(String information, System.Drawing.Rectangle layoutRectangle)
		{
			_splashForm.Refresh(information, layoutRectangle, System.Drawing.Color.Empty, null);
		}

		/// <summary>
		/// �ڡ����桱�����е�ָ��λ����ʾָ������Ϣ�ı���
		/// </summary>
		/// <param name="information">��ʾ����Ϣ�ı����ݡ�</param>
		/// <param name="layoutRectangle">��ʾ����Ϣλ������</param>
		/// <param name="foreColor">��ʾ����Ϣ�ı�����ɫ��</param>
		public void Refresh(String information, System.Drawing.Rectangle layoutRectangle, System.Drawing.Color foreColor)
		{
			_splashForm.Refresh(information, layoutRectangle, foreColor, null);
		}

		/// <summary>
		/// �ڡ����桱�����е�ָ��λ����ʾָ������Ϣ�ı���
		/// </summary>
		/// <param name="information">��ʾ����Ϣ�ı����ݡ�</param>
		/// <param name="layoutRectangle">��ʾ����Ϣλ������</param>
		/// <param name="foreColor">��ʾ����Ϣ�ı�����ɫ��</param>
		/// <param name="font">��ʾ����Ϣ�ı������塣</param>
		public void Refresh(String information, System.Drawing.Rectangle layoutRectangle, System.Drawing.Color foreColor, System.Drawing.Font font)
		{
			_splashForm.Refresh(information, layoutRectangle, foreColor, font);
		}

		/// <summary>
		/// ��ʾ�����桱���塣
		/// </summary>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		public void Show(String ownerName, String organizationName, String productID)
		{
			this.Show(null, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// ��ʾ�����桱���塣
		/// </summary>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		/// <param name="layoutRectangle">��ʾ��Ȩ��Ϣ��λ������</param>
		public void Show(String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			this.Show(null, ownerName, organizationName, productID, layoutRectangle);
		}

		/// <summary>
		/// ��ʾ�����桱���塣
		/// </summary>
		/// <param name="owner">ӵ�С����桱����������ߡ�</param>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		public void Show(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID)
		{
			this.Show(owner, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// ��ʾ�����桱���塣
		/// </summary>
		/// <param name="owner">ӵ�С����桱����������ߡ�</param>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		/// <param name="layoutRectangle">��ʾ��Ȩ��Ϣ��λ������</param>
		public void Show(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			_splashForm.OwnerName = ownerName;
			_splashForm.ProductID = productID;
			_splashForm.Organization = organizationName;

			if(layoutRectangle != System.Drawing.Rectangle.Empty)
				_splashForm.AccreditRectangle = layoutRectangle;

			if(owner != null)
				_splashForm.Owner = (System.Windows.Forms.Form)owner;

			_splashForm.Show();
		}

		/// <summary>
		/// ��ģʽ��ʽ��ʾ�����桱���塣
		/// </summary>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		/// <returns>System.Windows.Forms.DialogResult ֵ֮һ��</returns>
		public System.Windows.Forms.DialogResult ShowDialog(String ownerName, String organizationName, String productID)
		{
			return this.ShowDialog(null, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// ��ģʽ��ʽ��ʾ�����桱���塣
		/// </summary>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		/// <param name="layoutRectangle">��ʾ��Ȩ��Ϣ��λ������</param>
		/// <returns>System.Windows.Forms.DialogResult ֵ֮һ��</returns>
		public System.Windows.Forms.DialogResult ShowDialog(String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			return this.ShowDialog(null, ownerName, organizationName, productID, layoutRectangle);
		}

		/// <summary>
		/// ��ģʽ��ʽ��ʾ�����桱���塣
		/// </summary>
		/// <param name="owner">ӵ�С����桱����������ߡ�</param>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		/// <returns>System.Windows.Forms.DialogResult ֵ֮һ��</returns>
		public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID)
		{
			return this.ShowDialog(owner, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// ��ģʽ��ʽ��ʾ�����桱���塣
		/// </summary>
		/// <param name="owner">ӵ�С����桱����������ߡ�</param>
		/// <param name="ownerName">��Ȩ���û����ơ�</param>
		/// <param name="organizationName">��Ȩ����֯��˾���ơ�</param>
		/// <param name="productID">��Ȩ�Ĳ�Ʒ���кš�</param>
		/// <param name="layoutRectangle">��ʾ��Ȩ��Ϣ��λ������</param>
		/// <returns>System.Windows.Forms.DialogResult ֵ֮һ��</returns>
		public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			_splashForm.OwnerName = ownerName;
			_splashForm.ProductID = productID;
			_splashForm.Organization = organizationName;

			if(layoutRectangle != System.Drawing.Rectangle.Empty)
				_splashForm.AccreditRectangle = layoutRectangle;

			if(owner == null)
				return _splashForm.ShowDialog();
			else
				return _splashForm.ShowDialog(owner);
		}
	}
}
