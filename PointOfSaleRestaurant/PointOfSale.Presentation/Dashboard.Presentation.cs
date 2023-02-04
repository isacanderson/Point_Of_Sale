using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PointOfSale.Presentation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubMenuAdministracion.Visible = false;
            panelSubMenuPuntoVenta.Visible= false;
        }

        private void hideSubMenu()
        {
            if(panelSubMenuAdministracion.Visible == true)
                panelSubMenuAdministracion.Visible = false;
            if (panelSubMenuPuntoVenta.Visible == true)
                panelSubMenuPuntoVenta.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void buttonAdministracion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAdministracion);
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            openChildForm(new Gastos());
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private void buttonMonVentasAdm_Click(object sender, EventArgs e)
        {
            openChildForm(new MonitorVentasAdmin());
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new Productos());
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private void buttonPuntoVenta_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPuntoVenta);
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private void buttonTurno_Click(object sender, EventArgs e)
        {
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private void buttonMonVentasPV_Click(object sender, EventArgs e)
        {
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private void buttonCaja_Click(object sender, EventArgs e)
        {
            // YOUR CODE HERE....
            //
            //
            //hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm == null)
                activeForm = new Form();
            else
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel= false;
            childForm.Dock= DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            buttonOcultarMenuLateral.BringToFront();
            
        }

        private void buttonOcultarMenuLateral_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Visible == true)
                panelMenuLateral.Visible = false;
            else
                panelMenuLateral.Visible = true;
        }
    }
}
