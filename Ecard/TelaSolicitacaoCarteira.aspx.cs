using System;
using System.IO;
using System.Web;

namespace Ecard
{
    public partial class TelaSolicitacaoCarteira : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream);
                byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);

                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);


                byte[] imageBytes = Convert.FromBase64String(base64String);

                string filePath = Server.MapPath("~/Imagens/" + Path.GetFileName(FileUpload1.PostedFile.FileName));
                File.WriteAllBytes(filePath, imageBytes);

                userImage.ImageUrl = "Imagens/" + FileUpload1.FileName;
            } catch {
                
            }
        }

    }
}
