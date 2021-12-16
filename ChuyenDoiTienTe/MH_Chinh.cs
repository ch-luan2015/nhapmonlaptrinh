using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDoiTienTe
{
    public partial class MH_Chinh : Form
    {
        public MH_Chinh()
        {
            InitializeComponent();

            Button_MH_CapNhatTyGia.Click += (Th, Ts) =>
            {

                var openCapNhat = new MH_CapNhatTyGia();

                openCapNhat.ShowDialog();

            };

            Button_MH_BanNgoaiTe.Click += (Th, Ts) =>
            {

                var openBanNgoaiTe = new MH_BanNgoaiTe();

                openBanNgoaiTe.ShowDialog();

            };

        }

      
    }
}
