using Project.BLL.DesignPatterns.GenericRepository.EFConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _hRep = new PowerRespository();
        }
        PowerRespository _hRep;
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Power p = new Power();
            p.PowerName = txtIsim.Text;
            _hRep.Add(p);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstKahramanlar.DataSource= _hRep.GetActives();
        }
    }
}
