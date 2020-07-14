Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports Common
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Collections
Imports System.Reflection
Imports DataAccess
Imports DevExpress.XtraReports.UI

Partial Public Class FormAction
    Inherits DevExpress.XtraEditors.XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Dim ctrCommon As New ControlHelper
    Dim funcCommon As New FuncCommon
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnDistrict_Click(sender As Object, e As EventArgs) Handles btnLoadHangHoa.Click
        grcData.DataSource = HangHoa.GetAllHangHoa()
    End Sub

    Private Sub FormAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrCommon.loadDataSearchLookup(sluHangHoa, HangHoa.GetAllHangHoa(), "TENVT", "MAVT")
        ctrCommon.loadDataSearchLookup(sluPhanLoai, PhanLoai.GetAllPhanLoai(), "TEN", "MAPL")
    End Sub

    Private Sub sluContry_EditValueChanged(sender As Object, e As EventArgs) Handles sluHangHoa.EditValueChanged
        Dim hangHoa As HangHoa = DirectCast(sluHangHoa.Properties.View.GetRow(sluHangHoa.Properties.GetIndexByKeyValue(sluHangHoa.EditValue)), HangHoa)
        ctrCommon.addNewRowToGridView(grcData, hangHoa)
    End Sub

    Public Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim data As List(Of HangHoa) = DirectCast(grcData.DataSource, List(Of HangHoa))
        If data Is Nothing Or data.Count = 0 Then
            MsgBox("Không có dữ liệu", MsgBoxStyle.Information, "Thông Báo")
        Else
            Dim frm = New FrmExportImport
            frm.isImport = False
            frm.dataExport = funcCommon.ConvertToDataTable(data)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Dim frm = New FrmSendMail
        frm.ShowDialog()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim frm = New FrmExportImport
        frm.isImport = True
        frm.ShowDialog()
        grcData.DataSource = frm.dataImport
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim visibleRowHandle As Integer = GridView1.FocusedRowHandle
        If visibleRowHandle < 0 Then
            MsgBox("Không có dữ liệu", MsgBoxStyle.Information, "Thông Báo")
            Return
        End If
        Dim value = GridView1.GetRowCellValue(visibleRowHandle, GridView1.Columns(0))
        Dim frm = New FrmDetail
        frm.id = DirectCast(value, Integer)
        frm.ShowDialog()
    End Sub

    Private Sub btnLoadReport_Click(sender As Object, e As EventArgs) Handles btnLoadReport.Click
        Dim rp As New ReportViewer
        Dim tool As ReportPrintTool = New ReportPrintTool(rp)
        rp.CreateDocument()
        rp.ShowPreview()
    End Sub

    'Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    '    Dim frm = New GridControlExample
    '    frm.ShowDialog()
    'End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm = New XtraFormGridViewDevexpress
        frm.ShowDialog()
    End Sub
End Class
