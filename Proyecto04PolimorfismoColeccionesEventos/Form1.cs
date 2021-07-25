using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto04
{
    public partial class Form1 : Form
    {
        List<IPesable> ElementosPesables = new List<IPesable>(1000);
        /// <summary>
        /// Lista de elementos para contavilizar o trabajar con ellos en otras operaciones
        /// </summary>
        public Form1() { InitializeComponent(); }
        /// <summary>
        /// Acciones al inicializar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e){}
        /// <summary>
        /// Accion al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        
        private void ButtonPantalla_Click(object sender, EventArgs e)
        {
            
            String texto = (sender as Button).Text;
            switch (texto)
            {
                case "Acero": ElementosPesables.Add(new Acero(50)); break;
                case "Bronce": ElementosPesables.Add(new Bronce(35)); break;
                case "Chip": ElementosPesables.Add(new Chip((decimal)0.01)); break;
                case "Escoba": ElementosPesables.Add(new Escoba((decimal)0.2)); break;
                case "Higo": ElementosPesables.Add(new Higo((decimal)0.005)); break;
                case "Papel": ElementosPesables.Add(new Papel((decimal)0.001)); break;
                case "Gominola": ElementosPesables.Add(new Gominola((decimal)0.002)); break;
                default: MessageBox.Show(texto);break; 
            }
            this.labelCantMat.Text = ElementosPesables.Count.ToString();
            decimal PesoPnoI = 0;
            decimal MediaNoP = 0;
            decimal MediaNoP100 = 0;
            int n = 0;
            foreach (var item in ElementosPesables)
            {
                if (item is IPerecedero && !(item is IInflamable)) {
                    PesoPnoI += (item as IPesable).DevolverPeso();
                }
                if (!(item is IPerecedero) )
                {
                    MediaNoP+= (item as IPesable).DevolverPeso()/Int32.Parse(ElementosPesables.Count.ToString());
                    n++;
                    MediaNoP100= ((decimal)n / (decimal)int.Parse(ElementosPesables.Count.ToString())*100);

                }

                this.labelKgPnoI.Text = PesoPnoI.ToString();
                this.labelProNoP.Text = Math.Truncate(MediaNoP).ToString();
                this.labelPorcentaje.Text = Math.Truncate(MediaNoP100).ToString();

            }
            listBoxMateriales.Size = new System.Drawing.Size(200, 200);
            
                listBoxMateriales.Items.Add("Material " + texto);
            
        }
        
        
    }
}
