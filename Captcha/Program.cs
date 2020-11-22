using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含： 
            //随机字符串
            //混淆用的各色像素点
            //混淆用的直线（或曲线）
            const string Letters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Bitmap image = new Bitmap(500, 200);  //生成一个画板
            Graphics graphics = Graphics.FromImage(image);  //在画板基础上生成一个绘图对象
            graphics.Clear(Color.White);
            graphics.DrawLine(new Pen(Color.HotPink), new PointF(258F, 85F), new PointF(268F, 110F));
            graphics.DrawLine(new Pen(Color.DarkOrange), new PointF(350.2F, 100.2F), new PointF(265F, 98F));
            graphics.DrawLine(new Pen(Color.GhostWhite), new PointF(165F, 93F), new PointF(240F, 106F));
            graphics.DrawLine(new Pen(Color.DarkBlue), new PointF(436F, 120F), new PointF(265F, 95F));
            graphics.DrawLine(new Pen(Color.GreenYellow), new PointF(258F, 87F), new PointF(243F, 97F));
            graphics.DrawLine(new Pen(Color.Orange), new PointF(300, 95.6F), new PointF(250F, 123F));
            graphics.DrawLine(new Pen(Color.Blue), new PointF(350.2F, 106F), new PointF(235F, 109F));
            graphics.DrawLine(new Pen(Color.YellowGreen), new PointF(300, 120F), new PointF(245F, 97F));
            graphics.DrawLine(new Pen(Color.DarkRed), new PointF(400, 105F), new PointF(260F, 115F));
            Random random = new Random();
            int maxrand = Letters.Length - 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(maxrand);
                sb.Append(Letters[index]);
            }
            string captcha = sb.ToString();

            graphics.DrawString(captcha, new Font("宋体", 24), new SolidBrush(Color.DarkBlue), new PointF(225F, 90F));
            image.SetPixel(240, 95, Color.Yellow);
            image.SetPixel(245, 105, Color.GreenYellow);
            image.SetPixel(230, 115, Color.Red);
            image.SetPixel(260, 99, Color.Brown);
            image.SetPixel(270, 120, Color.OrangeRed);
            image.SetPixel(265, 110, Color.Green);

            image.Save(@"D:\YUANZHAN作业\Photo.jpg", ImageFormat.Jpeg);
        }
        //public static int red { get; }
        //public static int blue { get; }
        //public static int green { get; }

    }
}
