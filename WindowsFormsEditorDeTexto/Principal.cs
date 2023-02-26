using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsEditorDeTexto
{
    public partial class TakoBlock : Form
    {
        private string archivo;
        private int scale = 5;

        public TakoBlock()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clases.Abrir.abrirFichero(contenidoRtb, archivo);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            Clases.Guardar.guardarFichero(contenidoRtb, archivo);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenidoRtb.Clear();
            
        }

        private void TakoBlock_Load(object sender, EventArgs e)
        {

        }

        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scale++;
            Font currentFont = contenidoRtb.Font;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size + scale, currentFont.Style);
            contenidoRtb.Font = newFont;
            contenidoRtb.Invalidate();

        }

        private void alejarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scale--;
            Font currentFont = contenidoRtb.Font;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size - scale, currentFont.Style);
            contenidoRtb.Font = newFont;
            contenidoRtb.Invalidate();
        }

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            FontDialog fontDialog1 = new FontDialog();
            

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
                FontStyle selecteStyle = fontDialog1.Font.Style;
                int fontSize = Convert.ToInt32(selectedFont.SizeInPoints);
                Font newFont = new Font(selectedFont.FontFamily, fontSize, selecteStyle);
                contenidoRtb.Font = newFont;
                contenidoRtb.Invalidate();

            }

        }
    }
}
