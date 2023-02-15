Namespace DrillDownWebReport
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column13 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column14 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column15 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column16 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbShowHide = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Dpi = 100F
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.Weight = 1R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Icon_17"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Icon_25"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            columnExpression7.ColumnName = "ProductID"
            table2.Name = "Products"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "ProductName"
            columnExpression8.Table = table2
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "SupplierID"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "CategoryID"
            columnExpression10.Table = table2
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "QuantityPerUnit"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "UnitPrice"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "UnitsInStock"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "UnitsOnOrder"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ReorderLevel"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Discontinued"
            columnExpression16.Table = table2
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "EAN13"
            columnExpression17.Table = table2
            column17.Expression = columnExpression17
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.Columns.Add(column17)
            selectQuery2.Name = "Products"
            selectQuery2.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "Categories"
            masterDetailInfo1.Name = "CategoriesProducts"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.QuantityPerUnit")})
            Me.xrTableCell5.Dpi = 100F
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell2"
            Me.xrTableCell5.Weight = 1R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Dpi = 100F
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "Unit Price"
            Me.xrTableCell3.Weight = 1R
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.Dpi = 100F
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(70)))), (CInt((CByte(130)))), (CInt((CByte(180)))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(365.625F, 35.79165F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Dpi = 100F
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Dpi = 100F
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox2, Me.lbShowHide, Me.xrLabel3, Me.xrLabel1})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 97.20832F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:$0.00}")})
            Me.xrTableCell6.Dpi = 100F
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "xrTableCell3"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.Weight = 1R
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel3.Dpi = 100F
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 45.79166F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(365.625F, 28.41666F)
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Dpi = 100F
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "Quantity per Unit"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.GroupHeader1.Dpi = 100F
            Me.GroupHeader1.HeightF = 35.00001F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
            Me.xrTableCell4.Dpi = 100F
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell1"
            Me.xrTableCell4.Weight = 1R
            ' 
            ' lbShowHide
            ' 
            Me.lbShowHide.Dpi = 100F
            Me.lbShowHide.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline)
            Me.lbShowHide.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(70)))), (CInt((CByte(130)))), (CInt((CByte(180)))))
            Me.lbShowHide.LocationFloat = New DevExpress.Utils.PointFloat(10.00013F, 74.20832F)
            Me.lbShowHide.Name = "lbShowHide"
            Me.lbShowHide.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbShowHide.SizeF = New System.Drawing.SizeF(365.625F, 23F)
            Me.lbShowHide.StylePriority.UseFont = False
            Me.lbShowHide.StylePriority.UseForeColor = False
            Me.lbShowHide.Text = "Show Detail"
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox2.Dpi = 100F
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(483.75F, 10.00001F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(156.25F, 77.20831F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail1.Dpi = 100F
            Me.Detail1.HeightF = 25F
            Me.Detail1.Name = "Detail1"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.Dpi = 100F
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00012F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(629.9999F, 25F)
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UsePadding = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.Dpi = 100F
            Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00013F, 10.00001F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(629.9999F, 25F)
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UsePadding = False
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
            Me.DetailReport.DataMember = "Categories.CategoriesProducts"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Dpi = 100F
            Me.DetailReport.DrillDownControl = Me.lbShowHide
            Me.DetailReport.DrillDownExpanded = False
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "16.1"
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
        Private WithEvents lbShowHide As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

    End Class
End Namespace
