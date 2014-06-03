Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryFirstTrialProject
	Inherits FQueryBase

#Region " Windows ������������ɵĴ��� "

	Public Sub New()
		MyBase.New()

		'�õ����� Windows ���������������ġ�
		InitializeComponent()

		'�� InitializeComponent() ����֮������κγ�ʼ��

	End Sub

	'������д��������������б�
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Windows ����������������
	Private components As System.ComponentModel.IContainer

	'ע�⣺���¹����� Windows ����������������
	'����ʹ�� Windows ����������޸Ĵ˹��̡�
	'��Ҫʹ�ô���༭���޸�����
	Friend WithEvents lblProjectNo As System.Windows.Forms.Label
	Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
	Friend WithEvents lblCorporationName As System.Windows.Forms.Label
	Friend WithEvents cboCorporationName As System.Windows.Forms.ComboBox
	Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
	Friend WithEvents lblServiceType As System.Windows.Forms.Label
	Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
	Friend WithEvents lblRegion As System.Windows.Forms.Label
	Friend WithEvents cboIndustry As System.Windows.Forms.ComboBox
	Friend WithEvents lblIndustry As System.Windows.Forms.Label
	Friend WithEvents cboBank As System.Windows.Forms.ComboBox
	Friend WithEvents lblBank As System.Windows.Forms.Label
	Friend WithEvents cboProprietorship As System.Windows.Forms.ComboBox
	Friend WithEvents lblProprietorship As System.Windows.Forms.Label
	Friend WithEvents lblDate As System.Windows.Forms.Label
	Friend WithEvents chkDate As System.Windows.Forms.CheckBox
	Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCorporationName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplySum As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyTerm As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyBank As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csDistrict As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csIndustry As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csProprietorship As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csIsFirst As System.Windows.Forms.DataGridBoolColumn
	Friend WithEvents csRecommendPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csAcceptPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csAcceptDate As System.Windows.Forms.DataGridTextBoxColumn
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryFirstTrialProject))
		Me.lblProjectNo = New System.Windows.Forms.Label()
		Me.txtProjectNo = New System.Windows.Forms.TextBox()
		Me.lblCorporationName = New System.Windows.Forms.Label()
		Me.cboCorporationName = New System.Windows.Forms.ComboBox()
		Me.cboServiceType = New System.Windows.Forms.ComboBox()
		Me.lblServiceType = New System.Windows.Forms.Label()
		Me.cboRegion = New System.Windows.Forms.ComboBox()
		Me.lblRegion = New System.Windows.Forms.Label()
		Me.cboIndustry = New System.Windows.Forms.ComboBox()
		Me.lblIndustry = New System.Windows.Forms.Label()
		Me.cboBank = New System.Windows.Forms.ComboBox()
		Me.lblBank = New System.Windows.Forms.Label()
		Me.cboProprietorship = New System.Windows.Forms.ComboBox()
		Me.lblProprietorship = New System.Windows.Forms.Label()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.chkDate = New System.Windows.Forms.CheckBox()
		Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
		Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
		Me.tsTable = New System.Windows.Forms.DataGridTableStyle()
		Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csCorporationName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csApplyServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csApplySum = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csApplyTerm = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csApplyBank = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csDistrict = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csIndustry = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csProprietorship = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csIsFirst = New System.Windows.Forms.DataGridBoolColumn()
		Me.csRecommendPerson = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csAcceptPerson = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csAcceptDate = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.grpCondition.SuspendLayout()
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'chkVisible
		'
		Me.chkVisible.Visible = True
		'
		'btnPrint
		'
		Me.btnPrint.Visible = True
		'
		'grpCondition
		'
		Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpDateEnd, Me.dtpDateStart, Me.chkDate, Me.lblDate, Me.cboProprietorship, Me.lblProprietorship, Me.cboBank, Me.lblBank, Me.cboIndustry, Me.lblIndustry, Me.cboRegion, Me.lblRegion, Me.cboServiceType, Me.lblServiceType, Me.cboCorporationName, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo})
		Me.grpCondition.Visible = True
		'
		'btnRefresh
		'
		Me.btnRefresh.Visible = True
		'
		'btnExit
		'
		Me.btnExit.Visible = True
		'
		'grdTable
		'
		Me.grdTable.AccessibleName = "DataGrid"
		Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
		Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
		Me.grdTable.Visible = True
		'
		'btnClear
		'
		Me.btnClear.Visible = True
		'
		'btnExport
		'
		Me.btnExport.Visible = True
		'
		'lblProjectNo
		'
		Me.lblProjectNo.Location = New System.Drawing.Point(16, 24)
		Me.lblProjectNo.Name = "lblProjectNo"
		Me.lblProjectNo.Size = New System.Drawing.Size(64, 16)
		Me.lblProjectNo.TabIndex = 0
		Me.lblProjectNo.Text = "��Ŀ���"
		'
		'txtProjectNo
		'
		Me.txtProjectNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtProjectNo.Location = New System.Drawing.Point(80, 16)
		Me.txtProjectNo.Name = "txtProjectNo"
		Me.txtProjectNo.Size = New System.Drawing.Size(120, 22)
		Me.txtProjectNo.TabIndex = 1
		Me.txtProjectNo.Text = ""
		'
		'lblCorporationName
		'
		Me.lblCorporationName.Location = New System.Drawing.Point(256, 24)
		Me.lblCorporationName.Name = "lblCorporationName"
		Me.lblCorporationName.Size = New System.Drawing.Size(64, 16)
		Me.lblCorporationName.TabIndex = 2
		Me.lblCorporationName.Text = "��ҵ����"
		'
		'cboCorporationName
		'
		Me.cboCorporationName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCorporationName.Location = New System.Drawing.Point(320, 16)
		Me.cboCorporationName.Name = "cboCorporationName"
		Me.cboCorporationName.Size = New System.Drawing.Size(120, 22)
		Me.cboCorporationName.TabIndex = 3
		'
		'cboServiceType
		'
		Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboServiceType.Location = New System.Drawing.Point(560, 16)
		Me.cboServiceType.Name = "cboServiceType"
		Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
		Me.cboServiceType.TabIndex = 5
		'
		'lblServiceType
		'
		Me.lblServiceType.Location = New System.Drawing.Point(496, 24)
		Me.lblServiceType.Name = "lblServiceType"
		Me.lblServiceType.Size = New System.Drawing.Size(64, 16)
		Me.lblServiceType.TabIndex = 4
		Me.lblServiceType.Text = "ҵ��Ʒ��"
		'
		'cboRegion
		'
		Me.cboRegion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboRegion.Location = New System.Drawing.Point(80, 40)
		Me.cboRegion.Name = "cboRegion"
		Me.cboRegion.Size = New System.Drawing.Size(120, 22)
		Me.cboRegion.TabIndex = 7
		'
		'lblRegion
		'
		Me.lblRegion.Location = New System.Drawing.Point(16, 48)
		Me.lblRegion.Name = "lblRegion"
		Me.lblRegion.Size = New System.Drawing.Size(64, 16)
		Me.lblRegion.TabIndex = 6
		Me.lblRegion.Text = "��������"
		'
		'cboIndustry
		'
		Me.cboIndustry.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboIndustry.Location = New System.Drawing.Point(320, 40)
		Me.cboIndustry.Name = "cboIndustry"
		Me.cboIndustry.Size = New System.Drawing.Size(120, 22)
		Me.cboIndustry.TabIndex = 9
		'
		'lblIndustry
		'
		Me.lblIndustry.Location = New System.Drawing.Point(256, 48)
		Me.lblIndustry.Name = "lblIndustry"
		Me.lblIndustry.Size = New System.Drawing.Size(64, 16)
		Me.lblIndustry.TabIndex = 8
		Me.lblIndustry.Text = "������ҵ"
		'
		'cboBank
		'
		Me.cboBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBank.Location = New System.Drawing.Point(560, 40)
		Me.cboBank.Name = "cboBank"
		Me.cboBank.Size = New System.Drawing.Size(120, 22)
		Me.cboBank.TabIndex = 11
		'
		'lblBank
		'
		Me.lblBank.Location = New System.Drawing.Point(496, 48)
		Me.lblBank.Name = "lblBank"
		Me.lblBank.Size = New System.Drawing.Size(64, 16)
		Me.lblBank.TabIndex = 10
		Me.lblBank.Text = "��������"
		'
		'cboProprietorship
		'
		Me.cboProprietorship.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProprietorship.Location = New System.Drawing.Point(80, 64)
		Me.cboProprietorship.Name = "cboProprietorship"
		Me.cboProprietorship.Size = New System.Drawing.Size(120, 22)
		Me.cboProprietorship.TabIndex = 13
		'
		'lblProprietorship
		'
		Me.lblProprietorship.Location = New System.Drawing.Point(16, 72)
		Me.lblProprietorship.Name = "lblProprietorship"
		Me.lblProprietorship.Size = New System.Drawing.Size(64, 16)
		Me.lblProprietorship.TabIndex = 12
		Me.lblProprietorship.Text = "��������"
		'
		'lblDate
		'
		Me.lblDate.Location = New System.Drawing.Point(496, 72)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(64, 16)
		Me.lblDate.TabIndex = 15
		Me.lblDate.Text = "��"
		'
		'chkDate
		'
		Me.chkDate.Location = New System.Drawing.Point(240, 70)
		Me.chkDate.Name = "chkDate"
		Me.chkDate.Size = New System.Drawing.Size(80, 20)
		Me.chkDate.TabIndex = 16
		Me.chkDate.Text = "��������"
		'
		'dtpDateStart
		'
		Me.dtpDateStart.Enabled = False
		Me.dtpDateStart.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDateStart.Location = New System.Drawing.Point(320, 64)
		Me.dtpDateStart.Name = "dtpDateStart"
		Me.dtpDateStart.Size = New System.Drawing.Size(120, 21)
		Me.dtpDateStart.TabIndex = 17
		'
		'dtpDateEnd
		'
		Me.dtpDateEnd.Enabled = False
		Me.dtpDateEnd.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDateEnd.Location = New System.Drawing.Point(560, 64)
		Me.dtpDateEnd.Name = "dtpDateEnd"
		Me.dtpDateEnd.Size = New System.Drawing.Size(120, 21)
		Me.dtpDateEnd.TabIndex = 18
		'
		'tsTable
		'
		Me.tsTable.DataGrid = Me.grdTable
		Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csCorporationName, Me.csApplyServiceType, Me.csApplySum, Me.csApplyTerm, Me.csApplyBank, Me.csDistrict, Me.csIndustry, Me.csProprietorship, Me.csIsFirst, Me.csRecommendPerson, Me.csAcceptPerson, Me.csAcceptDate})
		Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsTable.MappingName = "TQueryFirstTrialProject"
		'
		'csProjectNo
		'
		Me.csProjectNo.Format = ""
		Me.csProjectNo.FormatInfo = Nothing
		Me.csProjectNo.HeaderText = "��Ŀ���"
		Me.csProjectNo.MappingName = "project_code"
		Me.csProjectNo.Width = 80
		'
		'csCorporationName
		'
		Me.csCorporationName.Format = ""
		Me.csCorporationName.FormatInfo = Nothing
		Me.csCorporationName.HeaderText = "��ҵ����"
		Me.csCorporationName.MappingName = "enterprise_name"
		Me.csCorporationName.Width = 200
		'
		'csApplyServiceType
		'
		Me.csApplyServiceType.Format = ""
		Me.csApplyServiceType.FormatInfo = Nothing
		Me.csApplyServiceType.HeaderText = "����ҵ��Ʒ��"
		Me.csApplyServiceType.MappingName = "apply_service_type"
		Me.csApplyServiceType.Width = 75
		'
		'csApplySum
		'
		Me.csApplySum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.csApplySum.Format = ""
		Me.csApplySum.FormatInfo = Nothing
		Me.csApplySum.HeaderText = "���뵣�����(��)"
		Me.csApplySum.MappingName = "apply_sum"
		Me.csApplySum.Width = 80
		'
		'csApplyTerm
		'
		Me.csApplyTerm.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.csApplyTerm.Format = ""
		Me.csApplyTerm.FormatInfo = Nothing
		Me.csApplyTerm.HeaderText = "���뵣������"
		Me.csApplyTerm.MappingName = "apply_term"
		Me.csApplyTerm.Width = 80
		'
		'csApplyBank
		'
		Me.csApplyBank.Format = ""
		Me.csApplyBank.FormatInfo = Nothing
		Me.csApplyBank.HeaderText = "�����������"
		Me.csApplyBank.MappingName = "apply_bank"
		'
		'csDistrict
		'
		Me.csDistrict.Format = ""
		Me.csDistrict.FormatInfo = Nothing
		Me.csDistrict.HeaderText = "������"
		Me.csDistrict.MappingName = "district_name"
		'
		'csIndustry
		'
		Me.csIndustry.Format = ""
		Me.csIndustry.FormatInfo = Nothing
		Me.csIndustry.HeaderText = "������ҵ"
		Me.csIndustry.MappingName = "industry_type"
		Me.csIndustry.Width = 80
		'
		'csProprietorship
		'
		Me.csProprietorship.Format = ""
		Me.csProprietorship.FormatInfo = Nothing
		Me.csProprietorship.HeaderText = "����������"
		Me.csProprietorship.MappingName = "proprietorship_type"
		Me.csProprietorship.Width = 150
		'
		'csIsFirst
		'
		Me.csIsFirst.FalseValue = False
		Me.csIsFirst.HeaderText = "�״δ���"
		Me.csIsFirst.MappingName = "is_first_loan"
		Me.csIsFirst.NullValue = CType(resources.GetObject("csIsFirst.NullValue"), System.DBNull)
		Me.csIsFirst.TrueValue = True
		Me.csIsFirst.Width = 60
		'
		'csRecommendPerson
		'
		Me.csRecommendPerson.Format = ""
		Me.csRecommendPerson.FormatInfo = Nothing
		Me.csRecommendPerson.HeaderText = "�Ƽ���"
		Me.csRecommendPerson.MappingName = "recommend_person"
		'
		'csAcceptPerson
		'
		Me.csAcceptPerson.Format = ""
		Me.csAcceptPerson.FormatInfo = Nothing
		Me.csAcceptPerson.HeaderText = "������Ա"
		Me.csAcceptPerson.MappingName = "accept_person"
		Me.csAcceptPerson.Width = 80
		'
		'csAcceptDate
		'
		Me.csAcceptDate.Format = "D"
		Me.csAcceptDate.FormatInfo = Nothing
		Me.csAcceptDate.HeaderText = "��������"
		Me.csAcceptDate.MappingName = "accept_date"
		'
		'FQueryFirstTrialProject
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(712, 493)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
		Me.Name = "FQueryFirstTrialProject"
		Me.Text = "������Ŀһ����"
		Me.grpCondition.ResumeLayout(False)
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

	Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef regionName As String, ByRef industryName As String, ByRef bankName As String, ByRef proprietorshipType As String, ByRef startDate As Object, ByRef endDate As Object)
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
		corporationName = IIf(cboCorporationName.Text.Trim() = "", "", cboCorporationName.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
		regionName = IIf(cboRegion.Text.Trim() = "", "", cboRegion.Text)
		industryName = IIf(cboIndustry.Text.Trim() = "", "", cboIndustry.Text)
		bankName = IIf(cboBank.Text.Trim() = "", "", cboBank.Text)
		proprietorshipType = IIf(cboProprietorship.Text.Trim() = "", "", cboProprietorship.Text)
		startDate = IIf(chkDate.Checked, dtpDateStart.Value, Nothing)
		endDate = IIf(chkDate.Checked, dtpDateEnd.Value, Nothing)
	End Sub

	Protected Overloads Overrides Sub Refresh(ByVal condition As String)
		Dim projectNo, corporationName, serviceType, regionName, industryName, bankName, proprietorshipType As String
		Dim startDate, endDate As Object

		GetCondition(projectNo, corporationName, serviceType, regionName, industryName, bankName, proprietorshipType, startDate, endDate)

		Dim dsResult As DataSet = gWs.PQueryFirstTrialProject(projectNo, corporationName, serviceType, startDate, endDate, bankName, regionName, industryName, proprietorshipType)

		dsResult.Tables("Table").TableName = "TQueryFirstTrialProject"

		MyBase.DataSource = dsResult
		grdTable.DataSource = dsResult
		grdTable.SetDataBinding(dsResult, "TQueryFirstTrialProject")
		Me.Text = "������Ŀһ����(" + dsResult.Tables("TQueryFirstTrialProject").Rows.Count.ToString + ")"
	End Sub

	Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboCorporationName.Enter, cboBank.Enter, cboRegion.Enter, cboIndustry.Enter, cboServiceType.Enter, cboProprietorship.Enter
		If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
			CType(sender, TextBox).SelectAll()
		End If
	End Sub

	Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
		dtpDateStart.Enabled = chkDate.Checked
		dtpDateEnd.Enabled = chkDate.Checked
	End Sub

	Private Sub FQueryFirstTrialProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dtpDateStart.Value = DateTime.Today
		dtpDateEnd.Value = DateTime.Today

		cboCorporationName.DataSource = gWs.GetcorporationInfo("%", "%").Tables(0)
		cboCorporationName.DisplayMember = "corporation_name"
		cboCorporationName.ValueMember = "corporation_name"

		cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
		cboServiceType.DisplayMember = "service_type"
		cboServiceType.ValueMember = "service_type"

		cboRegion.DataSource = gWs.GetDistrict("%").Tables(0)
		cboRegion.DisplayMember = "district_name"
		cboRegion.ValueMember = "district_name"

		cboIndustry.DataSource = gWs.GetIndustryType("%").Tables(0)
		cboIndustry.DisplayMember = "industry_type"
		cboIndustry.ValueMember = "industry_type"

		cboBank.DataSource = gWs.GetBankInfo("%", "%").Tables(0)
		cboBank.DisplayMember = "bank_name"
		cboBank.ValueMember = "bank_name"

		cboProprietorship.DataSource = gWs.GetProprietorshipType("%").Tables(0)
		cboProprietorship.DisplayMember = "proprietorship_type"
		cboProprietorship.ValueMember = "proprietorship_type"

		cboBank.SelectedItem = Nothing
		cboRegion.SelectedItem = Nothing
		cboIndustry.SelectedItem = Nothing
		cboServiceType.SelectedItem = Nothing
		cboProprietorship.SelectedItem = Nothing
		cboCorporationName.SelectedItem = Nothing

		MyBase.ReportTitle = "������Ŀһ����"
		MyBase.ReportFile = Application.StartupPath + "\Reports\QueryFirstTrialProject.rpt"
	End Sub
End Class
