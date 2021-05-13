#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Licensing;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private Members
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        # endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //			
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
           //
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(286, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
                      this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 89);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            // this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
              this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customtag Document";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

        # region Events
        private void button1_Click(object sender, System.EventArgs e)
        {			

            PdfFont fontnormal = new PdfStandardFont(PdfFontFamily.TimesRoman, 10);
            PdfFont fontTitle = new PdfStandardFont(PdfFontFamily.TimesRoman, 22, PdfFontStyle.Bold);
            PdfFont fontHead = new PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Bold);
            PdfFont fontHead2 = new PdfStandardFont(PdfFontFamily.TimesRoman, 16, PdfFontStyle.Bold);

            #region content string
            string pdfChapter = "We�ll begin with a conceptual overview of a simple PDF document. This chapter is designed to be a brief orientation before diving in and creating a real document from scratch \r\n \r\n A PDF file can be divided into four parts: a header, body, cross-reference table, and trailer. The header marks the file as a PDF, the body defines the visible document, the cross-reference table lists the location of everything in the file, and the trailer provides instructions for how to start reading the file.";
            string header = "The header is simply a PDF version number and an arbitrary sequence of binary data.The binary data prevents na�ve applications from processing the PDF as a text file. This would result in a corrupted file, since a PDF typically consists of both plain text and binary data (e.g., a binary font file can be directly embedded in a PDF).";
            string body = "The page tree serves as the root of the document. In the simplest case, it is just a list of the pages in the document. Each page is defined as an independent entity with metadata (e.g., page dimensions) and a reference to its resources and content, which are defined separately. Together, the page tree and page objects create the �paper� that composes the document.\r\n \r\n  Resources are objects that are required to render a page. For example, a single font is typically used across several pages, so storing the font information in an external resource is much more efficient. A content object defines the text and graphics that actually show up on the page. Together, content objects and resources define theappearance of an individual page. \r\n \r\n  Finally, the document�s catalog tells applications where to start reading the document. Often, this is just a pointer to the root page tree.";
            string resource = "The third object is a resource defining a font configuration. \r\n \r\n The /Font key contains a whole dictionary, opposed to the name/value pairs we�ve seen previously (e.g., /Type /Page). The font we configured is called /F0, and the font face we selected is /Times-Roman. The /Subtype is the format of the font file, and /Type1 refers to the PostScript type 1 file format. The specification defines 14 �standard� fonts that all PDF applications should support.";
            string resource2 = "Any of these values can be used for the /BaseFont in a /Font dictionary. Nonstandard fonts can be embedded in a PDF document, but it is not easy to do manually. We will put off custom fonts until we can use iTextSharp�s high-level framework.";
            string crossRef = "After the header and the body comes the cross-reference table. It records the byte location of each object in the body of the file. This enables random-access of the document, so when rendering a page, only the objects required for that page are read from the file. This makes PDFs much faster than their PostScript predecessors, which had to read in the entire file before processing it.";
            string trailer = "Finally, we come to the last component of a PDF document. The trailer tells applications how to start reading the file. At minimum, it contains three things: \r\n 1. A reference to the catalog which links to the root of the document. \r\n 2. The location of the cross-reference table. \r\n 3. The size of the cross-reference table. \r\n \r\n Since a trailer is all you need to begin processing a document, PDFs are typically read back-to-front: first, the end of the file is found, and then you read backwards until you arrive at the beginning of the trailer. After that, you should have all the information you need to load any page in the PDF.";
            #endregion
            //Create a new PDF document.

            PdfDocument document = new PdfDocument();

            document.DocumentInformation.Title = "CustomTag";

            #region page1
            //Add a page to the document.

            PdfPage page1 = document.Pages.Add();

            //Load the image from the disk.

            PdfBitmap image = new PdfBitmap(GetFullTemplatePath("CustomTag.jpg", true));

            PdfStructureElement imageElement = new PdfStructureElement(PdfTagType.Figure);
            imageElement.AlternateText = "PDF Succintly image";
            //adding tag to the PDF image
            image.PdfTag = imageElement;
            //Draw the image
            page1.Graphics.DrawImage(image, 0, 0, page1.GetClientSize().Width, page1.GetClientSize().Height - 20);

            #endregion


            #region page2

            PdfPage page2 = document.Pages.Add();

            PdfStructureElement hTextElement1 = new PdfStructureElement(PdfTagType.Heading);
            PdfStructureElement headingFirstLevel = new PdfStructureElement(PdfTagType.HeadingLevel1);
            headingFirstLevel.Parent = hTextElement1;

            PdfTextElement headerElement1 = new PdfTextElement("Chapter 1 Conceptual Overview", fontTitle, PdfBrushes.Black);

            headerElement1.PdfTag = headingFirstLevel;
            headerElement1.Draw(page2, new PointF(100, 0));

            //Initialize the structure element with tag type paragraph.

            PdfStructureElement textElement1 = new PdfStructureElement(PdfTagType.Paragraph);
            textElement1.Parent = headingFirstLevel;
            textElement1.ActualText = pdfChapter;

            PdfTextElement element1 = new PdfTextElement(pdfChapter, fontnormal);
            element1.PdfTag = textElement1;
            element1.Brush = new PdfSolidBrush(System.Drawing.Color.Black);
            element1.Draw(page2, new RectangleF(0, 40, page2.GetClientSize().Width, 70));

            PdfStructureElement hTextElement2 = new PdfStructureElement(PdfTagType.HeadingLevel2);
            hTextElement2.Parent = hTextElement1;
            hTextElement2.ActualText = "Header";

            PdfTextElement headerElement2 = new PdfTextElement("Header", fontHead2, PdfBrushes.Black);
            headerElement2.PdfTag = hTextElement1;
            headerElement2.Draw(page2, new PointF(0, 140));

            PdfStructureElement textElement2 = new PdfStructureElement(PdfTagType.Paragraph);
            textElement2.Parent = hTextElement2;
            textElement2.ActualText = header;

            PdfTextElement element2 = new PdfTextElement(header, fontnormal);
            element2.PdfTag = textElement2;
            element2.Brush = new PdfSolidBrush(System.Drawing.Color.Black);
            element2.Draw(page2, new RectangleF(0, 170, page2.GetClientSize().Width, 40));


            PdfStructureElement hTextElement3 = new PdfStructureElement(PdfTagType.HeadingLevel2);
            hTextElement3.Parent = hTextElement1;
            hTextElement3.ActualText = "Body";

            PdfTextElement headerElement3 = new PdfTextElement("Body", fontHead2, PdfBrushes.Black);
            headerElement3.PdfTag = hTextElement1;
            headerElement3.Draw(page2, new PointF(0, 210));

            PdfStructureElement textElement3 = new PdfStructureElement(PdfTagType.Paragraph);
            textElement3.Parent = hTextElement3;
            textElement3.ActualText = body;

            PdfTextElement element3 = new PdfTextElement(body, fontnormal);
            element3.PdfTag = textElement3;
            element3.Brush = new PdfSolidBrush(System.Drawing.Color.Black);
            element3.Draw(page2, new RectangleF(0, 240, page2.GetClientSize().Width, 120));

            PdfStructureElement hTextElement6 = new PdfStructureElement(PdfTagType.HeadingLevel2);
            hTextElement6.Parent = hTextElement1;
            hTextElement6.ActualText = "Cross-Reference Table";

            PdfTextElement headerElement5 = new PdfTextElement("Cross-Reference Table", fontHead2, PdfBrushes.Black);
            headerElement5.PdfTag = hTextElement6;
            headerElement5.Draw(page2, new PointF(0, 380));

            PdfStructureElement textElement6 = new PdfStructureElement(PdfTagType.Paragraph);
            textElement6.Parent = hTextElement6;
            textElement6.ActualText = crossRef;

            PdfTextElement element6 = new PdfTextElement(crossRef, fontnormal);
            element6.PdfTag = textElement6;
            element6.Brush = new PdfSolidBrush(System.Drawing.Color.Black);
            element6.Draw(page2, new RectangleF(0, 410, page2.GetClientSize().Width, 50));

            PdfStructureElement hTextElement7 = new PdfStructureElement(PdfTagType.HeadingLevel2);
            hTextElement7.Parent = hTextElement1;
            hTextElement7.ActualText = "Trailer";

            PdfTextElement headerElement6 = new PdfTextElement("Trailer", fontHead2, PdfBrushes.Black);
            headerElement6.PdfTag = hTextElement7;
            headerElement6.Draw(page2, new PointF(0, 470));

            PdfStructureElement textElement7 = new PdfStructureElement(PdfTagType.Paragraph);
            textElement7.Parent = hTextElement7;
            textElement7.ActualText = trailer;

            PdfTextElement element7 = new PdfTextElement(trailer, fontnormal);
            element7.PdfTag = textElement7;
            element7.Brush = new PdfSolidBrush(System.Drawing.Color.Black);
            element7.Draw(page2, new RectangleF(0, 500, page2.GetClientSize().Width, 110));



            #endregion

            #region page3

            PdfPage page3 = document.Pages.Add();

            PdfStructureElement hTextElement4 = new PdfStructureElement(PdfTagType.HeadingLevel2);
            hTextElement4.Parent = hTextElement1;
            hTextElement4.ActualText = "Resource";


            PdfTextElement headerElement4 = new PdfTextElement("Resource", fontHead2, PdfBrushes.Black);
            headerElement4.PdfTag = hTextElement1;
            headerElement4.Draw(page3, new PointF(0, 0));

            PdfStructureElement textElement4 = new PdfStructureElement(PdfTagType.Paragraph);
            textElement4.Parent = hTextElement4;
            textElement4.ActualText = resource;

            PdfTextElement element4 = new PdfTextElement(resource, fontnormal);
            element4.PdfTag = textElement4;
            element4.Brush = new PdfSolidBrush(System.Drawing.Color.Black);
            element4.Draw(page3, new RectangleF(0, 40, page2.GetClientSize().Width, 70));

            //Create a new PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();

            PdfStructureElement element = new PdfStructureElement(PdfTagType.Table);

            //Adding tag to PDF grid.
            pdfGrid.PdfTag = element;

            //Add three columns.
            pdfGrid.Columns.Add(3);
            PdfGridRow[] headerRow = pdfGrid.Headers.Add(3);
            PdfGridRow pdfGridHeader = pdfGrid.Headers[0];
            pdfGridHeader.PdfTag = new PdfStructureElement(PdfTagType.TableRow);

            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 13);
            pdfGridHeader.ApplyStyle(headerStyle);

            pdfGridHeader.Cells[0].Value = "Times Roman Family";
            pdfGridHeader.Cells[0].PdfTag = new PdfStructureElement(PdfTagType.TableHeader);

            pdfGridHeader.Cells[1].Value = "Helvetica Family";
            pdfGridHeader.Cells[1].PdfTag = new PdfStructureElement(PdfTagType.TableHeader);
            pdfGridHeader.Cells[2].Value = "Courier Family";
            pdfGridHeader.Cells[2].PdfTag = new PdfStructureElement(PdfTagType.TableHeader);

            PdfGridRow pdfGridRow1 = pdfGrid.Rows.Add();
            pdfGridRow1.PdfTag = new PdfStructureElement(PdfTagType.TableRow);

            pdfGridRow1.Cells[0].Value = "Times roman";

            pdfGridRow1.Cells[1].Value = "Helvetica";

            pdfGridRow1.Cells[2].Value = "Courier";

            pdfGridRow1.Cells[0].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow1.Cells[1].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow1.Cells[2].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);


            PdfGridRow pdfGridRow2 = pdfGrid.Rows.Add();
            pdfGridRow2.PdfTag = new PdfStructureElement(PdfTagType.TableRow);

            pdfGridRow2.Cells[0].Value = "Times-Bold";

            pdfGridRow2.Cells[1].Value = "Helvetica-Bold";

            pdfGridRow2.Cells[2].Value = "Courier-Bold";

            pdfGridRow2.Cells[0].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow2.Cells[1].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow2.Cells[2].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);

            PdfGridRow pdfGridRow3 = pdfGrid.Rows.Add();

            pdfGridRow3.PdfTag = new PdfStructureElement(PdfTagType.TableRow);

            pdfGridRow3.Cells[0].Value = "Times-Italic";

            pdfGridRow3.Cells[1].Value = "Helvetica-Oblique";

            pdfGridRow3.Cells[2].Value = "Courier-Oblique";

            pdfGridRow3.Cells[0].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow3.Cells[1].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow3.Cells[2].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);

            PdfGridRow pdfGridRow4 = pdfGrid.Rows.Add();

            pdfGridRow4.PdfTag = new PdfStructureElement(PdfTagType.TableRow);

            pdfGridRow4.Cells[0].Value = "Times-BoldItalic";

            pdfGridRow4.Cells[1].Value = "Helvetica-BoldOblique";

            pdfGridRow4.Cells[2].Value = "Courier-BoldOblique";

            pdfGridRow4.Cells[0].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow4.Cells[1].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);
            pdfGridRow4.Cells[2].PdfTag = new PdfStructureElement(PdfTagType.TableDataCell);



            pdfGrid.BeginCellLayout += PdfGrid_BeginCellLayout;
            pdfGrid.Draw(page3, new PointF(20, 130));

            page3.Graphics.DrawRectangle(PdfPens.Black, new RectangleF(20, 120, 490, 90));



            #endregion




            //Save and close the document.
            document.Save("Sample.pdf");
            document.Close(true);
            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.pdf")
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                System.Diagnostics.Process.Start("Sample.pdf");
#endif
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
		
        # endregion
		# region Helper Methods

        private void PdfGrid_BeginCellLayout(object sender, PdfGridBeginCellLayoutEventArgs args)
        {
            // setting transparent color pen as table BorderPen. 
            PdfPen transparentPen = new PdfPen(new PdfColor(System.Drawing.Color.FromArgb(Color.Transparent.A, Color.Transparent.R, Color.Transparent.G, Color.Transparent.B)), .3f);

            PdfGridCellStyle pdfGridCellStyle = new PdfGridCellStyle();
            pdfGridCellStyle.Borders.All = transparentPen;

            args.Style = pdfGridCellStyle;
            args.Style.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);

        }
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
#if NETCORE
            string fullPath = @"..\..\..\..\..\..\..\Common\";
#else
            string fullPath = @"..\..\..\..\..\..\Common\";
#endif
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }		
        # endregion
    }
	/// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
