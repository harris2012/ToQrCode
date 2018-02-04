using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToQrCode
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtStart_Click(object sender, EventArgs e)
        {
            InitFolder();

            string path = string.Format("/img/{0:yyyyMMddHHmmss}.jpg", DateTime.Now);

            using (var gen = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = gen.CreateQrCode(ContentTextBox.Text, QRCodeGenerator.ECCLevel.Q);

                QRCode qrCode = new QRCode(qrCodeData);

                Bitmap img = qrCode.GetGraphic(10);

                img.Save(Server.MapPath(path), ImageFormat.Jpeg);
            }

            QrImage.ImageUrl = path;
        }

        private void InitFolder()
        {
            var path = Server.MapPath("/img");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}