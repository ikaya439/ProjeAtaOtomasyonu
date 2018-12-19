using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Controllers
{
    class FileOperations
    {

        public bool updateProject(ProjeSahiplik pSEntity)
        {
            string path = pSEntity.Path;

            if (!Directory.Exists(path))
            {
                MessageBox.Show("File can't find");
                return false;
            }

            try
            {
                //find project
                Proje pEntity = new ProjeDAO().SelectById(pSEntity.ProjeId);

                //increase version number
                string versiyonNumber = versiyonNumarasiArttir(pSEntity.Versiyon);
                string destDirName = @"..\..\Projeler\" + pSEntity.StajyerId + "\\"
                    + pEntity.Adi + "\\" + versiyonNumber;

                DirectoryCopy(path, destDirName, true);

                ProjeVersiyonlari pVEntity = new ProjeVersiyonlari();

                pVEntity.Versiyon = versiyonNumber;
                pVEntity.InsDate = DateTime.Now;
                pVEntity.Active = true;
                pVEntity.ProjeSahiplikId = pSEntity.Id;
                pVEntity.Path = destDirName;

                new ProjeVersiyonlariDAO().Save(pVEntity);

                pSEntity.Versiyon = versiyonNumber;

                new ProjeSahiplikDAO().Save(pSEntity);
            }
            catch
            {
                return false;
            }


            return true;
        }


        private void savePath()
        {

        }

        public void openProject(ProjeSahiplik pSEntity, bool adminStajyer)
        {
            string path = pSEntity.Path + "\\" + pSEntity.ProjeAdi + ".sln";
            FolderBrowserDialog fbd = null;
            DialogResult result;
            Process p;
            if (adminStajyer)
            {
                string adminPath = pSEntity.Path;
                try
                {
                    if (File.Exists(path))
                    {
                        adminPath += "\\" + pSEntity.ProjeAdi + ".sln";
                        p = new Process();
                        p.StartInfo = new ProcessStartInfo(adminPath);
                        p.Start();
                    }
                    else
                    {
                        MessageBox.Show("Intern does not upload any project!");
                    }
                    return;
                }
                catch
                {
                    MessageBox.Show("File Deleted or wrong Location!");
                }
            }
            else
            {
                while (!File.Exists(path))
                {
                    MessageBox.Show("Yol bulunamadı yeni yol tanımlayın");
                    fbd = new FolderBrowserDialog();
                    result = fbd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        pSEntity.Path = fbd.SelectedPath;
                        path = pSEntity.Path + "\\" + pSEntity.ProjeAdi + ".sln";
                    }
                    else
                        return;
                }

                new ProjeSahiplikDAO().Save(pSEntity);
            }
            p = new Process();
            p.StartInfo = new ProcessStartInfo(path);
            p.Start();
        }

        private string versiyonNumarasiArttir(string versiyon)
        {
            string[] versiyonArray = new string[] { "1", "0", "0" };
            if (versiyon != "<yok>")
            {
                versiyonArray = versiyon.Split('.');
            }

            int temp = Convert.ToInt32(versiyonArray[0] + versiyonArray[1] + versiyonArray[2]);
            if (versiyon != "<yok>")
            {
                temp++;
            }
            string intBol = temp.ToString();
            versiyon = intBol[0] + "." + intBol[1] + "." + intBol[2];
            return versiyon;
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string insideTempPath = sourceDirName;
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    insideTempPath += @"\" + subdir.Name;
                    DirectoryCopy(insideTempPath, temppath, true);
                }
            }
        }

    }
}
