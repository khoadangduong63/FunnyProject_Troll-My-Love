using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_love_you
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int demKhong = 1;
        int demCo = 0;
        bool checkTroll = false;
        bool checkKhangCu = false;

        private void btnCo_Click(object sender, EventArgs e)
        {
            if(demKhong == 1)
            {
                MessageBox.Show("Anh biết em sẽ yêu anh từ lần đầu tiên mà \n\nAnh cũng yêu em nhiều lắm ngốc à! Moazzzzz moazzzz!");
                this.Close(); //Đóng form

            }
            if (demKhong > 1 && demCo < 4)
            {
                demCo++;
                switch (demCo)
                {
                    case 1:
                        MessageBox.Show("Sao nãy cự tuyệt Không yêu mà ple ple");
                        break;
                    case 2:
                        MessageBox.Show("Hồi nãy phũ anh thế nào, sao giờ bấm Có lia lịa vậy :p \n\nEm không thoát khỏi chương trình này đâu haha");
                        MessageBox.Show("\n\nBiết lỗi chưa bấm Có lại đi");
                        break;
                    case 3:
                        //if()
                        MessageBox.Show("Muốn thoát khỏi chương trình bấm vào nút \"Yêu anh nhiều lắm\" bên dưới");
                        btnTroll.Visible = true;
                        break;
                    case 4:
                        if (checkTroll == true)
                        {
                            MessageBox.Show("Ngoan thế anh mới cưng chứ! \n\nAnh cũng yêu em nhiều lắm ngốc à! Moazzzzz moazzzz!");
                            this.Close();
                        }
                        break;
                }
            }
            if(demCo == 4)
            {
                if (checkTroll == true)
                {
                    MessageBox.Show("Ngoan thế anh mới cưng chứ! \n\nAnh cũng yêu em nhiều lắm ngốc à! Moazzzzz moazzzz!");
                    this.Close(); //Đóng form
                }
                if(checkTroll == false)
                {
                    MessageBox.Show("Em lại bỏ bước rùi! \n\nPhải Yêu anh nhiều lắm cơ, anh mới tha cho");
                    checkKhangCu = true;
                    demCo = 2;
                }
            }
        }
      
        private void btnKhong_MouseMove(object sender, MouseEventArgs e)
        {
            Random rd = new Random();
            int ChieuCao = rd.Next(32, 500);
            int ChieuRong = rd.Next(211, 400);


            this.btnKhong.Location = new System.Drawing.Point(ChieuCao, ChieuRong);
            if (demKhong == 1)
            {
                MessageBox.Show("Anh biết em dối lòng mà haha");
                demKhong++;
            }
            else if (demKhong == 2)
            {
                MessageBox.Show("Chọn Có đi. Dối lòng không tốt đâu ;p");
                demKhong++;
            }
            else if (demKhong == 3)
            {
                MessageBox.Show("Dành cả tuổi thanh xuân để bấm Không hả?");
                demKhong++;
            }
            else if (demKhong == 4)
            {
                MessageBox.Show("Nghe lời anh chọn có đi mà");
                demKhong++;
            }
            else if (demKhong == 5)
            {
                MessageBox.Show("ĐM con này lì vãi");
                demKhong++;
            }
            else if (demKhong == 6)
            {
                DialogResult dlr = MessageBox.Show("Không cho yêu thì cho \"ấy\" xíu nhé =]]]]","",MessageBoxButtons.YesNo);
                if(dlr == DialogResult.Yes)
                {
                    MessageBox.Show("Haha hứa rùi nha, tối nay mấy giờ ở đâu nè \n\nNhớ nhắn tin cho anh biết nhé!");
                    MessageBox.Show("Moazzzz moazzzz chụt chụt");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không chịu thì thôi ple ple");
                }
                demKhong++;
            }
            else if (demKhong == 7)
            {
                MessageBox.Show("Nói rùi mà. Bấm có đi!");
                demKhong++;
            }
            else if (demKhong == 8)
            {
                MessageBox.Show("Ngoan cố hả? \n\nAnh cho em bấm tới mãn kinh luôn ;p");
                demKhong = 2;
            }
        }

        private void btnTroll_Click(object sender, EventArgs e)
        {
            if (checkKhangCu == false)
            {
                MessageBox.Show("Tin người vcl =]]]]]] \n\nEm yêu anh mà anh đâu có yêu em :p");
                MessageBox.Show("Em vừa chửi thề???? \n\nThôi tha cho em đó ;p \n\nPhải yêu anh nhất quả đất này nghe chưa. \n\nNgoan! Bấm có lại đi");
                btnTroll.Visible = false;
                checkTroll = true;
            }
            else
            {
                MessageBox.Show("Mệt rồi phải không? \n\nĐừng kháng cự nữa nhé =))))) \n\nNgoan! Bấm có lại đi");
                btnTroll.Visible = false;
                demCo = 4;
                checkTroll = true;
            }
        }
    }
}
