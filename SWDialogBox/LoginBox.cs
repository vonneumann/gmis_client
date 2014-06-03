using System;

namespace SWDialogBox
{
	/// <summary>
	/// ָʾ��¼�Ƿ�ɹ��ķ���״̬��
	/// </summary>
	public enum LoginResult
	{
		/// <summary>
		/// ���Է���ֵ��
		/// </summary>
		None				=	-1,
		/// <summary>
		/// ��¼�ɹ���
		/// </summary>
		Success				=	0,
		/// <summary>
		/// ��¼�����з���δ֪�Ĵ�����쳣��
		/// </summary>
		Unknown				=	99,
		/// <summary>
		/// ��¼��ʱ��
		/// </summary>
		Timeout				=	1,
		/// <summary>
		/// ��Ч��Ƿ��ĵ�¼�ʻ���
		/// </summary>
		InvalidUserName		=	2,
		/// <summary>
		/// ��Ч�ĵ�¼���
		/// </summary>
		InvalidPassword		=	3,
		/// <summary>
		/// ��Ч�ķ�������
		/// </summary>
		InvalidServer		=	4,
		/// <summary>
		/// ��Ч�����ݿ⡣
		/// </summary>
		InvalidDatabase		=	5,
		/// <summary>
		/// ��Ч��Ȩ�ޣ�ָ��ǰ��¼�û���ϵͳ�ܾ����롣
		/// </summary>
		InvalidPermission	=	6,
	}

	/// <summary>
	/// Ϊ SWDialogBox.LoginBox.Logined �¼��ṩ���ݡ�
	/// </summary>
	public class LoginedEventArgs : System.EventArgs
	{
		private SWDialogBox.LoginResult mnLoginResult;

		/// <summary>
		/// ��ȡ�����õ�¼״̬�ķ���ֵ��
		/// </summary>
		public SWDialogBox.LoginResult Result
		{
			get
			{
				return mnLoginResult;
			}
			set
			{
				mnLoginResult = value;
			}
		}

		/// <summary>
		/// ��ʼ�� SWDialogBox.LoginedEventArgs ���һ����ʵ����
		/// </summary>
		/// <param name="loginResult">���صĵ�¼״̬��</param>
		public LoginedEventArgs(SWDialogBox.LoginResult loginResult)
		{
			mnLoginResult = loginResult;
		}
	}

	/// <summary>
	/// ��ʾ������ SWDialogBox.Logined �¼��ķ�����
	/// </summary>
	public delegate void LoginedEventHandler(Object sender, SWDialogBox.LoginedEventArgs e);

	/// <summary>
	/// ��ʾ�ɰ����û���������ͷ���������Ϣ��֪ͨ��ָʾ�û����ĵ�¼��
	/// </summary>
	public class LoginBox
	{
		private Boolean					_useSecurity;
		private String					_userName;
		private String					_password;
		private String					_database;
		private String					_server;
		private String					_title;
		private Int32					_timeout;
		private Int32					_maxCount;
		private System.Drawing.Color	_backColor;
		private System.Drawing.Color	_foreColor;
		private System.Drawing.Image	_backgroundImage;
		private System.Drawing.Image	_titleImage;

		private SWDialogBox.LoginedEventArgs moLoginedEventArgs;

		/// <summary>
		/// �ڵ�����ȷ������ť������
		/// </summary>
		public event SWDialogBox.LoginedEventHandler Logined;

		/// <summary>
		/// ���� SWDialogBox.LoginBox.Logined �¼���
		/// </summary>
		/// <param name="e">�ṩ���¼��Ĳ�����</param>
		protected virtual void OnLogined(SWDialogBox.LoginedEventArgs e)
		{
			if(Logined != null)
				Logined(this, e);
		}

