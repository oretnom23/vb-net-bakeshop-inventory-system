Public Class frmReport
#Region "SELECT"
    Private Sub RDOSELECT(ByVal RDO As RadioButton)
        Try
            If RDO.Checked = True Then

                Select Case RDO.Text
                    Case "All"
                        query = "SELECT P.PROCODE AS [ProductCode], (PRONAME & ' ' & PRODESC) AS [Product],CATEGORY AS [Category], (PROPRICE & 'PHP') AS [Price],PROQTY  AS [Quantity] " &
                                " FROM  tblProductInfo AS P WHERE   CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"


                    Case "Stock-In"
                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product], (PROPRICE & 'PHP') AS [Price],RECEIVEDQTY   AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                                " FROM tblStockIn AS S,  tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"


                    Case "Sold"
                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product], (PROPRICE & 'PHP') AS [Price],OUTQTY  AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " &
                               " FROM tblStockOut AS S,  tblProductInfo AS P WHERE S.PROCODE=P.PROCODE  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                    Case "Today"

                        If RDO.Text = "Stock-In" Then
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                              " FROM tblStockIn AS S,  tblProductInfo AS P " &
                              " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = NOW() AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                        ElseIf RDO.Text = "Sold" Then
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],('Net/VolWt:' & PRONETWT & ' Price:' & PROPRICE & 'PHP') AS [Description],(OUTQTY & PROUNIT) AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " &
                            " FROM tblStockOut AS S,  tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATERECEIVED) = NOW()  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                        End If


                    Case "Weekly"
                        If RDO.Text = "Stock-In" Then
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                              " FROM tblStockIn AS S,  tblProductInfo AS P " &
                              " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND DATEVALUE(DATEPART(ww,DATEOUT)) =  DATEVALUE(DATEPART(ww,NOW())) AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                        ElseIf RDO.Text = "Sold" Then
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],('Net/VolWt:' & PRONETWT & ' Price:' & PROPRICE & 'PHP') AS [Description],(OUTQTY & PROUNIT) AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " &
                            " FROM tblStockOut AS S,  tblProductInfo AS P " &
                            " WHERE S.PROCODE=P.PROCODE  AND  MONTH(DATERECEIVED) = MONTH(NOW()) AND DATEVALUE(DATEPART(ww,DATEOUT)) =  DATEVALUE(DATEPART(ww,NOW()))  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                        End If
                    Case "Monthly"
                        If RDO.Text = "Stock-In" Then
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                              " FROM tblStockIn AS S,  tblProductInfo AS P " &
                              " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                        ElseIf RDO.Text = "Sold" Then
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],('Net/VolWt:' & PRONETWT & ' Price:' & PROPRICE & 'PHP') AS [Description],(OUTQTY & PROUNIT) AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " &
                            " FROM tblStockOut AS S,  tblProductInfo AS P  " &
                            " WHERE S.PROCODE=P.PROCODE  AND MONTH(DATERECEIVED) = MONTH(NOW())  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                        End If

                    Case Else


                End Select

                retrieve(query, dtglist)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


#End Region

#Region "RDO"
    Private Sub RDOCLEAR(ByVal ACTIONS As String, ByVal rdo As RadioButton)

        If rdo.Checked = True Then

            Select Case ACTIONS
                Case "Product"
                    rdoProduct.Checked = False


                Case "Transaction"
                    rdoStockIn.Checked = False
                    rdoStockOut.Checked = False
                    rdoMonthly.Checked = False
                    rdoWeekly.Checked = False
                    rdoToday.Checked = False

            End Select
            If rdo.Text <> "Today" And rdo.Text <> "21 days" And rdo.Text <> "Weekly" And rdo.Text <> "Monthly" Then
                LBLLIST.Text = "List of " & rdo.Text & " (" & cboCateg.Text & ")"
            End If


        End If


    End Sub
