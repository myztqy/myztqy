namespace map4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlAttribute = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapefileOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeTableOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOperations.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.menuStrip1);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1254, 100);
            this.pnlOperations.TabIndex = 0;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLegend.Location = new System.Drawing.Point(0, 100);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(200, 305);
            this.pnlLegend.TabIndex = 1;
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.pnlAttribute);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(200, 100);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(1054, 305);
            this.pnlMap.TabIndex = 2;
            // 
            // pnlAttribute
            // 
            this.pnlAttribute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAttribute.Location = new System.Drawing.Point(0, 205);
            this.pnlAttribute.Name = "pnlAttribute";
            this.pnlAttribute.Size = new System.Drawing.Size(1054, 100);
            this.pnlAttribute.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapefileOperationsToolStripMenuItem,
            this.mapOptionsToolStripMenuItem,
            this.attributeTableOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // shapefileOperationsToolStripMenuItem
            // 
            this.shapefileOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.polylineToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.shapefileOperationsToolStripMenuItem.Name = "shapefileOperationsToolStripMenuItem";
            this.shapefileOperationsToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.shapefileOperationsToolStripMenuItem.Text = "Shapefile Operations";
            // 
            // mapOptionsToolStripMenuItem
            // 
            this.mapOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.measurementToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomToExtentToolStripMenuItem,
            this.panToolStripMenuItem,
            this.printMapToolStripMenuItem});
            this.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            this.mapOptionsToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.mapOptionsToolStripMenuItem.Text = "Map Options";
            // 
            // attributeTableOperationsToolStripMenuItem
            // 
            this.attributeTableOperationsToolStripMenuItem.Name = "attributeTableOperationsToolStripMenuItem";
            this.attributeTableOperationsToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.attributeTableOperationsToolStripMenuItem.Text = "Attribute Table Operations";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPointShapefileToolStripMenuItem,
            this.savePointShapefileToolStripMenuItem});
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.pointToolStripMenuItem.Text = "Point ";
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolylineShapefileToolStripMenuItem,
            this.savePolylineShapefileToolStripMenuItem});
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.polylineToolStripMenuItem.Text = "Polyline";
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolygonShapefileToolStripMenuItem,
            this.polygonShapefileToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.polygonToolStripMenuItem.Text = "Polygon";
            // 
            // createPointShapefileToolStripMenuItem
            // 
            this.createPointShapefileToolStripMenuItem.Name = "createPointShapefileToolStripMenuItem";
            this.createPointShapefileToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.createPointShapefileToolStripMenuItem.Text = "Create Point Shapefile";
            // 
            // savePointShapefileToolStripMenuItem
            // 
            this.savePointShapefileToolStripMenuItem.Name = "savePointShapefileToolStripMenuItem";
            this.savePointShapefileToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.savePointShapefileToolStripMenuItem.Text = "Save Point Shapefile";
            // 
            // createPolylineShapefileToolStripMenuItem
            // 
            this.createPolylineShapefileToolStripMenuItem.Name = "createPolylineShapefileToolStripMenuItem";
            this.createPolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.createPolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile";
            // 
            // savePolylineShapefileToolStripMenuItem
            // 
            this.savePolylineShapefileToolStripMenuItem.Name = "savePolylineShapefileToolStripMenuItem";
            this.savePolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.savePolylineShapefileToolStripMenuItem.Text = "Save Polyline Shapefile";
            // 
            // createPolygonShapefileToolStripMenuItem
            // 
            this.createPolygonShapefileToolStripMenuItem.Name = "createPolygonShapefileToolStripMenuItem";
            this.createPolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.createPolygonShapefileToolStripMenuItem.Text = "Create Polygon Shapefile";
            // 
            // polygonShapefileToolStripMenuItem
            // 
            this.polygonShapefileToolStripMenuItem.Name = "polygonShapefileToolStripMenuItem";
            this.polygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.polygonShapefileToolStripMenuItem.Text = "Polygon Shapefile";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // measurementToolStripMenuItem
            // 
            this.measurementToolStripMenuItem.Name = "measurementToolStripMenuItem";
            this.measurementToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.measurementToolStripMenuItem.Text = "Measurement";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // zoomToExtentToolStripMenuItem
            // 
            this.zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
            this.zoomToExtentToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.zoomToExtentToolStripMenuItem.Text = "Zoom to Extent";
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.panToolStripMenuItem.Text = "Pan";
            // 
            // printMapToolStripMenuItem
            // 
            this.printMapToolStripMenuItem.Name = "printMapToolStripMenuItem";
            this.printMapToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.printMapToolStripMenuItem.Text = "Print Map";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 405);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlOperations);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlAttribute;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapefileOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeTableOperationsToolStripMenuItem;
    }
}

