using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyClone.BuisnessLogicLayer;
using SpotifyClone.PocosLayer;

namespace SpotifyClone
{
    public partial class Form1 : Form
    {
        tblUserBLL _tblUserBLL;
        public Form1()
        {
            InitializeComponent();
            _tblUserBLL = new tblUserBLL();
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            tblUser _tblUser = new tblUser();
            _tblUser = _tblUserBLL.girisSorgula(txtUsername.Text, txtUserPassword.Text);
            
            //ilerde conditionlara bak
            if((_tblUser.username == null) || ( _tblUser.username == null))
            {
                MessageBox.Show("Hatalı giriş");
            }
            else
            {
                this.Hide();

                string user_id = _tblUser.id;

                PresentationLayer.UserEntry.Ana_Menu anamenu = new PresentationLayer.UserEntry.Ana_Menu(user_id);
                anamenu.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PresentationLayer.UserEntry.YeniKullanici yeniKullanici = new PresentationLayer.UserEntry.YeniKullanici();
            yeniKullanici.FormClosed += new FormClosedEventHandler(YeniKullanici_FormClosed);
            yeniKullanici.Show();
            this.Hide();
        }

        private void YeniKullanici_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
