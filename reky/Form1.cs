using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void video(string aa)
        {
            this.Text = aa;
            if (aa=="")
            {
                return;
            }
            string[] hairetu = Directory.GetFiles(@"E:\Users\ttanakattarou\Videos\");
            var d = from z in hairetu where true == z.Contains(aa) select z;
            foreach (var item in d)
            {
                FileStream fs;
                try
                {
                    fs = new FileStream(item, FileMode.Open);//ファイル読み込む
                }
                catch (Exception)
                {
                    continue;
                }
                
                BinaryReader br = new BinaryReader(fs);//バイナリリーダー

                Regex regex = new Regex(@"\d.*\.ts$");
                MatchCollection matchCol = regex.Matches(item);
                Match xxx = null;
                foreach (Match match in matchCol)
                {
                    xxx = match;
                }
                if (xxx == null)
                {
                    br.Close();
                    fs.Close();
                    System.IO.File.Delete(item);
                    continue;
                }
                if (fs.Length < 2147483648)
                {
                    var a = br.ReadBytes((int)fs.Length);//現在のストリームから引数の数値分読み込む

                    System.IO.Directory.CreateDirectory(@"E:\Users\ttanakattarou\Videos\" + aa);
                    FileStream file = new FileStream(@"E:\Users\ttanakattarou\Videos\"+aa+@"\" + xxx, FileMode.Create, FileAccess.ReadWrite);
                    file.Seek(0, SeekOrigin.Begin);//シークの開始位置 移動場所
                    file.Write(a, 0, a.Count());//byte配列 配列の何番目から書き込みを開始位置 書き込みバイト数

                    file.Close();

                    br.Close();
                    fs.Close();

                    System.IO.File.Delete(item);


                }
                else
                {
                    long size = fs.Length;

                    List<byte[]> buf = new List<byte[]>();

                    while (size > 0x70000000)
                    {
                        var abbuf = br.ReadBytes(0x70000000);//現在のストリームから引数の数値分読み込む
                        buf.Add(abbuf);

                        size -= 0x70000000;
                    }
                    var abbu = br.ReadBytes((int)size);//現在のストリームから引数の数値分読み込む
                    buf.Add(abbu);


                    System.IO.Directory.CreateDirectory(@"E:\Users\ttanakattarou\Videos\"+aa);
                    FileStream file = new FileStream(@"E:\Users\ttanakattarou\Videos\" + aa + @"\" + xxx, FileMode.Create, FileAccess.ReadWrite);
                    file.Seek(0, SeekOrigin.Begin);//シークの開始位置 移動場所

                    for (int i = 0; i < buf.Count; i++)
                    {
                        file.Write(buf[i], 0, buf[i].Count());//byte配列 配列の何番目から書き込みを開始位置 書き込みバイト数
                    }


                    file.Close();

                    br.Close();
                    fs.Close();
                    System.IO.File.Delete(item);

                }



            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            video(button1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            video("ソフトウェアのしくみ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            video(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            video(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            video("映像メディアとCGの基礎");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            video("データベースと情報管理");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            video("データ構造とプログラミング");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            video(button8.Text);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            video("微分方程式への誘い");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            video(button9.Text);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            video("情報の世界");
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            video(button12.Text);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            video("コンピュータの動作と管理");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            video("微分と積分");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            video("コンピュータと人間の接点");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            video(button16.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            video(button17.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            video(button18.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            video(button19.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            video(button20.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            video(button21.Text);
        }
        
        private void button22_Click_1(object sender, EventArgs e)
        {
            video(button22.Text);
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            video(button23.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            video(button24.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            video(button25.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            video(button26.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            video(button27.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            video(button28.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            video(button30.Text);
        }
        
        private void button31_Click(object sender, EventArgs e)
        {
            video(button31.Text);
        }
        
        private void button32_Click(object sender, EventArgs e)
        {
            video(button32.Text);
        }















        private void button29_Click(object sender, EventArgs e)
        {
            video(button1.Text);
            video(button2.Text);
            video(button3.Text);
            video(button4.Text);
            video(button5.Text);
            video(button6.Text);
            video(button7.Text);
            video(button8.Text);
            video(button9.Text);
            video(button10.Text);
            video(button11.Text);
            video(button12.Text);
            video(button13.Text);
            video(button14.Text);
            video(button15.Text);
            video(button16.Text);
            video(button17.Text);
            video(button18.Text);
            video(button19.Text);
            video(button20.Text);
            video(button21.Text);
            video(button22.Text);
            video(button23.Text);
            video(button24.Text);
            video(button25.Text);
            video(button26.Text);
            video(button27.Text);
            video(button28.Text);
            //video(button29.Text);
            video(button30.Text);
            video(button31.Text);
            video(button32.Text);
            video(button33.Text);
            video(button34.Text);
            video(button35.Text);
            video(button36.Text);
            video(button37.Text);
            video(button38.Text);
            video(button39.Text);



        }

        private void button33_Click(object sender, EventArgs e)
        {
            video(button33.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            video(button34.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            video(button36.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            video(button35.Text);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            video(button37.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            video(button38.Text);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            video(button39.Text);
        }
    }
}