#End Region

    Private Sub rdoProduct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoProduct.CheckedChanged, BTNSEARCHGRID.Click
        RDOCLEAR("Transaction", rdoProduct)

        LBLLIST.Text = "List of Products (" & cboCateg.Text & ")"

        RDOSELECT(rdoProduct)

    End Sub

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        frmMaxMinSize(Me, 1018, 532)
        'pnlDate.Enabled = False
        rdoProduct.Checked = True
    End Sub
    Private Sub RDOCLEARDATE()
        rdoMonthly.Checked = False
        rdoWeekly.Checked = False
        rdoToday.Checked = False
    End Sub
    Private Sub rdoStockIn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStockIn.CheckedChanged, BTNSEARCHGRID.Click

        RDOCLEAR("Product", rdoStockIn)
        RDOCLEARDATE()
        RDOSELECT(rdoStockIn)
    End Sub

    Private Sub rdoStockOut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStockOut.CheckedChanged, BTNSEARCHGRID.Click

        RDOCLEAR("Product", rdoStockOut)
        RDOCLEARDATE()
        RDOSELECT(rdoStockOut)

    End Sub


    Private Sub rdoToday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoToday.Click, BTNSEARCHGRID.Click
        RDOCLEAR("Product", rdoToday)


        If rdoStockIn.Checked = True Then

            RDOCLEAR("Product", rdoStockIn)
            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],((ROUND(RECEIVEDQTY * PROPRICE)) & 'PHP') AS  [TotalPrice] " &
              " FROM tblStockIn AS S,  tblProductInfo AS P " &
              " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = DATEVALUE(NOW())  AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

        ElseIf rdoStockOut.Checked = True Then
            RDOCLEAR("Product", rdoStockOut)
            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],OUTQTY AS [Quantity],((ROUND(OUTQTY * PROPRICE)) & 'PHP') AS [TotalPrice] " &
            " FROM tblStockOut AS S,  tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATEOUT) =DATEVALUE(NOW())  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
        End If
        retrieve(query, dtglist)

    End Sub

    Private Sub rdoWeekly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWeekly.Click, BTNSEARCHGRID.Click

        RDOCLEAR("Product", rdoWeekly)

        If rdoStockIn.Checked = True Then
            RDOCLEAR("Product", rdoStockIn)
            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],((ROUND(RECEIVEDQTY * PROPRICE)) & 'PHP') AS [TotalPrice] " &
              " FROM tblStockIn AS S,  tblProductInfo AS P " &
              " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND  DATEPART('ww',DATEVALUE(DATERECEIVED)) =  DATEPART('ww',DATEVALUE(NOW()))  AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

        ElseIf rdoStockOut.Checked = True Then
            RDOCLEAR("Product", rdoStockOut)
            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],OUTQTY AS [Quantity],((ROUND(OUTQTY * PROPRICE)) & 'PHP') AS [TotalPrice] " &
            " FROM tblStockOut AS S,  tblProductInfo AS P " &
            " WHERE S.PROCODE=P.PROCODE  AND  MONTH(DATEOUT) = MONTH(NOW()) AND DatePart('ww',DATEVALUE(DATEOUT))= DatePart('ww',DATEVALUE(NOW()))  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
        End If
        retrieve(query, dtglist)

    End Sub

    Private Sub rdoMonthly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoMonthly.Click, BTNSEARCHGRID.Click
        If rdoStockIn.Checked = True Then
            RDOCLEAR("Product", rdoStockIn)
            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
              " FROM tblStockIn AS S,  tblProductInfo AS P " &
              " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

        ElseIf rdoStockOut.Checked = True Then
            RDOCLEAR("Product", rdoStockOut)
            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],OUTQTY AS [Quantity],((ROUND(OUTQTY * PROPRICE)) & 'PHP') AS  [TotalPrice] " &
            " FROM tblStockOut AS S,  tblProductInfo AS P  " &
            " WHERE S.PROCODE=P.PROCODE  AND MONTH(DATEOUT) = MONTH(NOW())  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

        End If
        retrieve(query, dtglist)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try

            If rdoProduct.Checked = True Then
                rdoStockOut.Checked = True
            End If


            Dim dfrom As Date = dtpFrom.Text
            Dim dto As Date = dtpTo.Text

            If rdoStockIn.Checked = True Then
                LBLLIST.Text = "Stock of " & cboCateg.Text & " from " & dfrom & " to " & dto
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],RECEIVEDQTY  AS [Quantity],((ROUND(RECEIVEDQTY * PROPRICE)) & 'PHP') AS [TotalPrice] " &
                  " FROM tblStockIn AS S,  tblProductInfo AS P " &
                  " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) BETWEEN #" & dfrom & "# AND #" & dto & "#  AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

            ElseIf rdoStockOut.Checked = True Then
                LBLLIST.Text = "Sold " & cboCateg.Text & " from " & dfrom & " to " & dto
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE & 'PHP') AS [Price],OUTQTY   AS [Quantity],((ROUND(OUTQTY * PROPRICE)) & 'PHP') AS [TotalPrice] " &
                " FROM tblStockOut AS S,  tblProductInfo AS P  " &
                " WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATEOUT) BETWEEN #" & dfrom & "# AND #" & dto & "#  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

            End If
            retrieve(query, dtglist)
        Catch ex As Exception


        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
