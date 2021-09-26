using C1.Win.C1Tile;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Gallery_Demo
{
    public partial class ImageGallery : Form
    {
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox _search;
        private TextBox _searchBox;
        private Panel panel2;
        private PictureBox _exportImage;
        private C1TileControl _imageTileControl;
        private Group group1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private C1.C1Pdf.C1PdfDocument c1PdfDocument1;
        public ImageGallery()
        {
            loadCompoent();
            InitializeComponent();
            loadfromjson();
        }

        void loadCompoent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGallery));
            PanelElement panelElement1 = new PanelElement();
            ImageElement imageElement1 = new ImageElement();
            TextElement textElement1 = new TextElement();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            _searchBox = new TextBox();
            panel2 = new Panel();
            _search = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            _imageTileControl = new C1TileControl();
            group1 = new Group();
         
            _exportImage = new PictureBox();
            c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(_search)).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(_exportImage)).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Panel2.Controls.Add(_imageTileControl);
            splitContainer1.Panel2.Controls.Add(_exportImage);
            splitContainer1.Size = new Size(857, 941);
            splitContainer1.SplitterDistance = 40;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(857, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(_searchBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(345, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 32);
            panel1.TabIndex = 0;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            // 
            // _searchBox
            // 
            _searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _searchBox.BorderStyle = BorderStyle.None;
            _searchBox.Location = new Point(18, 11);
            _searchBox.Margin = new Padding(3, 4, 3, 4);
            _searchBox.Name = "_searchBox";
            _searchBox.Size = new Size(275, 19);
            _searchBox.TabIndex = 0;
            _searchBox.Text = "Search Image";
            // 
            // panel2
            // 
            panel2.Controls.Add(_search);
            panel2.Location = new Point(601, 15);
            panel2.Margin = new Padding(2, 15, 51, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 10);
            panel2.TabIndex = 1;
            // 
            // _search
            // 
            _search.Anchor = AnchorStyles.Top
                             | AnchorStyles.Bottom
                             | AnchorStyles.Left
                             | AnchorStyles.Right;
            _search.ErrorImage = Properties.Resources.icon;
            _search.Image = (Image)resources.GetObject("_search.Image");
            _search.Location = new Point(0, 0);
            _search.Margin = new Padding(3, 4, 3, 4);
            _search.Name = "_search";
            _search.Size = new Size(45, 10);
            _search.SizeMode = PictureBoxSizeMode.Zoom;
            _search.TabIndex = 0;
            _search.TabStop = false;
            _search.Click += new EventHandler(_search_Click);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] {
            toolStripProgressBar1});
            statusStrip1.Location = new Point(0, 856);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(857, 30);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(112, 22);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // _imageTileControl
            // 
            _imageTileControl.AllowChecking = true;
            _imageTileControl.AllowRearranging = true;
            _imageTileControl.CellHeight = 93;
            _imageTileControl.CellSpacing = 13;
            _imageTileControl.CellWidth = 93;
            // 
            // 
            // 
            panelElement1.Alignment = ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.ChildSpacing = 6;
            panelElement1.Margin = new Padding(12, 7, 12, 7);
            _imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            _imageTileControl.GroupPadding = new Padding(24, 48, 24, 24);
            _imageTileControl.Groups.Add(group1);
            _imageTileControl.GroupTextX = 24;
            _imageTileControl.GroupTextY = 6;
            _imageTileControl.Location = new Point(0, 46);
            _imageTileControl.Margin = new Padding(3, 4, 3, 4);
            _imageTileControl.Name = "_imageTileControl";
            _imageTileControl.Padding = new Padding(0, 71, 0, 0);
            _imageTileControl.Size = new Size(860, 898);
            _imageTileControl.SurfacePadding = new Padding(14, 5, 14, 5);
            _imageTileControl.SwipeDistance = 24;
            _imageTileControl.SwipeRearrangeDistance = 116;
            _imageTileControl.TabIndex = 1;
            _imageTileControl.TextX = 42;
            _imageTileControl.TextY = 18;
            _imageTileControl.UncheckTilesOnClick = false;
            _imageTileControl.TileChecked += new EventHandler<TileEventArgs>(_imageTileControl_TileChecked);
            _imageTileControl.TileUnchecked += new EventHandler<TileEventArgs>(_imageTileControl_TileUnchecked);
            _imageTileControl.Paint += new PaintEventHandler(_imageTileControl_Paint);
            // 
            // group1
            // 
            group1.Name = "group1";
          
            // 
            // _exportImage
            // 
            _exportImage.Image = (Image)resources.GetObject("_exportImage.Image");
            _exportImage.Location = new Point(33, 4);
            _exportImage.Margin = new Padding(3, 4, 3, 4);
            _exportImage.Name = "_exportImage";
            _exportImage.Size = new Size(152, 35);
            _exportImage.SizeMode = PictureBoxSizeMode.StretchImage;
            _exportImage.TabIndex = 0;
            _exportImage.TabStop = false;
            _exportImage.Visible = false;
            _exportImage.Click += new EventHandler(_exportImage_Click);
            _exportImage.Paint += new PaintEventHandler(_exportImage_Paint);
            // 
            // c1PdfDocument1
            // 
            c1PdfDocument1.DocumentInfo.Author = "";
            c1PdfDocument1.DocumentInfo.CreationDate = new DateTime(0);
            c1PdfDocument1.DocumentInfo.Creator = "";
            c1PdfDocument1.DocumentInfo.Keywords = "";
            c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            c1PdfDocument1.DocumentInfo.Subject = "";
            c1PdfDocument1.DocumentInfo.Title = "";
            c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            c1PdfDocument1.PdfVersion = "1.3";
            c1PdfDocument1.RefDC = null;
            c1PdfDocument1.RotateAngle = 0F;
            c1PdfDocument1.UseFastTextOut = true;
            c1PdfDocument1.UseFontShaping = true;
            // 
            // ImageGallery
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 941);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(908, 998);
            Name = "ImageGallery";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Image Gallery";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_search).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_exportImage).EndInit();
            ResumeLayout(false);
        }

        DataFetcher datafetch = new DataFetcher();
        int checkedItems = 0;

        private void AddTiles(List<ImageItem> imageList)
        {
            _imageTileControl.Groups[0].Tiles.Clear();
            foreach (var imageitem in imageList)
            {
                Tile tile = new Tile();
                tile.HorizontalSize = 2;
                tile.VerticalSize = 2;
                _imageTileControl.Groups[0].Tiles.Add(tile);
                Image img = Image.FromStream(new
                MemoryStream(imageitem.Base64));
                Template tl = new Template();
                ImageElement ie = new ImageElement();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
                tile.Click += Tile_Click;
            }
        }
        private void Tile_Click(object sender, EventArgs e)
        {
            var tile = (Tile)sender;
            tile.Checked = !tile.Checked;
        }

        private void ConvertToPdf(List<Image> images)
        {
            RectangleF rect = c1PdfDocument1.PageRectangle;
            bool firstPage = true;
            foreach (var selectedimg in images)
            {
                if (!firstPage)
                {
                    c1PdfDocument1.NewPage();
                }
                firstPage = false;
                rect.Inflate(-72, -72);
                c1PdfDocument1.DrawImage(selectedimg, rect);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);

        }

        private async void _search_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            AddTiles(await datafetch.GetImageData(_searchBox.Text));
            statusStrip1.Visible = false;
        }


        private async void loadfromjson()
        {
            AddTiles(await datafetch.GetImageData(string.Empty));
        }

        private void _exportImage_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                }
            }
            ConvertToPdf(images);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                c1PdfDocument1.Save(saveFile.FileName);
            }
        }

        private void _exportImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_exportImage.Location.X, _exportImage.Location.Y, _exportImage.Width, _exportImage.Height);
            r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new
            Point(Width, 43));
        }

        private void _imageTileControl_TileChecked(object sender, TileEventArgs e)
        {
            checkedItems++;
            _exportImage.Visible = true;
        }

        private void _imageTileControl_TileUnchecked(object sender, TileEventArgs e)
        {
            checkedItems--;
            _exportImage.Visible = checkedItems > 0;

        }

        private void _imageTileControl_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);

        }
    }
}
