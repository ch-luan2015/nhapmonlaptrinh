using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


    public partial class MH_Doc_Xuat : Form
    {
        public MH_Doc_Xuat()
        {
            InitializeComponent();

            var hoTen = File.ReadAllText("TyGiaSinUSD.txt");
            TH_HoTen.Text = hoTen;

        }
    }

