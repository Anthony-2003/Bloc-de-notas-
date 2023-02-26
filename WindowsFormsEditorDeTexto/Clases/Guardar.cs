using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEditorDeTexto.Clases
{
    class Guardar
    {

        public static void guardarFichero(RichTextBox rtb, string archivo)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto |*.txt";

            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(rtb.Text);
                }
            }

            else
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;

                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(rtb.Text);
                    }
                }
            }

        }
     


    }
}
 