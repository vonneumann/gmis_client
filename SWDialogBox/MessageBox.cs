using System;
using System.Windows.Forms;

namespace SWDialogBox
{
	/// <summary>
	/// ָ�����ɳ��������Զ��� MessageBox �Ͻ���ʾ��Щ��ť��
	/// </summary>
	[Flags]
	public enum MessageBoxButton
	{
		/// <summary>
		/// ��Ϣ�������ȷ��(OK)����ť��
		/// </summary>
		OK			=	0,

		/// <summary>
		/// ��Ϣ�������ȷ��(OK)���͡�ȡ��(Cancel)����ť��
		/// </summary>
		OKCancel	=	1,

		/// <summary>
		/// ��Ϣ�����������(Retry)���͡�ȡ��(Cancel)����ť��
		/// </summary>
		RetryCancel	=	2,

		/// <summary>
		/// ��Ϣ���������(Yes)���͡���(No)����ť��
		/// </summary>
		YesNo		=	4,

		/// <summary>
		/// ��Ϣ���������(Yes)��������(No)���͡�ȡ��(Cancel)����ť��
		/// </summary>
		YesNoCancel	=	8,

		/// <summary>
		/// ��Ϣ���������ϸ(Detail)����ť��
		/// </summary>
		Detail		=	16,

		/// <summary>
		/// ��Ϣ���ϵĵ�һ����ť��Ĭ�ϰ�ť��
		/// </summary>
		DefaultButton1	=	0,
		/// <summary>
		/// ��Ϣ���ϵĵڶ�����ť��Ĭ�ϰ�ť��
		/// </summary>
		DefaultButton2	=	256,
		/// <summary>
		/// ��Ϣ���ϵĵ�������ť��Ĭ�ϰ�ť��
		/// </summary>
		DefaultButton3	=	512
	}

	/// <summary>
	/// ָ�����ɳ��������Զ��� MessageBox �Ͻ���ʾ��ͼ�����͡�
	/// </summary>
	[Flags]
	public enum MessageBoxIcon
	{
		/// <summary>
		/// ��Ϣ��δ����ͼ�ꡣ
		/// </summary>
		None		=	0,
		/// <summary>
		/// ����Ϣ�����һ��ͼ�꣬��ͼ������һ����ɫ������ԲȦ�����еİ�ɫ X ��ɵġ�
		/// </summary>
		Error		=	32,
		/// <summary>
		/// ����Ϣ�����һ��ͼ�꣬��ͼ������һ����ɫ�����������μ����е�һ����̾����ɵġ�
		/// </summary>
		Warning		=	96,

		/// <summary>
		/// ����Ϣ�����һ��ͼ�꣬��ͼ������һ����ɫ������ԲȦ�����еİ�ɫ X ��ɵġ�
		/// </summary>
		Critical	=	32,
		/// <summary>
		/// ����Ϣ�����һ��ͼ�꣬��ͼ������һ��ԲȦ�����е�һ���ʺ���ɵġ�
		/// </summary>
		Question	=	64,
		/// <summary>
		/// ����Ϣ�����һ��ͼ�꣬��ͼ������һ����ɫ�����������μ����е�һ����̾����ɵġ�
		/// </summary>
		Exclamation	=	96,
		/// <summary>
		/// ����Ϣ�����һ��ͼ�꣬��ͼ������һ��ԲȦ�����е�Сд��ĸ i ��ɵġ�
		/// </summary>
		Information	=	128,
	}

	/// <summary>
	/// ��ʾ�ɰ����ı�����ť�ͷ��ţ�֪ͨ��ָʾ�û�������Ϣ��
	/// </summary>
	public class MessageBox
	{
		private static System.Drawing.Icon moIcon;

		static MessageBox()
		{
			moIcon = null;
		}

		/// <summary>
		/// �ù��캯��Ϊ˽�����ͣ�����ֹ����ʵ������
		/// </summary>
		private MessageBox()
		{
		}

		/// <summary>
		/// ��ȡ��������Ϣ�������Ͻǵ�ϵͳͼ�ꡣ
		/// </summary>
		/// <remarks>
		/// ��ֵΪ��ֵ����Visual Basic��ΪNothing��Ĭ��Ϊϵͳ�ṩ��ͼ�ꡣ
		/// </remarks>
		public static System.Drawing.Icon Icon
		{
			get
			{
				return moIcon;
			}
			set
			{
				moIcon = value;
			}
		}

		/// <summary>
		/// ��ʾָ����Ϣ��Ŷ�Ӧ��Ϣ����Ϣ��
		/// </summary>
		/// <param name="messageID">��Ϣ��š�</param>
		/// <returns>System.Window.Forms.DialogResult ֵ֮һ��</returns>
		public static System.Windows.Forms.DialogResult Show(String messageID)
		{
			return SWDialogBox.MessageBox.Show(messageID, null);
		}

		/// <summary>
		/// ��ʾָ����Ϣ��Ŷ�Ӧ��Ϣ����Ϣ��
		/// </summary>
		/// <param name="messageID">��Ϣ��š�</param>
		/// <param name="args">Ҫʹ�� format д��Ķ�������顣</param>
		/// <returns>System.Window.Forms.DialogResult ֵ֮һ��</returns>
		public static System.Windows.Forms.DialogResult Show(String messageID, params Object[] args)
		{
			SWDialogBox.FMessageBox messageForm = null;

			try
			{
				messageForm = new SWDialogBox.FMessageBox();
				messageForm.Icon = moIcon;
				return messageForm.ShowDialog(messageID, args);
			}
			catch
			{
				throw;
			}
			finally
			{
				if(messageForm != null)
					messageForm.Dispose();
			}
		}

		/// <summary>
		/// ��ʾ����ָ���ı������⡢��ϸע�ӡ���ť��ͼ���Ĭ�ϰ�ť����Ϣ��
		/// </summary>
		/// <param name="message">��Ϣ������ʾ���ı���</param>
		/// <param name="caption">��Ϣ��ı���������ʾ���ı���</param>
		/// <param name="description">��Ϣ�����ϸע��������ʾ���ı���</param>
		/// <param name="button">SWDialogBox.MessageBoxButton ֵ֮һ����ָ������Ϣ������ʾ��Щ��ť��Ĭ�ϰ�ť��</param>
		/// <param name="icon">SWDialogBox.MessageBoxIcon ֵ֮һ����ָ������Ϣ������ʾ�ĸ�ͼ�ꡣ</param>
		/// <returns>System.Window.Forms.DialogResult ֵ֮һ��</returns>
		public static System.Windows.Forms.DialogResult Show(String message, String caption, String description, SWDialogBox.MessageBoxButton button, SWDialogBox.MessageBoxIcon icon)
		{
			SWDialogBox.FMessageBox messageForm = null;

			try
			{
				messageForm = new SWDialogBox.FMessageBox();
				messageForm.Icon = moIcon;
				return messageForm.ShowDialog(message, caption, description, button, icon);
			}
			catch
			{
				throw;
			}
			finally
			{
				if(messageForm != null)
					messageForm.Dispose();
			}
		}
	}
}
