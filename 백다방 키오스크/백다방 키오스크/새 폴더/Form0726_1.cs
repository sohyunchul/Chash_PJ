using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2

{
    public partial class Form0726_1 : Form
    {
        public delegate void SendToName(string _name, int idx, int price); // 
        public event SendToName SendCompleted;
        public int Iidx;
        public int ISave_Price;
        /*public delegate void SendToPrice(string _price,int idx1);
        public event SendToPrice SendCompleted1;
        public int Iidx1;*/

        string a;
        int price = 0;
        public Form0726_1(ImageList i, int index, List<string> l, List<string> p)
        {
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
            lbPrice.Text = "\\" + a; // 상품확인 화면 초기값 출력

            //price  (상품 가격 메인폼과 연동하여 출력)
            price = int.Parse(a);
        }

        // 확인버튼 눌렀을 때 주문확인창 닫히고 저장된 상품 메인화면 장바구니에 담길수 있게
        private void btnOk_Click(object sender, EventArgs e)
        {
            SendCompleted(lbItem1.Text, Iidx, ISave_Price);
            //SendCompleted1(lbPrice.Text, Iidx1);
            this.Close();
        }

        private void btn_Minus_Click(object sender, EventArgs e) // 수량 감소
        {
            int cnt = int.Parse(lb_Cnt.Text);

            if (cnt > 1)
            {
                cnt -= 1;
            }
            //price = int.Parse(a); // form0726에서 받아온 가격을 int형으로 변환
            a = ISave_Price.ToString();
            lb_Cnt.Text = cnt.ToString();
            ISave_Price = int.Parse(lb_Cnt.Text) * price;
            lbPrice.Text = string.Format($"\\{ISave_Price}");
        }

        private void btn_Plus_Click(object sender, EventArgs e) // 수량 증가
        {

            int cnt = int.Parse(lb_Cnt.Text);
            cnt += 1;
            lb_Cnt.Text = cnt.ToString();

            // price = int.Parse(a); // form0726에서 받아온 가격을 int형으로 변환
            ISave_Price = int.Parse(lb_Cnt.Text) * price;
            a = ISave_Price.ToString();
            lbPrice.Text = string.Format($"\\{ISave_Price}");
        }
    }
}