using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            try
            {
                var mymessage = new com.suresms.api.message();
                mymessage.MessageID = "";
                mymessage.MessageText = tbMessage.Text;
                mymessage.SenderID = "Skat";
                mymessage.ToPhonenumbers = tbToPhoneNo.Text;

                var service = new com.suresms.api.SureSMS_SOAP_Service();
                com.suresms.api.response result = service.CreateMessage(tbUser.Text, tbPassword.Text, mymessage);   
                
                MessageBox.Show(string.Format("Responce kode: {0} Responce Text: {1}", result.ResponseCode, result.ResponseText));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
