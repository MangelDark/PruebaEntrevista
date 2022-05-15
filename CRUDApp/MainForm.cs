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
using CRUDApp.Models;
using Newtonsoft.Json;
using RestSharp;

using System.Xml.Serialization;

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
       

        private  async Task<string> Peticion()
        {

            var client = new RestClient("https://localhost:44336/api/");
            var request = new RestRequest("Customer/GetAll");
            var response = await client.GetAsync(request);
            return response.Content;
        }


        private async Task<string>  PostRequest()
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,  
                Created = DateTime.Now,
                Modified = DateTime.Now,    
                IsActive = true,
            };
            var exist = await EmailExist(customer.Email);
            if (!exist)
            {
                var client = new RestClient("https://localhost:44336/api/");
                var request = new RestRequest("Customer/Insert");
                request.AddBody(customer);
                var response = await client.PostAsync(request);

                return response.Content;
            }

            return "The email exist";

           
        }

   
        private async Task<string> PutRequest()
        {
            try
            {
                var customerUpdate = new Customer
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    IsActive = true,
                };

                var client = new RestClient("https://localhost:44336/api/");
                var request = new RestRequest("Customer/Update");
                request.AddBody(customerUpdate);
                var response = await client.PutAsync(request);
                return response.Content;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
         
        }
        private async Task<string> DeleteRequest(int id)
        {

            var client = new RestClient("https://localhost:44336/api/");
            var request = new RestRequest("Customer/Delete/");
            request.AddParameter("id",id);
            var response = await client.DeleteAsync(request);

            return response.Content;


        }

        private async Task<bool> EmailExist(string email)
        {

            var client = new RestClient("https://localhost:44336/api/");
            var request = new RestRequest("Customer/EmailExist");
            request.AddParameter("email", email);
            var response = await client.GetAsync(request);

            return Convert.ToBoolean(response.Content);
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

        private async void btnSaveOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtEmail.Text == "Email")
                {
                    lbErrorEmail.Visible = true;
                    lbErrorEmail.Text = "The field is required";

                    if (txtName.Text == "Name")
                    {
                        lbErrorName.Visible = true;
                        lbErrorName.Text = "The field is required";

                        if (txtLastName.Text == "Last Name")
                        {
                            lbErrorLastName.Visible = true;
                            lbErrorLastName.Text = "The field is required";
                        }
                    }
                }
                else
                {
                    if (txtId.Text == "")
                    {

                        var result = await PostRequest();
                        MessageBox.Show(result);
                        ClearTextBox();
                        cargarGrid();

                    }
                    else
                    {
                        var result = await PutRequest();
                        MessageBox.Show(result);
                        cargarGrid();
                    }
                }

            }
            catch (Exception ex)
            {

                lbErrorEmail.Text = "The email format is not valid";
                lbErrorEmail.Visible = true;
            }
          








        }
        private async void cargarGrid()
        {
            var result = await Peticion();
            List<Customer> lst = JsonConvert.DeserializeObject<List<Customer>>(result);
            dtgCustomers.DataSource = lst;
            ClearTextBox();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {


            cargarGrid();
            ClearTextBox();
        }

        private void dtgCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgCustomers.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgCustomers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dtgCustomers.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dtgCustomers.CurrentRow.Cells[3].Value.ToString();

              


        }

        private void txtId_Enter(object sender, EventArgs e)
        {

        }

     
        private void ClearTextBox()
        {
            txtId.Text = "";
            txtEmail.Text = "Email";
            txtName.Text = "";
            txtName.Focus();
            txtLastName.Text = "Last Name";
            lbErrorEmail.Visible = false;
            lbErrorLastName.Visible = false;
            lbErrorName.Visible = false;

        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( txtId.Text);
            await DeleteRequest(id);
            ClearTextBox();
            cargarGrid();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
