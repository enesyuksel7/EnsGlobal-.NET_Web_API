using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using EnsGlobal.DAL;
using System.Net.Http.Json;

namespace EnsGlobal.FORM
{
    public partial class FormAPI : Form
    {
        public FormAPI()
        {
            InitializeComponent();
        }

        private string apiURL = "http://www.mekadeneme.somee.com/api/";

        EnsGlobalDBEntities db = new DAL.EnsGlobalDBEntities();

        private async void BtnGETALL_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetALL();
            RtbResponce.Text = responce;
            dataGridView1.DataSource = responce;
        }

        private void txtSatisID_TextChanged(object sender, EventArgs e)
        {
            BtnGET.Enabled = BtnPOST.Enabled = BtnPUT.Enabled = BtnDELETE.Enabled = true;
        }

        private async void BtnGET_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Get(txtSatisID.Text);
            RtbResponce.Text = responce;
        }

        private async void BtnPOST_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Post(txtUrunID.Text, txtYetkili.Text, dateTimePicker1.Text, txtUcret.Text, txtVergi.Text);
            RtbResponce.Text = responce;
        }

        private void BtnPUT_Click(object sender, EventArgs e)
        {
            //async yaz private async void
        }

        private async void BtnDELETE_Click(object sender, EventArgs e)
        {
            var responce = await Delete(txtUrunID.Text);
            RtbResponce.Text = responce;
        }


        private async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync(apiURL + "Satislar/" + id + "?apiKey=ePzsLed_9h)x%Zg{"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        private async void FormAPI_Load(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var kayitlar = await httpClient.GetFromJsonAsync<List<Satislar>>(apiURL + "Satislar?apiKey=ePzsLed_9h)x%Zg{");
                dataGridView1.DataSource = kayitlar;
            }
        }

        private void BtnKucult_Click(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}