#Region "Reports"
    Private Sub RDOSELECTREPORT(ByVal RDO As RadioButton, ByVal rptname As String, ByVal cryrpt As Object)
        Try
            If RDO.Checked = True Then

                Select Case RDO.Text
                    Case "All"
                        query = "SELECT * " &
                                " FROM  tblProductInfo WHERE   CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"


                    Case "Stock-In"
                        query = "SELECT * " &
                                " FROM tblStockIn AS S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"

                    Case "Sold"
                        query = "SELECT * FROM tblStockOut AS S,  tblProductInfo AS P WHERE S.PROCODE=P.PROCODE  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"



                End Select

                reports(query, rptname, cryrpt)
                ShowForm(Me, frmPrintPreview)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


#End Region

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Try
            Dim dfrom As Date = dtpFrom.Text
            Dim dto As Date = dtpTo.Text

            If LBLLIST.Text = "Stock of " & cboCateg.Text & " from " & dfrom & " to " & dto Then
                query = "SELECT  P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE) AS [Price],RECEIVEDQTY  AS [Quantity],((ROUND(RECEIVEDQTY * PROPRICE)) ) AS [TotalPrice] " &
                " FROM tblStockIn AS S,  tblProductInfo AS P " &
                " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) BETWEEN #" & dfrom & "# AND #" & dto & "#  AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                reports(query, "stockinasof", frmPrintPreview.CrystalReportViewer1)
                ShowForm(Me, frmPrintPreview)
            ElseIf LBLLIST.Text = "Sold " & cboCateg.Text & " from " & dfrom & " to " & dto Then
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE) AS [Price],OUTQTY   AS [Quantity],((ROUND(OUTQTY * PROPRICE))) AS [TotalPrice] " &
                 " FROM tblStockOut AS S,  tblProductInfo AS P  " &
                 " WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATEOUT) BETWEEN #" & dfrom & "# AND #" & dto & "#  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                reports(query, "stockoutasof", frmPrintPreview.CrystalReportViewer1)
                ShowForm(Me, frmPrintPreview)
            Else
                If rdoToday.Checked = True Then

                    If rdoStockIn.Checked = True Then
                        'RDOSELECTREPORT(rdoToday, "dailystockin", frmPrintPreview.CrystalReportViewer1)
                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],(PROPRICE) AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                              " FROM tblStockIn AS S,  tblProductInfo AS P " &
                              " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = DATEVALUE(NOW()) AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                        reports(query, "dailystockin", frmPrintPreview.CrystalReportViewer1)
                        ShowForm(Me, frmPrintPreview)

                    ElseIf rdoStockOut.Checked = True Then
                        'RDOSELECTREPORT(rdoToday, "dailystockout", frmPrintPreview.CrystalReportViewer1)
                        query = "SELECT TRANSNUM, P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product], (OUTQTY) AS [Quantity],PROPRICE as [Price], (ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " &
                           " FROM tblStockOut AS S,  tblProductInfo AS P  WHERE S.PROCODE=P.PROCODE  AND  DATEVALUE(DATEOUT)  = DATEVALUE(NOW())  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                        reports(query, "dailystockout", frmPrintPreview.CrystalReportViewer1)
                        ShowForm(Me, frmPrintPreview)

                    End If

                ElseIf rdoWeekly.Checked = True Then

                    If rdoStockIn.Checked = True Then

                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],PROPRICE AS [Price],RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                              " FROM tblStockIn AS S,  tblProductInfo AS P " &
                              " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND DATEPART('ww',DATEVALUE(DATERECEIVED)) =  DATEPART('ww',DATEVALUE(NOW())) AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                        reports(query, "weeklystockins", frmPrintPreview.CrystalReportViewer1)
                        ShowForm(Me, frmPrintPreview)

                    ElseIf rdoStockOut.Checked = True Then

                        query = "SELECT TRANSNUM, P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product], OUTQTY AS [Quantity],PROPRICE as [Price], (ROUND(OUTQTY * PROPRICE)) AS [TotalPrice]  " &
                         " FROM tblStockOut AS S,  tblProductInfo AS P " &
                         " WHERE S.PROCODE=P.PROCODE  AND  MONTH(DATEOUT) = MONTH(NOW()) AND DATEPART('ww',DATEVALUE(DATEOUT)) =  DATEPART('ww',DATEVALUE(NOW()))  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                        reports(query, "weeklystockout", frmPrintPreview.CrystalReportViewer1)
                        ShowForm(Me, frmPrintPreview)

                    End If

                ElseIf rdoMonthly.Checked = True Then

                    If rdoStockIn.Checked = True Then
                        'RDOSELECTREPORT(rdoMonthly, "monthlystockin", frmPrintPreview.CrystalReportViewer1)
                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME & ' ' & PRODESC) AS [Product],PROPRICE,RECEIVEDQTY  AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " &
                           " FROM tblStockIn AS S,  tblProductInfo AS P " &
                           " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" & txtSearch.Text & "%' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                        reports(query, "monthlystockin", frmPrintPreview.CrystalReportViewer1)
                        ShowForm(Me, frmPrintPreview)
                    ElseIf rdoStockOut.Checked = True Then
                        'RDOSELECTREPORT(rdoMonthly, "monthlystockout", frmPrintPreview.CrystalReportViewer1)
                        query = "SELECT TRANSNUM, P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME & ' ' & PRODESC) AS [Product], (OUTQTY) AS [Quantity],PROPRICE as [Price], (ROUND(OUTQTY * PROPRICE)) AS [TotalPrice]  " &
                           " FROM tblStockOut AS S,  tblProductInfo AS P  " &
                           " WHERE S.PROCODE=P.PROCODE  AND MONTH(DATEOUT) = MONTH(NOW())  AND CATEGORY ='" & cboCateg.Text & "' AND PRONAME LIKE '%" & txtSearch.Text & "%'"
                        reports(query, "monthlystockout", frmPrintPreview.CrystalReportViewer1)
                        ShowForm(Me, frmPrintPreview)
                    End If

                Else
                    If rdoProduct.Checked = True Then
                        RDOSELECTREPORT(rdoProduct, "listofproducts", frmPrintPreview.CrystalReportViewer1)
                    ElseIf rdoStockIn.Checked = True Then
                        RDOSELECTREPORT(rdoStockIn, "stockinCMD", frmPrintPreview.CrystalReportViewer1)
                    ElseIf rdoStockOut.Checked = True Then
                        RDOSELECTREPORT(rdoStockOut, "stockoutCMD", frmPrintPreview.CrystalReportViewer1)
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class