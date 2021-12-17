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


    public partial class MH_Nhap_Ghi : Form
    {
        public MH_Nhap_Ghi()
        {
            InitializeComponent();

            TH_DongY.Click += (Th,Ts) =>
            {

                //Check rong
   
                bool hopLe = TH_NhapGhi.Text.Trim()!="";
                if (hopLe)
                {
                    var hoTen = TH_NhapGhi.Text.Trim();
                    //Ghi ra file txt
                    File.WriteAllText("hoten.txt", hoTen);
                    TH_kq.Text = "Đã ghi họ và tên";
                }
                else {
                     TH_kq.Text = "Không được để trống tên";
       
                }
        
                //Doc nguoi lai tu file da ghi
                TH_kqFile.Text = File.ReadAllText("hoten.txt");
            };
        }

       
    }

