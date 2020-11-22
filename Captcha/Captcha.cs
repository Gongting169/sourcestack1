using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
   public static class Captcha
    {
        /// <summary>
        /// 生成随机的字符串
        /// </summary>
        /// <returns>返回的是4位的随机字符串</returns>
        public static string GetRadomString()
        {
            const string Letter = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            int maxrand = Letter.Length - 1;
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(maxrand);
                sb.Append(Letter[index]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 生成随机的背景颜色
        /// </summary>
        /// <returns>返回的是Color</returns>
        public static Color GetRadomColor()
        {
            int Blue = 255, Green = 255, Red = 255;
            Random random = new Random();
            int rblue = random.Next(Blue);
            int rgreen = random.Next(Green);
            int rred = random.Next(Red);
            return Color.FromArgb(rblue, rred, rgreen);
        }
        /// <summary>
        /// 生成一个自定义大小的画布
        /// </summary>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        /// <returns>返回BitMap类型</returns>
        public static Bitmap GetRadomBitMap(int width, int height)
        {
            Bitmap image = new Bitmap(width, height);
            return image;
        }
       /// <summary>
       /// 在验证码里画随机生成的直线
       /// </summary>
        public static void GetRadomLine()
        {
            Graphics graphics = Graphics.FromImage(GetRadomBitMap(500, 200));
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 20); i++)
            {
                Pen linepen = new Pen(new SolidBrush(Color.Black), 3);
                Point startpoint = new Point(random.Next(0, 500), random.Next(0, 200));
                Point endpoint = new Point(random.Next(0, 500), random.Next(0, 200));
                graphics.DrawLine(linepen, startpoint, endpoint);

                //Point bezierPoint1 = new Point(rand.Next(0, 500), rand.Next(0, 200));
                //Point bezierPoint2 = new Point(rand.Next(0, 500), rand.Next(0, 200));

                //graph.DrawBezier(linePen, startPoint, bezierPoint1, bezierPoint2, endPoint);
            }
        }
        /// <summary>
        /// 给随机的点换颜色
        /// </summary>
        /// <returns></returns>
        public static Color GetRandomDeepColor()
        {
            Random random = new Random();
            int red = 160, green = 100, blue = 160;
            return Color.FromArgb(random.Next(red), random.Next(green), random.Next(blue));
        }
        /// <summary>
        /// 画随机的点，以不同的颜色
        /// </summary>
        public static void GetRadomPoint()
        {
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            Font font1 = new Font("宋体", 3);
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                fontBrush.Color = GetRandomDeepColor();
                float x = random.Next(0, 500);
                float y = random.Next(0, 200);
                Graphics.FromImage(GetRadomBitMap(500, 200)).DrawString(GetRadomString().ToString(), font1, fontBrush, x, y);
            }
        }


    }
}



