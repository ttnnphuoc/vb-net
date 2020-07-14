Imports DataAccess
Imports DevExpress.XtraReports.UI

Public Class ReportViewer

    Private Sub ReportViewer_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

        ' Load Data for report
        DataSource = HangHoa.GetAllHangHoa()
        xrMaVT.DataBindings.Add("Text", DataSource, "MAVT")
        xrMaPL.DataBindings.Add("Text", DataSource, "MAPL")
        xrTenVT.DataBindings.Add("Text", DataSource, "TENVT")
        xrGiaMua.DataBindings.Add("Text", DataSource, "GIAMUA", "{0:n0}")
        xrGiaBan.DataBindings.Add("Text", DataSource, "GIABAN", "{0:n0}")
        xrTyLe.DataBindings.Add("Text", DataSource, "TYLE")
        xrQuyCach.DataBindings.Add("Text", DataSource, "QUICACH")
        xrValueMaPL.DataBindings.Add("Text", DataSource, "MAPL")

        ' Group MAPL
        Dim group As New GroupField
        group = New GroupField("MAPL", XRColumnSortOrder.Ascending)
        GrpHeader.GroupFields.Add(group)

        ' Load Sub Report
        Dim subReport As New SubReport
        xrSubReport.ReportSource = subReport

        ' Sum Group
        SumTotal()
    End Sub

    ''' <summary>
    ''' Function Summary total
    ''' </summary>
    ''' <param name="_type"></param>
    ''' <param name="_func"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSummaryTotal(_type As SummaryRunning, _func As SummaryFunc) As XRSummary
        Dim xrSummary As New XRSummary()
        xrSummary.Func = _func
        xrSummary.Running = _type
        Return xrSummary
    End Function

    ''' <summary>
    ''' Function summary
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SumTotal()
        xrTotalGroupMAPL.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "MAPL")})
        xrTotalGroupMAPL.Summary = GetSummaryTotal(SummaryRunning.Group, SummaryFunc.Sum)

        xrTotalReport.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "MAPL")})
        xrTotalReport.Summary = GetSummaryTotal(SummaryRunning.Report, SummaryFunc.Sum)
    End Sub
End Class