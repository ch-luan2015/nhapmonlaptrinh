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
    public partial class MH_CapNhatTyGia : Form
    {
        public MH_CapNhatTyGia()
        {
            InitializeComponent();


            //Doc ty gia USD tu file txt va show ra màn hình

           var TyGiaUSDFromFile = File.ReadAllText("TyGiaUSD.txt");
           Th_TygiaUSD.Text = TyGiaUSDFromFile;

          
                Th_CapNhatTyGia.Click += (Th, Ts) =>
                {

                    var TyGiaUSD = 0.0;
                    bool checkType = double.TryParse(Th_CapNhatTyGiaUSD.Text.Trim(), out TyGiaUSD) && TyGiaUSD>=0;

                    if (checkType)
                    {
                        var TyGiaUSDCapNhat = Th_CapNhatTyGiaUSD.Text.Trim();
                        File.WriteAllText("TyGiaUSD.txt", TyGiaUSDCapNhat);
                        Th_KetQua.Text = "Cập nhật thành công !";

                    }
                    else {
                        Th_KetQua.Text = "Không được để trống hoặc có ký tự";
                    }       
                };
            


        }
    }
}