		/// <summary>
		/// ��ʼ�� SWDialogBox.LoginBox ���һ����ʵ����
		/// </summary>
		public LoginBox()
		{
//			_title		= null;
//			_timeout	= 30;
//			_maxCount	= 3;
//			_useSecurity = false;
//			_backColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
//			_foreColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
//			_backgroundImage = null;
//
//			System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
//			System.Drawing.Image image = rm.GetObject("BITMAP-Title") as System.Drawing.Image;
//
//			_titleImage = image;

			moLoginedEventArgs = new SWDialogBox.LoginedEventArgs(SWDialogBox.LoginResult.Success);
		}

		#region ��������
		/// <summary>
		/// ��ȡ�����õ�¼���û����ơ�
		/// </summary>
		public String UserName
		{
			get
			{
				return _userName;
			}
			set
			{
				_userName = value.Trim();
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼���
		/// </summary>
		public String Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼�ķ�������ַ��
		/// </summary>
		public String Server
		{
			get
			{
				return _server;
			}
			set
			{
				_server = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼�����ݿ����ơ�
		/// </summary>
		public String Database
		{
			get
			{
				return _database;
			}
			set
			{
				_database = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼�ĳ�ʱ���ޣ�����ʹ�õ�λΪ���롯��
		/// </summary>
		public Int32 Timeout
		{
			get
			{
				return _timeout;
			}
			set
			{
				_timeout = value;
			}
		}

		public bool UseSecurity
		{
			get
			{
				return _useSecurity;
			}
			set
			{
				_useSecurity = value;
			}
		}

		/// <summary>
		/// ��ȡ���������ĵ�¼������
		/// </summary>
		/// <remarks>
		/// ��ֵӦ���ڻ�����㣬Ϊ��ʱ��ʾ���޵�¼������
		/// </remarks>
		public Int32 MaxCount
		{
			get
			{
				return _maxCount;
			}
			set
			{
				_maxCount = value >= 0 ? value : 3;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼����ı��⡣
		/// </summary>
		/// <remarks>
		/// ��ֵΪ��ֵ����Visual Basic��ΪNothing��Ĭ��Ϊϵͳ�ṩ�ı������ݡ�
		/// </remarks>
		public String Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼�����ǰ����ɫ��
		/// </summary>
		public System.Drawing.Color ForeColor
		{
			get
			{
				return _foreColor;
			}
			set
			{
				_foreColor = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼����ı�����ɫ��
		/// </summary>
		public System.Drawing.Color BackColor
		{
			get
			{
				return _backColor;
			}
			set
			{
				_backColor = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼����ı���ͼ��
		/// </summary>
		public System.Drawing.Image BackgroundImage
		{
			get
			{
				return _backgroundImage;
			}
			set
			{
				_backgroundImage = value;
			}
		}

		/// <summary>
		/// ��ȡ�����õ�¼����ı���������ʾͼ��
		/// </summary>
		public System.Drawing.Image TitleImage
		{
			get
			{
				return _titleImage;
			}
			set
			{
				_titleImage = value;
			}
		}
		#endregion

		#region ��������
		/// <summary>
		/// ����ϵͳ��¼��Ϣ��
		/// </summary>
		/// <param name="UserName">��¼�û���</param>
		/// <param name="Password">��¼���</param>
		/// <param name="Server">��¼��������</param>
		/// <param name="Database">��¼���ݿ⡣</param>
		/// <param name="Timeout">��¼��ʱ��</param>
		public void SetLogin(String UserName, String Password, String Server, String Database, Int32 Timeout)
		{
			_userName = UserName.Trim();
			_password = Password;
			_server = Server;
			_database = Database;
			_timeout = Timeout;
		}

		/// <summary>
		/// �򿪵�¼���塣
		/// </summary>
		/// <returns>
		/// �棺��ʾ��¼�ɹ����� SWDialogBox.LoginBox.Logined �¼��з��ص� SWDialogBox.LoginedEventArgs ���Ͳ����� Result ���Ա�����Ϊ SWDialogBox.LoginResult.Success ֵ��
		/// �٣���ʾ��¼ʧ�ܣ�����¼������ȡ����
		/// </returns>
		public Boolean Login()
		{
			return this.Login(null, null);
		}

		/// <summary>
		/// �򿪵�¼���塣
		/// </summary>
		/// <param name="title">��¼����ı��⡣</param>
		/// <returns>
		/// �棺��ʾ��¼�ɹ����� SWDialogBox.LoginBox.Logined �¼��з��ص� SWDialogBox.LoginedEventArgs ���Ͳ����� Result ���Ա�����Ϊ SWDialogBox.LoginResult.Success ֵ��
		/// �٣���ʾ��¼ʧ�ܣ�����¼������ȡ����
		/// </returns>
		public Boolean Login(String title)
		{
			return this.Login(null, title);
		}

		/// <summary>
		/// �򿪵�¼���塣
		/// </summary>
		/// <param name="owner">��¼����������ߡ�</param>
		/// <returns>
		/// �棺��ʾ��¼�ɹ����� SWDialogBox.LoginBox.Logined �¼��з��ص� SWDialogBox.LoginedEventArgs ���Ͳ����� Result ���Ա�����Ϊ SWDialogBox.LoginResult.Success ֵ��
		/// �٣���ʾ��¼ʧ�ܣ�����¼������ȡ����
		/// </returns>
		public Boolean Login(System.Windows.Forms.IWin32Window owner)
		{
			return this.Login(owner, null);
		}

		/// <summary>
		/// �򿪵�¼���塣
		/// </summary>
		/// <param name="owner">��¼����������ߡ�</param>
		/// <param name="title">��¼����ı��⡣</param>
		/// <returns>
		/// �棺��ʾ��¼�ɹ����� SWDialogBox.LoginBox.Logined �¼��з��ص� SWDialogBox.LoginedEventArgs ���Ͳ����� Result ���Ա�����Ϊ SWDialogBox.LoginResult.Success ֵ��
		/// �٣���ʾ��¼ʧ�ܣ�����¼������ȡ����
		/// </returns>
		public Boolean Login(System.Windows.Forms.IWin32Window owner, String title)
		{
			FLoginBox loginForm = null;

			try
			{
				System.Windows.Forms.DialogResult result;

				loginForm = new FLoginBox();
				loginForm.SetLogin(_userName, _password, _server, _database, _timeout, moLoginedEventArgs.Result);
//				loginForm.UseSecurity = _useSecurity;
//				loginForm.picTitle.Image = _titleImage;
//				loginForm.picTitle.Visible = (_titleImage != null);
//				loginForm.BackgroundImage = _backgroundImage;

//				if(title != null)
//					_title = title;
//
//				if(_title != null)
//					loginForm.Text = _title;

				for(int i=0; i<_maxCount || _maxCount==0; i++)
				{
					loginForm.SetResult(moLoginedEventArgs.Result);

					if(owner == null)
					{
						loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						result = loginForm.ShowDialog();
					}	
					else
					{
						loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						result = loginForm.ShowDialog(owner);
					}

					if(result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes)
					{
						_userName = loginForm.UserName;
						_password = loginForm.Password;
						_database = loginForm.Database;
						_server = loginForm.Server;
						_timeout = loginForm.Timeout;
						_useSecurity = loginForm.UseSecurity;

						//������Logined���¼�
						this.OnLogined(moLoginedEventArgs);

						switch(moLoginedEventArgs.Result)
						{
							case SWDialogBox.LoginResult.Success:
								loginForm.writeAppXML(loginForm.UserName);
								return (result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes);
							case SWDialogBox.LoginResult.None:
								i--;
								break;
						}
					}
					else//�˴��������Σ�����ȡ������ť��ֱ���˳��������谴��ȡ����ť���趨�������˳� qxd remark 2006-11-15
						break;
				}
			}
			catch
			{
				return false;
			}
			finally
			{
				if(loginForm != null)
					loginForm.Dispose();
			}

			return false;
		}
		#endregion
	}
}
