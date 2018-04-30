using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace upload_imagem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                
                FileUpload1.SaveAs(Server.MapPath("~/Imagem_Original/") + FileUpload1.FileName);

                insereMarcaDagua(FileUpload1.FileName);

            }

        }


        
        protected void btnUpload_Click(object sender, EventArgs e)
        {

        }



        protected void insereMarcaDagua(string _filename)

        {



            

            string original = Server.MapPath("~/Imagem_Original/" + _filename);


            //string logotipo = Server.MapPath("~/Molduras/moldura-com-marca-d-agua-marca-dagua-para-fotos.jpg");
            //string logotipo = Server.MapPath("~/Molduras/moldura-com-marca-d-agua-marca-dagua-para-fotos.png");

            //string logotipo = Server.MapPath("~/Molduras/moldura.png");
            string logotipo = Server.MapPath("~/Molduras/moldura.png");

            System.Drawing.Image imagem = System.Drawing.Image.FromFile(original);
            
            System.Drawing.Image logo = System.Drawing.Image.FromFile(logotipo);



            /*************************************** parte da logo/moldura ****************************/

            //logo = EscalaPercentual(logo, 100);

            Bitmap bitmap = new Bitmap(logo);

            //Definir parte branca como transparente
            bitmap.MakeTransparent(ColorTranslator.FromHtml("#ffffff"));

            bitmap.MakeTransparent(ColorTranslator.FromHtml("#ffffff"));

            System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(imagem);

            //gr.DrawImage(bitmap, 10, 10, logo.Width, logo.Height);


            //Largura do logo
            //int intWidth = bitmap.Size.Width; // descomentar aqui caso queira que a marca d'agua, fique no canto inferior direito
            int intWidth = imagem.Size.Width;  // desse jeito funciona como uma moldura
            //Altura do logo
            int intHeight = imagem.Size.Height;
            //Posicionamento a esquerda
            int intLeft = imagem.Width - intWidth;
            //posicionamento em relação ao topo
            int intTop = imagem.Height - intHeight;



          

            gr.DrawImage(bitmap, intLeft, intTop, intWidth, intHeight);


            /*************************************** parte da logo/moldura ****************************/

            /*
                ========= Para escrever algo na imagem, descomentar as linhas abaixo
            System.Drawing.Font fonte = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, GraphicsUnit.Pixel);
            gr.DrawString("Escreva algo aqui caso seja necessário", fonte, System.Drawing.Brushes.Azure, 1, imagem.Height - 35);

            */

            string imagemModificada = Server.MapPath("~/Imagem_Modificada/") + _filename;

            imagem.Save(imagemModificada, System.Drawing.Imaging.ImageFormat.Jpeg);
            

            Image1.ImageUrl = "~/Imagem_Modificada/" + _filename; 

        }



   

    }



    



    }
