﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace WindowsForms_Exo
{
    public partial class PackagerForm : Form
    {
        public PackagerForm()
        {
            InitializeComponent();
        }

        private void PackagerForm_Load(object sender, EventArgs e)
        {
            QRCodeGenerator myQRCodeGenerator = new QRCodeGenerator();
            QRCodeData myQRCodeData = myQRCodeGenerator.CreateQrCode("https://www.youtube.com/", QRCodeGenerator.ECCLevel.Q);

            QRCode myQRCode = new QRCode(myQRCodeData);

            Bitmap qrcode = myQRCode.GetGraphic(20, Color.Black, Color.White, true);

            PictureBox qrBox = new PictureBox();
            qrBox.Width = 500;
            qrBox.Height = 500;

            qrBox.Image = (System.Drawing.Image) qrcode;
            qrBox.Show();

            string mystring = "string.txt";
            var writer = new PdfWriter("c:\\dev\\itext.pdf");
            var pdf = new PdfDocument(writer);
            var doc = new Document(pdf);
            doc.Add(new Paragraph(mystring));
            doc.Close();

        }
    }
}
