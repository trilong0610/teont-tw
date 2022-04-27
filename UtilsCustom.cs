using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAirdrop
{
    internal class UtilsCustom
    {
        public List<String> getNamesAllDicrectories(string path)
        {
            List<String> list = new List<String>();
            foreach (var d in System.IO.Directory.GetDirectories(@path))
            {
                string dirName = new DirectoryInfo(d).Name;
                System.Diagnostics.Debug.WriteLine(dirName);
                list.Add(dirName);

            }
            return list;
        }

        public void outToLog(RichTextBox logRichTextBox, string output)
        {
            logRichTextBox.AppendText("\r\n" + output);
            logRichTextBox.ScrollToCaret();
        }

        public void scrollSmooth(IWebDriver driver)
        {
            //Random rnd = new Random();

            //for (int i = 0; i < rnd.Next(400, 600); i++)
            //{
            //    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,"+ rnd.Next(1, 5) +")", "");
            //}

            Random rnd = new Random();

            int rangeScroll = rnd.Next(100, 400);

            int pixelScroll = 1;

            // Setup so pixel scroll

            if (rangeScroll < 20)
            {
                pixelScroll = rnd.Next(40, 50);
            }

            if (rangeScroll < 50)
            {
                pixelScroll = rnd.Next(30, 40);
            }

            if (rangeScroll < 100)
            {
                pixelScroll = rnd.Next(20, 30);
            }

            if (rangeScroll < 250)
            {
                pixelScroll = rnd.Next(10, 20);
            }

            if (rangeScroll <= 400)
            {
                pixelScroll = rnd.Next(1, 10);
            }

            try
            {
                for (int i = 0; i < rangeScroll; i++)
                {
                    if (!driver.ToString().Contains("null"))
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0," + pixelScroll + ")", "");
                    }
                    
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
