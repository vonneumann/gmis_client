using System;
using System.Windows.Forms ;
using System.Xml;
using System.Data;
using System.Reflection ;

namespace SZCGC.DocumentManager
{
	/// <summary>
	/// Class1 ��ժҪ˵����
	/// </summary>
	public class DocumentGenerator
	{
		//�����ĵ���ʵ����
		private string _docRealName = "";
		public string DocRealName
		{
			get { return _docRealName; }
		}

		public DocumentGenerator()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public void GenerateDocument(DataSet ElementSet,DataSet EstateList,DataSet ChattelList,DataSet CarList,CCWordApp WordTemplate)
		{
			//�������к�ͬҪ�ؼ�¼
			string strBookMarkName;
			string strElementValue;
			string strElementType;
			string strElementFrom;
			foreach (DataRow dr in ElementSet.Tables[0].Rows)
			{
				//'����Ŀ��ͬҪ���滻��ͬģ���BOOKMARK��ǣ�
				strBookMarkName= dr["element_bookmark"].ToString() == "" ? "" : dr["element_bookmark"].ToString();
				strElementValue=dr["element_value"].ToString() == "" ? "" : dr["element_value"].ToString();
				strElementType=dr["element_type"].ToString() == "" ? "" : dr["element_type"].ToString();
				strElementFrom=dr["element_from"].ToString() == "" ? "" : dr["element_from"].ToString();
				try
				{
					if (strElementType=="TEXT")
					{
						WordTemplate.GotoBookMark(strBookMarkName);
						WordTemplate.InsertText(strElementValue);
					}
					else if (strElementType=="GRID")
					{
						if (strElementFrom=="project_contract_estate_element" && EstateList!=null)
						{
							WordTemplate.CreateTalbe(EstateList,strBookMarkName);
						}
						else if (strElementFrom=="project_contract_chattel_element" && ChattelList!=null)
						{
							WordTemplate.CreateTalbe(ChattelList,strBookMarkName);
						}
						else if (strElementFrom=="project_contract_car_element" && CarList!=null)
						{
							WordTemplate.CreateTalbe(CarList,strBookMarkName);
						}
					}
				}
				catch (Exception er)
				{
					continue;
				}
			}

//			//��ȡ�ĵ�ģ�弰�����·��
//			XmlDocument docSetting = new XmlDocument();
//			docSetting.LoadXml(DocGenerateSetting);
//			XmlNode docSettingNode = docSetting.FirstChild;
//			string fileServerPath = docSettingNode.Attributes["template"].Value;
//			string filePath = fileServerPath;
//
//			//�����ĵ���ʵ����
//			string strDotName=filePath.Substring(filePath.LastIndexOf("\\") + 1);
//			_docRealName=strDotName.Substring(0,strDotName.LastIndexOf("."))+".doc";
//
//			//���ĵ�ģ��
//			CCWordApp objCCWordApp = new CCWordApp();
////			objCCWordApp.ojbInvokeControlMember = new InvokeControlMemberDelegate(this.InvokeControlMember);
//			objCCWordApp.Open(filePath);
//
////			//�������־���
////			objCCWordApp.SetAlignment("Center");
//
//
//			//�������е�BookMark�ڵ�
//			foreach (XmlNode tmpNode in docSettingNode.SelectNodes("BookMark"))
//			{
//				string strBookMarkName = tmpNode.Attributes["id"].Value;
//
//				//��������BookMark�ڵ���Control�ڵ�
//				foreach (XmlNode tmpControlNode in tmpNode.SelectNodes("Control"))
//				{
//					string[] strControls = tmpControlNode.Attributes["id"].Value.Split(new char[] { '.' });
//					string strParentControlID = "";
//					string strControlID="";
//					if (strControls.Length != 0)
//					{
//						strParentControlID = strControls[0].ToString();
//						strControlID = strControls[1].ToString();
//					}
//					else
//					{
//						strParentControlID = "";
//						strControlID = tmpControlNode.Attributes["id"].Value;
//					}
//
//					string strControlType = tmpControlNode.Attributes["type"].Value;
//					string strControlInvokeAttribute = tmpControlNode.Attributes["invokeattribute"].Value;
//
//					//�����û��ؼ��ϵ����пؼ�//
//					foreach (Control c in ObjForm.Controls)
//					{
//						//����ؼ�ID�������ļ�����ƥ��//
//						if (c.GetType().ToString() == strControlType & c.Name == strControlID)
//						{
//							try
//							{
//								//���ĵ�����Ӧ��BookMark����Ϊ�ÿؼ�������ֵ
//
//								objCCWordApp.GotoBookMark(strBookMarkName);
//								if (c is System.Windows.Forms.DataGrid)
//								{
//									objCCWordApp.CreateTalbe((c as System.Windows.Forms.DataGrid),strBookMarkName);
//								}
//								else
//								{
//									objCCWordApp.InsertText(InvokeControlMember(strControlInvokeAttribute, c));
//								}
//
//								break;
//							}
//							catch 
//							{
//								break;
//							}
//						}
//					}
//				}
//			}
//
//			//�������ɵ��ĵ�//
//			string saveDocName= Guid.NewGuid().ToString() +".doc";
//			string saveDocPath = @System.Windows.Forms.Application.StartupPath + @"\Document\" + saveDocName;
//			objCCWordApp.SaveAs(saveDocPath);       
//
//			objCCWordApp.Quit();
//
//			//�����ĵ�����
//			return saveDocName;
		}

//		//�����ݿ��ж�ȡ�ĵ������ص���������Ŀ¼//
//		public string DownloadFile(string FileGuid)
//		{
//			//����GUID�����ݿ��л�ȡ�ĵ��ֽ���
//			byte[] objByte = Container2.OpenFile(FileGuid);
//
//			//����GUID�����ݿ��л�ȡ�ĵ������ĵ�����//
//			string strSql = " SELECT file_type,file_name" +
//				" FROM risk_project_file" +
//				" WHERE risk_project_file_guid='" + FileGuid + "'";
//			DataTable dt = Container2.GetCommonData(strSql, "TempTable");
//			string strFileType = "";
//			string strFileName = "";
//			if (dt.Rows.Count != 0)
//			{
//				strFileType = (string)dt.Rows[0]["file_type"];
//				strFileName = (string)dt.Rows[0]["file_name"];
//			}
//
//
//			//�����ĵ���ʵ����
//			_docRealName = strFileName ;
//
//			//�ڷ������˵�DocumentĿ¼�д������ĵ�
//			string strDocName = Guid.NewGuid().ToString() + "." + strFileType;
//			string FilePath = @IoryCommon.GetServerPath() + @"\Document\" + strDocName;
//			FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
//
//			//���ĵ��ֽ���д���ĵ���//
//			fs.Write(objByte, 0, objByte.Length);
//			fs.Close();
//
//			//�����ĵ�����
//			return strDocName;
// 
//		}

		//ʹ�÷�����ÿؼ�������
		private string InvokeControlMember(string InvokeAttribute,Control Control)
		{
//			if (Control is System.Web.UI.WebControls.DropDownList)
//			{
//				return (Control as Iory.Framework.WebControls.NewDropDownList).SelectedItem.Text;
//			}
//			else if (Control is System.Web.UI.WebControls.CheckBox)
//			{
//				if ((Control as System.Web.UI.WebControls.CheckBox).Checked)
//				{ 
//					return "��";
//				}
//				else
//				{
//					return "��";
//				}
//
//			}
			return (string)Control.GetType().InvokeMember(InvokeAttribute, BindingFlags.GetProperty, null, Control, null);
        
		}
	}
}
