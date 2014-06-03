Public Class ExceptionHandler
    Public Const UNKNOWNERROR As String = "*999"

    Private _logFile As String

    Public Sub New()
        '��ʼ��ϵͳĬ����־�ļ����ơ�
        _logFile = System.IO.Path.Combine(System.Environment.CurrentDirectory, System.Reflection.Assembly.GetEntryAssembly().GetName().Name + ".log")
    End Sub

    Public Sub New(ByVal logFile As String)
        _logFile = logFile
    End Sub

    Public Property LogFile() As String
        Get
            Return _logFile
        End Get
        Set(ByVal Value As String)
            _logFile = Value
        End Set
    End Property

    '/// <summary>
    '/// ��ָ�����쳣��Ϣд��ϵͳĬ�ϵ���־�ļ���
    '/// </summary>
    '/// <param name="ex">Ҫ��¼���쳣����</param>
    '/// <returns></returns>
    Public Function WriteLog(ByVal ex As System.Exception) As String
        Return ExceptionHandler.WriteLog(ex, _logFile)
    End Function

    '/// <summary>
    '/// ��ָ�����쳣��Ϣд��ָ������־�ļ���
    '/// </summary>
    '/// <param name="ex">Ҫ��¼���쳣����</param>
    '/// <param name="fileName">ָ������־�ļ�����</param>
    '/// <returns></returns>
    Public Shared Function WriteLog(ByVal sourceException As System.Exception, ByVal fileName As String) As String
        Try
            Dim logEntry As SWSystem.XML.XMLLogEntry = SWSystem.XML.XMLLog.GetLogEntry(sourceException.Source, sourceException.Message, SWSystem.XML.XMLLogEntryType.Error, sourceException, "Exception")

            logEntry.Properties.Add("OS", System.Environment.OSVersion.Platform.ToString() + "[" + System.Environment.OSVersion.Version.ToString() + "]")
            logEntry.Properties.Add("CallAssembly", System.Reflection.Assembly.GetCallingAssembly().FullName)
            logEntry.Properties.Add("CommandLine", System.Environment.CommandLine)
            logEntry.Properties.Add("StackTrace", System.Environment.StackTrace)

            If (fileName Is Nothing OrElse fileName.Trim() = String.Empty) Then
                fileName = System.IO.Path.Combine(System.Environment.CurrentDirectory, System.Reflection.Assembly.GetEntryAssembly().GetName().Name + ".log")
            End If

            SWSystem.XML.XMLLog.WriteLog(fileName, logEntry)

            Return logEntry.ID
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("ϵͳ�޷�������־�ļ����뼴ʱ������ϵͳ����Ա��������ϵ��" + System.Environment.NewLine + System.Environment.NewLine + "�쳣��Դ��" + ex.Source + "[" + ex.GetType().FullName + "]" + Environment.NewLine + "�쳣��Ϣ��" + ex.Message, "ϵͳ�쳣", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try

        Return Nothing
    End Function

    '/// <summary>
    '/// ����ָ�����쳣������ʾ��Ӧ����Ϣ��
    '/// </summary>
    '/// <param name="sourceException">Ҫ��ʾ��Ϣ����Դ�쳣����</param>
    '/// <remarks>
    '/// ������� <see cref="sourceException">sourceException</see> �쳣��SoapException������ <seealso cref="SWSystem.XML.XMLLogEntry">SWSystem.XML.XMLLogEntry</seealso> ���������� <c>Detail</c> �����Ի��ԭʼ���쳣���������ȡ�ɹ��򽫸��쳣��Ϊ��Դ�쳣��
    '/// ������� <see cref="sourceException">sourceException</see> ��δ֪�쳣���ͻ� <seealso cref="System.Exception">System.Exception</seealso> ���ͣ�����ʾϵͳδ֪�쳣�������쳣д��ϵͳĬ����־��
    '/// </remarks>
    Public Overridable Overloads Sub ShowMessageBoxEx(ByVal sourceException As System.Exception)
        Try
            If (sourceException Is Nothing) Then
                Return
            End If

            Dim ex As System.Web.Services.Protocols.SoapException = Nothing

            If TypeOf sourceException Is System.Web.Services.Protocols.SoapException Then
                ex = CType(sourceException, System.Web.Services.Protocols.SoapException)
            End If

            If (Not ex Is Nothing) Then
                Dim logEntry As SWSystem.XML.XMLLogEntry = New SWSystem.XML.XMLLogEntry(ex.Detail.SelectSingleNode("logEntry"))

                If ((Not logEntry.Data Is Nothing) AndAlso TypeOf logEntry.Data Is System.Exception) Then
                    Throw CType(logEntry.Data, System.Exception)
                End If
            End If

            Throw sourceException
        Catch ex As System.ArgumentNullException
            If (Not Me.ShowMessageBox("$1234", ex.Source + "[" + ex.GetType().FullName + "]", ex.Message, ex.StackTrace)) Then
                Me.WriteLog(ex)
            End If
        Catch ex As System.Exception
            Me.ShowMessageBox(UNKNOWNERROR, ex.Source + "[" + ex.GetType().FullName + "]", ex.Message, ex.StackTrace)

            ExceptionHandler.WriteLog(ex, Nothing)
        End Try
    End Sub

    '/// <summary>
    '/// ˽�з�������ʾ��Ϣ�򣬼��봦����ʾ��Ϣ����쳣����
    '/// </summary>
    '/// <param name="messageID">��ʾ����Ϣ��š�</param>
    '/// <param name="args">��ʾ����Ϣ������</param>
    '/// <returns>�����ʾָ����Ϣ����Ϣ��ɹ�����Ϊ true������Ϊ false��</returns>
    '/// <remarks>���������Ϣ����ʾ������������ʾһ��������Ϣ�򲢽����쳣��¼��ϵͳĬ����־�ļ���</remarks>
    Private Overloads Function ShowMessageBox(ByVal messageID As String, ByVal ParamArray args As Object()) As Boolean
        Try
            SWDialogBox.MessageBox.Show(messageID, args)
            Return True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("��ʾ��Ϣ�� [" + messageID + "] ����" + System.Environment.NewLine + System.Environment.NewLine + _
                      "������Դ��" + ex.Source + System.Environment.NewLine + _
                      "������Ϣ��" + ex.Message, "ϵͳ�쳣", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

            Me.WriteLog(ex)
        End Try

        Return False
    End Function

    Public Overloads Shared Function ShowMessageBox(ByVal ex As System.Exception)
        SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
    End Function
End Class
