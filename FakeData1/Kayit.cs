using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FakeData1
{
    public class Kayit
    {


        //void Metin_Yaz(string text)
        //{
        //    SaveFileDialog save = new SaveFileDialog();
        //    save.CreatePrompt = true; // dosya yoksa üret
        //    save.OverwritePrompt = true; // üzerine yazma uyarısı
        //    save.Title = "Metin Dosyaları";
        //    save.DefaultExt = "txt";
        //    save.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
        //    if (save.ShowDialog() == DialogResult.OK)
        //    {
        //        if (chk_altina_ekle.CheckState == CheckState.Checked)
        //        {
        //            // Burada AppandText metodunu kullanmak için FileStream kullandık. Bunun amacı farklı yöntemleri görmenizi istememdir.
        //            FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
        //            fs.Close();
        //            File.AppendAllText(save.FileName, Environment.NewLine + txt_yazilacak_metin.Text);
        //        }
        //        else
        //        {
        //            if (File.Exists(save.FileName))
        //            {
        //                StreamReader Oku = new StreamReader(save.FileName);
        //                string okunan = Oku.ReadToEnd();
        //                Oku.Close();
        //                if (okunan.Trim() != string.Empty)
        //                {
        //                    switch (MessageBox.Show("Seçtiğiniz belge boş değil. Üzerine yazmak istiyorsanız -EVET-, ekrana getirmek istiyorsanız -HAYIR-, işlemi iptal etmek istiyorsanız -VAZGEÇ-'i seçin"
        //                    , "İşlem Seçin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
        //                    {
        //                        case DialogResult.Cancel:
        //                            break;
        //                        case DialogResult.Yes:
        //                            StreamWriter Kayit = new StreamWriter(save.FileName);
        //                            Kayit.WriteLine(text);
        //                            Kayit.Close();
        //                            break;
        //                        case DialogResult.No:
        //                            txt_yazilacak_metin.Text = okunan;
        //                            break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                StreamWriter Kayit = new StreamWriter(save.FileName);
        //                Kayit.WriteLine(text);
        //                Kayit.Close();
        //            }
        //        }
        //    }




        }
    }
