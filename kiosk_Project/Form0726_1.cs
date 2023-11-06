using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kioskProject
{
    public partial class Form0726_1 : Form {
        public delegate void SendToName(string _name, int idx, int price); // 이름, 이미지, 가격        
        public delegate void SendClac(int price);
        public event SendToName SendCompleted;
        public event SendClac sendPrice;
        public int Iidx;
        public int ISave_Price;
        public int cnt = 1;
        public int originalValue; // shot 수량을 담을 변수
        public int totalPrice; // shot 총 가격

        string a; // 상품확인 화면 초기값
        int price = 0; //price  (상품 가격 메인폼과 연동하여 출력)
        int originalPrice = 0; // 원래 가격을 갖고 있는 변수
        public Form0726_1(ImageList i, int index, List<string> l, List<string> p) {
            InitializeComponent();
            imageList2 = i;
            Iidx = index;
            pbItem1.Image = imageList2.Images[index]; // 메인폼에서 상품선택 시 동일 이미지 출력

            lbItem1.Text = l[index]; //labels (상품명 메인폼과 연동하여 출력)

            string[] arr = p[index].Split(',');
            string[] t = arr[0].Split("\\");
            a += t[1];
            for (int j = 1; j < arr.Length; j++)
                a += arr[j];
            lbPrice.Text = "\\" + a;

            originalValue = int.Parse(numericUpDown.Value.ToString());
            
            price = int.Parse(a);
            originalPrice = int.Parse(a);
        }

        // 용도 : 최종 금액을 넘기는 것
        // 확인버튼 눌렀을 때 주문확인창 닫히고 저장된 상품 메인화면 장바구니에 담길수 있게
        private void btnOk_Click(object sender, EventArgs e) {
            string[] arr = lbPrice.Text.Split('\\');
            sendPrice(int.Parse(arr[1]));
            SendCompleted(lbItem1.Text, Iidx, int.Parse(arr[1]));            
            this.Close();
        }

        // 용도 : lbPrice 가 샷추가된 금액으로 바꾸기 위함
        private void numericUpDown_ValueChanged(object sender, EventArgs e) {
            lbPrice.Text = "\\" + MenuAcountCalcuration().ToString();
        }
                
        // (이전 / 이후) Shot 수량에 대한 금액 계산 함수
        private int MenuAcountCalcuration() {
            int afterValue = int.Parse(numericUpDown.Value.ToString());

            string[] arr = lbshot.Text.Split("\\");
            string[] arr2 = lbPrice.Text.Split("\\");
            int shotPrice = int.Parse(arr[1]);
                        
            // 이전 수량 보다 클 경우
            if (originalValue < afterValue )
            {
                totalPrice = int.Parse(arr2[1]) + shotPrice;
            }
            // 이전 수량 보다 작을 경우
            else if (originalValue > afterValue)
            {
                totalPrice = int.Parse(arr2[1]) - shotPrice;
            }

            originalValue = afterValue;
            
            return totalPrice;
        }
       
        // 제품 수량 
        private void btn_Count_Click(object sender, EventArgs e) {
            if (cnt > 0)
            {
                 cnt = int.Parse(lb_Cnt.Text);

                 string[] arr = lbPrice.Text.Split("\\");

                 if (sender is Button btn)
                 {
                     switch (btn.Name)
                     {
                         case "btn_Plus":
                             cnt += 1;
                             lbPrice.Text = "\\" + (int.Parse(arr[1]) + originalPrice).ToString();
                             break;
                         case "btn_Minus":
                            if (cnt == 1)
                            {
                                break;
                            }                                                            
                              cnt -= 1;
                              lbPrice.Text = "\\" + (int.Parse(arr[1]) - originalPrice).ToString();                            
                             break;
                     }                    
                 }                                   
                 lb_Cnt.Text = cnt.ToString();             
            }
        }
    }
}

