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

namespace ChuyenDoiTienTe
{
    public partial class MH_BanNgoaiTe : Form
    {
        public MH_BanNgoaiTe()
        {
            InitializeComponent();
            //Hien ty gia

            var TyGiaUSD = int.Parse(File.ReadAllText("TyGiaUSD.txt"));

            Th_TygiaUSD.Text = TyGiaUSD.ToString();
            //Nhap so luong
            int SoLuongMua = 0;

            Th_DongYThanhToan.Click += (Th, Ts) =>
            {
                Boolean checkInput = int.TryParse(Th_SoLuongUSDMua.Text.Trim(), out SoLuongMua);

                if (checkInput && Th_SoLuongUSDMua.Text.Trim()!="" && SoLuongMua>=1 )
                {
                    var ThanhTien = SoLuongMua * TyGiaUSD;
                    Th_ThanhTien.Text = ThanhTien.ToString();
                }
                else
                {
                    Th_ThanhTien.Text = "Xin hãy kiểm tra lại số lượng nhập";
                }
            };
           

        }

    }
}
