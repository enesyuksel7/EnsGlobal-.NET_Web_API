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

namespace EnsGlobal.FORM
{
    public partial class FormAPI : Form
    {
        public FormAPI()
        {
            InitializeComponent();
        }

        private async void BtnGETALL_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetALL();
            RtbResponce.Text = responce;
            dataGridView1.DataSource = responce;
        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {
            BtnGET.Enabled = BtnPOST.Enabled = BtnPUT.Enabled = BtnDELETE.Enabled = true;
        }

        private async void BtnGET_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Get(TbID.Text);
            RtbResponce.Text = responce;
        }

        private async void BtnPOST_Click(object sender, EventArgs e)
        {
            //var responce = await RestHelper.Post(Convert.ToInt32(TbID.Text), TbYetkili.Text, Convert.ToDateTime(TbTarih.Text),Convert.ToInt32(TbUcret.Text), Convert.ToInt32(TbVergi.Text));
            //RtbResponce.Text = responce;
        }

        private async void BtnPUT_Click(object sender, EventArgs e)
        {

        }

        private async void BtnDELETE_Click(object sender, EventArgs e)
        {
            var responce = await Delete(TbID.Text);
            RtbResponce.Text = responce;
        }



        




        private async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://www.mekadeneme.somee.com/api/" + "Satislar/" + id + "?apiKey=ePzsLed_9h)x%Zg{"))
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
                var users = await httpClient.GetFromJsonAsync<List<Satis>>(new Uri(url));
            }
        }
    }
}
