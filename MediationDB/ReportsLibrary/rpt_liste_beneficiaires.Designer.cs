namespace MediationDB.ReportsLibrary
{
    partial class rpt_liste_beneficiaires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_liste_beneficiaires));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_db_foncier";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "liste_beneficiaires";
            storedProcQuery1.StoredProcName = "liste_beneficiaires";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            // 
            // GroupCaption1
            // 
            this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.GroupCaption1.BorderColor = System.Drawing.Color.White;
            this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption1.BorderWidth = 2F;
            this.GroupCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption1.Name = "GroupCaption1";
            this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254F);
            this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData1
            // 
            this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.GroupData1.BorderColor = System.Drawing.Color.White;
            this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData1.BorderWidth = 2F;
            this.GroupData1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupData1.ForeColor = System.Drawing.Color.White;
            this.GroupData1.Name = "GroupData1";
            this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254F);
            this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 5, 0, 0, 254F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2,
            this.xrPictureBox1});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 343.4294F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 150F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 152.4F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("code_distribution", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 68.58F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader2.Dpi = 254F;
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("id_localite", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 68.58F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.GroupHeader3.Dpi = 254F;
            this.GroupHeader3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("id_executant", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader3.HeightF = 68.58F;
            this.GroupHeader3.Level = 3;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // GroupHeader4
            // 
            this.GroupHeader4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table4});
            this.GroupHeader4.Dpi = 254F;
            this.GroupHeader4.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader4.HeightF = 71.12F;
            this.GroupHeader4.Level = 4;
            this.GroupHeader4.Name = "GroupHeader4";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table5});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 63.42F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label2});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 15.24F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // pageInfo1
            // 
            this.pageInfo1.Dpi = 254F;
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(16F, 16F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(1403F, 58F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.Dpi = 254F;
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(1451F, 16F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(1403F, 58F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // label1
            // 
            this.label1.Dpi = 254F;
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(16F, 16F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(2838F, 61.45361F);
            this.label1.StyleName = "Title";
            this.label1.Text = "Liste des bénéficiaires d\'AGR";
            // 
            // table1
            // 
            this.table1.Dpi = 254F;
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.08F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(2870F, 63.5F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Dpi = 254F;
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Dpi = 254F;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "GroupCaption1";
            this.tableCell1.Text = "CODE DISTRIBUTION";
            this.tableCell1.Weight = 0.11119431552155923D;
            // 
            // tableCell2
            // 
            this.tableCell2.Dpi = 254F;
            this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[code_distribution]")});
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "GroupData1";
            this.tableCell2.Weight = 0.88880568447844077D;
            // 
            // table2
            // 
            this.table2.Dpi = 254F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.08F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(2870F, 63.5F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4});
            this.tableRow2.Dpi = 254F;
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Dpi = 254F;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "GroupCaption1";
            this.tableCell3.Text = "ID LOCALITE";
            this.tableCell3.Weight = 0.070626070773559993D;
            // 
            // tableCell4
            // 
            this.tableCell4.Dpi = 254F;
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id_localite]")});
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "GroupData1";
            this.tableCell4.Weight = 0.92937394517639371D;
            // 
            // table3
            // 
            this.table3.Dpi = 254F;
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.08F);
            this.table3.Name = "table3";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(2870F, 63.5F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5,
            this.tableCell6});
            this.tableRow3.Dpi = 254F;
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 1D;
            // 
            // tableCell5
            // 
            this.tableCell5.Dpi = 254F;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "GroupCaption1";
            this.tableCell5.Text = "ID EXECUTANT";
            this.tableCell5.Weight = 0.08190080596179497D;
            // 
            // tableCell6
            // 
            this.tableCell6.Dpi = 254F;
            this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id_executant]")});
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "GroupData1";
            this.tableCell6.Weight = 0.91809915682164633D;
            // 
            // table4
            // 
            this.table4.Dpi = 254F;
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table4.Name = "table4";
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
            this.table4.SizeF = new System.Drawing.SizeF(2870F, 71.12F);
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15});
            this.tableRow4.Dpi = 254F;
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 1D;
            // 
            // tableCell7
            // 
            this.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell7.Dpi = 254F;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.StylePriority.UseBorders = false;
            this.tableCell7.Text = "date distribution";
            this.tableCell7.Weight = 0.17959041794833405D;
            // 
            // tableCell8
            // 
            this.tableCell8.Dpi = 254F;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailCaption1";
            this.tableCell8.Text = "id agr";
            this.tableCell8.Weight = 0.078130093351889154D;
            // 
            // tableCell9
            // 
            this.tableCell9.Dpi = 254F;
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailCaption1";
            this.tableCell9.Text = "description agr";
            this.tableCell9.Weight = 0.16749197398328616D;
            // 
            // tableCell10
            // 
            this.tableCell10.Dpi = 254F;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "DetailCaption1";
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.Text = "qte";
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell10.Weight = 0.053855614213577964D;
            // 
            // tableCell11
            // 
            this.tableCell11.Dpi = 254F;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailCaption1";
            this.tableCell11.StylePriority.UseTextAlignment = false;
            this.tableCell11.Text = "valeur";
            this.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell11.Weight = 0.082570071336699691D;
            // 
            // tableCell12
            // 
            this.tableCell12.Dpi = 254F;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "DetailCaption1";
            this.tableCell12.Text = "id categorie";
            this.tableCell12.Weight = 0.13551053037211455D;
            // 
            // tableCell13
            // 
            this.tableCell13.Dpi = 254F;
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailCaption1";
            this.tableCell13.Text = "id beneficiaire";
            this.tableCell13.Weight = 0.15758441566174869D;
            // 
            // tableCell14
            // 
            this.tableCell14.Dpi = 254F;
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailCaption1";
            this.tableCell14.Text = "noms";
            this.tableCell14.Weight = 0.07702494232496733D;
            // 
            // tableCell15
            // 
            this.tableCell15.Dpi = 254F;
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "DetailCaption1";
            this.tableCell15.Text = "sexe";
            this.tableCell15.Weight = 0.068241924857428679D;
            // 
            // table5
            // 
            this.table5.Dpi = 254F;
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table5.Name = "table5";
            this.table5.OddStyleName = "DetailData3_Odd";
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(2870F, 63.42F);
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell16,
            this.tableCell17,
            this.tableCell18,
            this.tableCell19,
            this.tableCell20,
            this.tableCell21,
            this.tableCell22,
            this.tableCell23,
            this.tableCell24});
            this.tableRow5.Dpi = 254F;
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 11.683999633789062D;
            // 
            // tableCell16
            // 
            this.tableCell16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell16.Dpi = 254F;
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[date_distribution]")});
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "DetailData1";
            this.tableCell16.StylePriority.UseBorders = false;
            this.tableCell16.Weight = 0.17959041794833405D;
            // 
            // tableCell17
            // 
            this.tableCell17.Dpi = 254F;
            this.tableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id_agr]")});
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StyleName = "DetailData1";
            this.tableCell17.Weight = 0.078130093351889154D;
            // 
            // tableCell18
            // 
            this.tableCell18.Dpi = 254F;
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[description_agr]")});
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.StyleName = "DetailData1";
            this.tableCell18.Weight = 0.16749197398328616D;
            // 
            // tableCell19
            // 
            this.tableCell19.Dpi = 254F;
            this.tableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qte]")});
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.StyleName = "DetailData1";
            this.tableCell19.StylePriority.UseTextAlignment = false;
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell19.TextFormatString = "{0:C2}";
            this.tableCell19.Weight = 0.053855614213577964D;
            // 
            // tableCell20
            // 
            this.tableCell20.Dpi = 254F;
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[valeur]")});
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.StyleName = "DetailData1";
            this.tableCell20.StylePriority.UseTextAlignment = false;
            this.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell20.TextFormatString = "{0:C2}";
            this.tableCell20.Weight = 0.082570071336699691D;
            // 
            // tableCell21
            // 
            this.tableCell21.Dpi = 254F;
            this.tableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id_categorie]")});
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.StyleName = "DetailData1";
            this.tableCell21.Weight = 0.13551053037211455D;
            // 
            // tableCell22
            // 
            this.tableCell22.Dpi = 254F;
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id_beneficiaire]")});
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.StyleName = "DetailData1";
            this.tableCell22.Weight = 0.15758441566174869D;
            // 
            // tableCell23
            // 
            this.tableCell23.Dpi = 254F;
            this.tableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[noms]")});
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.StyleName = "DetailData1";
            this.tableCell23.Weight = 0.07702494232496733D;
            // 
            // tableCell24
            // 
            this.tableCell24.Dpi = 254F;
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sexe]")});
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "DetailData1";
            this.tableCell24.Weight = 0.068241898274172472D;
            // 
            // label2
            // 
            this.label2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label2.Dpi = 254F;
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label2.Name = "label2";
            this.label2.SizeF = new System.Drawing.SizeF(2870F, 5.2832F);
            this.label2.StyleName = "GroupFooterBackground3";
            this.label2.StylePriority.UseBorders = false;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Dpi = 254F;
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::MediationDB.Properties.Resources.ISSSS, true);
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(15.23998F, 25.40002F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(881.6975F, 318.0293F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::MediationDB.Properties.Resources.UNHABITAT_svg, true);
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(2083.446F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(761.5537F, 343.4294F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // rpt_liste_beneficiaires
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupHeader3,
            this.GroupHeader4,
            this.Detail,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "liste_beneficiaires";
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 343, 150);
            this.PageHeight = 2100;
            this.PageWidth = 2970;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader4;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    }
}
