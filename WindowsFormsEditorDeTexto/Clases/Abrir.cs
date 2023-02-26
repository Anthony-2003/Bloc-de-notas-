using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEditorDeTexto.Clases
{
    public class Abrir
    {
        public static void abrirFichero(RichTextBox rtb, string archivo)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto |*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;

                using (StreamReader sr = new StreamReader(archivo))
                {
                    rtb.Text = sr.ReadToEnd();
                }
            }
            
        }

    }
}
