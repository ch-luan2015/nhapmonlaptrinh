using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class MH_Khai_Bao_Xu_Ly : Form
    {
        public MH_Khai_Bao_Xu_Ly()
        {
            InitializeComponent();

            var ChuoiKetXuat = "";

            var SGD = new XL_NGOAI_TE();
            SGD.MaSo = "SGD";
            SGD.Ten = "Dola Singapore";
            SGD.TyGiaBan = 16113.34;

        var SoLuong = 10;
        var Tien = SoLuong * SGD.TyGiaBan;

            ChuoiKetXuat.Text = ChuoiKetXuat;
        }

  
    }

public class XL_NGOAI_TE
{
    public string Ten;
    public string MaSo;
    public double TyGiaBan;
}