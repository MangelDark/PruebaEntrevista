using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RestSharp;
using System.Threading;

namespace CRUDApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }
       

        private  async Task<bool> Peticion()
        {
           
            var client = new RestClient("https://localhost:44336/api/");
            var request = new RestRequest("Customer/GetAll");
            var response = await client.GetAsync(request);
            if (response.Content == "[]")
            {
                MessageBox.Show("La peticion fue correcta");
                return true;
            }
            MessageBox.Show("La peticion fallo");
            return false;
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if(txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.LightGray;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if( txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.DimGray;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.LightGray;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name";
                txtLastName.ForeColor = Color.Silver;
            }
        }

        private void txtName_Enter_1(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.LightGray;
            }
        }

        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Silver;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void panelNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {

                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        {
            Peticion();
        }
    }
}
