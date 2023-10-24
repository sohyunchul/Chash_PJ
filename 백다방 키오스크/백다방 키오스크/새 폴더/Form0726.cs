using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Windows.Forms.ComponentModel.Com2Interop;

// 1번 단답식 어제한거 2번 오늘진행한 간단한 코드 3번 오늘진행한 단답식 4번 코드 모달 대화상자까지

// tb(PictureBox), tb(TextBox), lb(label)

namespace WinFormsApp2
{
    public partial class Form0726 : Form
    {
        List<string> labels = new List<string>();
        List<string> plabels = new List<string>();
        int ICnt = 0; // 장바구니에 담긴 음료수 숫자
        public int sum; //음료가격

        public Form0726()
        {
            InitializeComponent();
            // 상품명 저장
            labels.Add(lbCoffeeN.Text);
            labels.Add(lbCoffeeN1.Text);
            labels.Add(lbCoffeeN2.Text);
            labels.Add(lbCoffeeN3.Text);
            labels.Add(lbCoffeeN4.Text);
            labels.Add(lbCoffeeN5.Text);

            labels.Add(lbCoffeeN6.Text);
            labels.Add(lbCoffeeN7.Text);

            // 상품가격 저장
            plabels.Add(lbCoffeeP.Text);
            plabels.Add(lbCoffeeP1.Text);
            plabels.Add(lbCoffeeP2.Text);
            plabels.Add(lbCoffeeP3.Text);
            plabels.Add(lbCoffeeP4.Text);
            plabels.Add(lbCoffeeP5.Text);
            plabels.Add(lbCoffeeP6.Text);
            plabels.Add(lbCoffeeP7.Text);
            pbCal.Image = imageList1.Images[8];
            pbCal1.Image = imageList1.Images[8];
            pbCal2.Image = imageList1.Images[8];
        }

        private void Form0726_Load(object sender, EventArgs e) // 키오스크 메인폼
        {
            // 초기 탭 페이지 추가
            TabPage tbCoffee = new TabPage(); // 커피 탭 페이지
            TabPage tbJuice = new TabPage(); // 음료 탭 페이지

            //탭 컨트롤에 탭페이지 추가
            tabControl1.TabPages.Add(tbCoffee);
            tabControl1.TabPages.Add(tbJuice);
        }

        // 메인 Coffee에서 커피 선택 
        private void pbCoffee_Click(object sender, EventArgs e) // 아메리카노HOT
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 0, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee2_Click_1(object sender, EventArgs e) //아메리카노ICED
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 1, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee3_Click(object sender, EventArgs e) //더블에스프레소
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 2, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee4_Click(object sender, EventArgs e) // 콜드브루라떼
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 3, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee5_Click(object sender, EventArgs e) //원조커피
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 4, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee6_Click(object sender, EventArgs e) // 달달연유라떼
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 5, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee7_Click(object sender, EventArgs e) // 바닐라라떼
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 6, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void pbCoffee8_Click(object sender, EventArgs e) // 아이스크림 카페모카
        {
            if (ICnt < 3)
            {
                Form0726_1 form0726_1 = new Form0726_1(imageList1, 7, labels, plabels);
                form0726_1.SendCompleted += new Form0726_1.SendToName(Setting_name);
                form0726_1.ShowDialog(); // 커피화면에서 상품확인 페이지 불러오는 코드
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // 커피(Coffee) 메뉴화면 이전버튼
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount + 1)
            {
                tabControl1.SelectedIndex -= 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e) // 커피(Coffee) 메뉴화면 다음버튼
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
            }
        }
        private void btnBack1_Click(object sender, EventArgs e) //음료화면 이전버튼
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount + 1)
            {
                tabControl1.SelectedIndex -= 1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) // 전체취소버튼
        {
            pbCal.Image = imageList1.Images[8];
            pbCal1.Image = imageList1.Images[8];
            pbCal2.Image = imageList1.Images[8];
            lbCal.Text = "";
            lbName.Text = "";
            lbName1.Text = "";
            lbName2.Text = "";
        }

        private void btnCal_Click(object sender, EventArgs e)  // 결제버튼
        {
            //Form0726_2 form0726_2 = new Form0726_2();
            //form0726_2.ShowDialog();
            if (ICnt == 0)
            {
                MessageBox.Show("장바구니에 음료를 담아주세요");
            }
            else
            {
                MessageBox.Show("결제가 완료되었습니다.");
                this.Close();
            }
        }

        public void Setting_name(string x, int idx, int _price)
        {
            sum = int.Parse(lbCal.Text.Substring(1, lbCal.Text.Length - 1));
            sum += _price;
            if (ICnt == 0)
            {
                lbName.Text = x; // 장바구니 이름
                pbCal.Image = imageList1.Images[idx]; //장바구니 이미지    
            }

            else if (ICnt == 1)
            {
                lbName1.Text = x; // 장바구니 이름
                pbCal1.Image = imageList1.Images[idx];
            }

            else if (ICnt == 2)
            {
                lbName2.Text = x; // 장바구니 이름
                pbCal2.Image = imageList1.Images[idx];
            }
            ICnt += 1;
            lbCal.Text = string.Format($"\\{sum}");
        }
    }
}