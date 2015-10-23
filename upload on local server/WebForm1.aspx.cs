using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

namespace upload_on_local_server
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
          // string resumeFile = "~/uploaded_files/";
          //// string resumeFile = @"c:\ResumesArchive\923823.txt";
          //// string newFile = @"c:\ResumesImport\newResume.txt";
          // if (File.Exists(resumeFile))
          // {
          //    // File.Copy(resumeFile, newFile);
          //     Response.Write("there are files");
          //
          //
          // }
          // else
          // {
          //     Response.Write("no files");
          //    // Console.WriteLine("Resume file does not exist.");
          // }
       string path = Server.MapPath("~/uploaded_files/");
     
      string[] filePaths = Directory.GetFiles(path);


          int i = 1;
          
          
                while (i <= filePaths.Length)
                {

                    String RelativePath = filePaths[i - 1].Replace(Request.ServerVariables["APPL_PHYSICAL_PATH"], String.Empty);

                    // Response.Write(filePaths.Length.ToString());
                    Response.Write(filePaths[i - 1]);
              
                   Image im = new Image();
                   im.ImageUrl = RelativePath;
              
                 // System.Web.UI.HtmlControls.HtmlGenericControl div = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                 // div.ID = "test";
                 // 
                 // im.AlternateText = "Test image";
                 // div.Controls.Add(im);
             
                 //   myimage.ImageUrl = Server.MapPath(filePaths[i - 1]);
                   // this.myimage.ImageUrl = RelativePath;
                    PlaceHolder1.Controls.Add(im);
                  //  myimage.ImageUrl = filePaths[i - 1];
                    i++;
              
              
                }
              
           
      
        

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/uploaded_files/");
            string file_name = FileUpload1.PostedFile.FileName;
           
            FileUpload1.SaveAs(path + file_name);
           
            Response.Write("uploaded !!");
        }
    }
}