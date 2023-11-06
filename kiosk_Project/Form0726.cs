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

namespace kioskProject
{
    public partial class Form0726 : Form
    {
        List<string> labels = new List<string>();
        List<string> plabels = new List<string>();
        int ICnt = 0; // 장바구니 칸
        public int sum; //음료가격
        public Form0726_1 form0726_1;

        /// <summary>
        /// 현재 장바구니 1개당 변수 1개의 가격씩 따로 담았던 것을 
        /// 밑에 int 배열을 통해서 일괄처리 하는 코드로 바꿀 것 
        /// </summary>
        int[] basket = new int[3]; // 장바구니 제품 당 가격을 담을 배열
        int one, two, three; // 장바구니 제품 당 가격을 담을 변수들 

        public Form0726()
        {
            InitializeComponent();
            // 상품명 저장, LabelcoffeeName
            labels.Add(lbCoffeeN.Text);
            labels.Add(lbCoffeeN1.Text);
            labels.Add(lbCoffeeN2.Text);
            labels.Add(lbCoffeeN3.Text);
            labels.Add(lbCoffeeN4.Text);
            labels.Add(lbCoffeeN5.Text);
            labels.Add(lbCoffeeN6.Text);
            labels.Add(lbCoffeeN7.Text);

            // 상품가격 저장, Labelcoffeeprice
            plabels.Add(lbCoffeeP.Text);
            plabels.Add(lbCoffeeP1.Text);
            plabels.Add(lbCoffeeP2.Text);
            plabels.Add(lbCoffeeP3.Text);
            plabels.Add(lbCoffeeP4.Text);
            plabels.Add(lbCoffeeP5.Text);
            plabels.Add(lbCoffeeP6.Text);
            plabels.Add(lbCoffeeP7.Text);

            // 장바구니
            pbCal.Image = imageList1.Images[8];
            pbCal1.Image = imageList1.Images[8];
            pbCal2.Image = imageList1.Images[8];
        }


        // 키오스크 메인폼
        private void Form0726_Load(object sender, EventArgs e) {
            // 초기 탭 페이지 추가
            TabPage tbCoffee = new TabPage(); // 커피 탭 페이지
            TabPage tpNonCoffee = new TabPage(); // 음료 탭 페이지

            //탭 컨트롤에 탭페이지 추가
            tabControl1.TabPages.Add(tbCoffee);
            tabControl1.TabPages.Add(tpNonCoffee);
        }


        private void pbCoffee_Click(object sender, EventArgs e) {
            if (ICnt < 3)
            {
                if (sender is PictureBox pb)
                {
                    switch (pb.Name)
                    {
                        case "pbCoffee": form0726_1  = new Form0726_1(imageList1, 0, labels, plabels); break;
                        case "pbCoffee2": form0726_1 = new Form0726_1(imageList1, 1, labels, plabels); break;
                        case "pbCoffee3": form0726_1 = new Form0726_1(imageList1, 2, labels, plabels); break;
                        case "pbCoffee4": form0726_1 = new Form0726_1(imageList1, 3, labels, plabels); break;
                        case "pbCoffee5": form0726_1 = new Form0726_1(imageList1, 4, labels, plabels); break;
                        case "pbCoffee6": form0726_1 = new Form0726_1(imageList1, 5, labels, plabels); break;
                        case "pbCoffee7": form0726_1 = new Form0726_1(imageList1, 6, labels, plabels); break;
                        case "pbCoffee8": form0726_1 = new Form0726_1(imageList1, 7, labels, plabels); break;
                    }
                    
                    form0726_1.SendCompleted += new Form0726_1.SendToName(SettingName);
                    form0726_1.sendPrice += new Form0726_1.SendClac(SettingPrice);
                    form0726_1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("장바구니가 꽉 찼습니다.");
                return;
            }
        }

        // 커피(Coffee) 메뉴화면 이전버튼
        private void btnBack_Click(object sender, EventArgs e) 
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount + 1)
            {
                tabControl1.SelectedIndex -= 1;
            }
        }

        // 커피(Coffee) 메뉴화면 다음버튼
        private void btnNext_Click(object sender, EventArgs e) 
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
            }
        }

        //음료화면 이전버튼
        private void btnBack1_Click(object sender, EventArgs e) 
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount + 1)
            {
                tabControl1.SelectedIndex -= 1;
            }
        }

        // 전체취소버튼
        private void btnCancel_Click(object sender, EventArgs e) 
        {
            ICnt = 0;
            one = 0;
            two = 0;
            three = 0;
            pbCal .Image = imageList1.Images[8];
            pbCal1.Image = imageList1.Images[8];
            pbCal2.Image = imageList1.Images[8];
            lbCal  .Text = "";
            lbName .Text = "";
            lbName1.Text = "";
            lbName2.Text = "";
        }

        // 결제버튼
        private void btnCal_Click(object sender, EventArgs e)  
        {
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

        // 장바구니에 담기는 가격, 상품명, 이미지
        public void SettingName(string x, int idx, int _price)
        {                   
            if (ICnt == 0)
            {
                one = _price;
                lbName.Text = x; // 장바구니 이름
                pbCal.Image = imageList1.Images[idx]; //장바구니 이미지
            }

            else if (ICnt == 1)
            {
                two = _price;
                lbName1.Text = x; // 장바구니 이름
                pbCal1.Image = imageList1.Images[idx];
            }

            else if (ICnt == 2)
            {
                three = _price;
                lbName2.Text = x; // 장바구니 이름
                pbCal2.Image = imageList1.Images[idx];
            }                       

            ICnt += 1;            
            lbCal.Text = string.Format($"\\{one + two + three}");            
        }       

        // 선택메뉴 최종가격을 메인으로 가져오는 함수
        private void SettingPrice(int price)
        {
            lbCal.Text = price.ToString();
        }
    }
}