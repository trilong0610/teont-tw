using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AutoAirdrop
{
    public partial class Form1 : Form
    {
        private Brower brower;
        public static bool flagDriverOpened = false;
        private UtilsCustom utilsCustom;
        private Twitter twitter;
        public Queue<string> chromeDirectorys;
        List<BackgroundWorker> workerList;
        List<IWebDriver> driverList;

        public Form1()
        {
            InitializeComponent();
            brower = new Brower();
            utilsCustom = new UtilsCustom();
            twitter = new Twitter();
            chromeDirectorys = new Queue<string>();
            workerList = new List<BackgroundWorker>();
            driverList = new List<IWebDriver>();


            txt_tw_url_dic_brave.Text = @"D:\Study\CSharp\AutoAirdrop\braveProfile";
            txt_tw_profile_from.Text = "45";
            txt_tw_profile_to.Text = "60";
            txt_tw_sleep_from.Text = "2";
            txt_tw_sleep_to.Text = "3";
            txt_num_thread.Text = "2";
            txt_url_post.Text = @"https://twitter.com/JJKPerfectShots/status/1516089492515569675";

        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            //string pathData = txt_tw_url_dic_brave.Text + @"\1-2-3"+  @"\b\data\";
            //string profile = @"Default";
            //string pathApp = txt_tw_url_dic_brave.Text + @"\b\brave-portable.exe";
            //string url = @"https://twitter.com/JJKPerfectShots/status/1516089492515569675";
            //try
            //{
            //    //createThreadTwitter(pathData, profile, pathApp, url);
            //}
            //catch (Exception ex)
            //{

            //    utilsCustom.outToLog(richTextBoxLog, ex.Message);
            //}


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dong tat ca driver
            try
            {
                foreach (var driver in driverList)
                {
                    driver.Close();
                    driver.Quit();
                }
            }
            catch (Exception)
            {

                utilsCustom.outToLog(richTextBoxLog, "Đã xảy ra lỗi khi đóng trình duyệt!"); ;
            }
            // Dong tat ca thread
            try
            {
                
                foreach (var worker in workerList)
                {
                    if (worker.IsBusy)
                    {
                        worker.CancelAsync();
                    }

                }
                

            }
            catch (Exception)
            {

                utilsCustom.outToLog(richTextBoxLog, "Đã xảy ra lỗi khi đóng Thread!");
            }

        }

        private void btn_tw_stop_Click(object sender, EventArgs e)
        {
            // Dong tat ca driver
            try
            {
                foreach (var driver in driverList)
                {
                    driver.Close();
                    driver.Quit();
                }
            }
            catch (Exception)
            {

                utilsCustom.outToLog(richTextBoxLog, "Đã xảy ra lỗi khi đóng trình duyệt!"); ;
            }

            // Dong tat ca thread
            try
            {
                
                foreach (var worker in workerList)
                {
                    if (worker.IsBusy)
                    {
                        worker.CancelAsync();
                        utilsCustom.outToLog(richTextBoxLog, "Đã đóng Thread!");
                    }

                }

            }
            catch (Exception) { 
            
                utilsCustom.outToLog(richTextBoxLog, "Đã xảy ra lỗi khi đóng Thread!");
            }

        }

        private async void btn_tw_start_Click(object sender, EventArgs e)
        {


            // Lay ten dic tung profile brave
            //List<String> listProfile = utilsCustom.getNamesAllDicrectories(@txt_tw_url_dic_brave.Text);

            //utilsCustom.outToLog(richTextBoxLog, "Đang chạy profile" + childProfile);
            //utilsCustom.outToLog(richTextBoxLog, childProfile);
            //D:\Study\CSharp\AutoAirdrop\braveProfile\1-2-3\1


            // tao driver brave

            // tao thread 

            // Chay tung profile 
            
            int numberThread = Int32.Parse(txt_num_thread.Text);
            int fromProfile = Int32.Parse(txt_from_profile.Text);
            int toProfile = Int32.Parse(txt_to_profile.Text);

            string url = txt_url_post.Text;
            string pathBrave = @txt_tw_url_dic_brave.Text;
            //--------------------------------------------------------------------
            try
            {
                interactiveProfileTwitter(numberThread, fromProfile, toProfile, pathBrave, url);
            }
            catch (Exception ex)
            {

                richTextBoxLog.Text = "Đã xảy ra lỗi!";
                richTextBoxLog.Text = ex.Message;
            }
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createThreadTwitter(int numberProfile, string pathData, string pathApp, string url)
        {
            //D:\Study\CSharp\AutoAirdrop\braveProfile\1-2-3

            // Them ten toan bo chromeprofile vao queue

            

            
        }

        private void interactiveProfileTwitter(int numberThread,int fromProfile, int toProfile, string pathBrave, string url)
        {
            // Lay toan bo ten chrome profile
            List<string> listNameDir = utilsCustom.getNamesAllDicrectories(@pathBrave);
            if (toProfile >= listNameDir.Count)
            {
                utilsCustom.outToLog(richTextBoxLog, "Số profile nhập vượt quá profile hiện có !");
                return;
            }
            if (toProfile > 0 && fromProfile < toProfile)
            {
                for (int i = fromProfile; i <= toProfile; i++)
                {
                    chromeDirectorys.Enqueue(listNameDir[i]);
                }
            }
            else
            {
                if (fromProfile == toProfile)
                {
                    chromeDirectorys.Enqueue(listNameDir[fromProfile]);
                }
                else
                {
                    utilsCustom.outToLog(richTextBoxLog, "Vui lòng nhập đúng số profile !");
                }
            }
            
            foreach (string item in utilsCustom.getNamesAllDicrectories(@pathBrave))
            {
                chromeDirectorys.Enqueue(item);
            }

            // tao so thread theo nguoi dung nhap
            for (int i = 0; i < numberThread; i++)
            {
                richTextBoxLog.Clear();
                BackgroundWorker worker = new BackgroundWorker();
                
                worker.WorkerReportsProgress = true;
                worker.DoWork += worker_DoWork;
                worker.ProgressChanged += worker_ProgressChanged;
                worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                worker.WorkerSupportsCancellation = true;
                worker.RunWorkerAsync();
                workerList.Add(worker);

            }
        }

        private void txt_num_profile_in_dic_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((sender as BackgroundWorker).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            if (chromeDirectorys.Count == 0)
            {
                e.Cancel = true;
                e.Result = "Đóng thread do số chrome profile không đủ";
                return;
            }
            string chromeDirectory = chromeDirectorys.Dequeue(); // 1-2-3
            string pathData = txt_tw_url_dic_brave.Text + @"\" + chromeDirectory + @"\b\data\";
            string pathApp = txt_tw_url_dic_brave.Text + @"\" + chromeDirectory + @"\b\brave-portable.exe";
            List<String> listUserNameDir = new List<String>();
            listUserNameDir.Add("Default");
            // lay ten cac user profile co trong chrome profile Default, Profile 1, Profile 2
            if ((sender as BackgroundWorker).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            foreach (var item in utilsCustom.getNamesAllDicrectories(@pathData))
            {
                if (Regex.IsMatch(item, @"\bProfile \S*"))
                {
                    listUserNameDir.Add(item);
                }
            }


            try
            {
                foreach (var profileName in listUserNameDir)
                {
                    BackgroundWorker worker = new BackgroundWorker();
                    
                    
                    (sender as BackgroundWorker).ReportProgress(0, "Bắt đầu chạy " + chromeDirectory + " - " + profileName);
                    //tao driver chay brower
                    IWebDriver driver = brower.CreateBrowserProfile(pathData, profileName, pathApp);
                    driverList.Add(driver);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    flagDriverOpened = true; // Danh dau trinh duyet dang mo

                    //driver = brower.CreateBrowserDefault();
                    checkCancelWorker((sender as BackgroundWorker), e, driver,"Thread đã được dừng");
                    driver.Url = @txt_url_post.Text;
                    driver.Navigate();
                    checkCancelWorker((sender as BackgroundWorker), e, driver, "Thread đã được dừng");
                    Thread.Sleep(1000);

                    checkCancelWorker((sender as BackgroundWorker), e, driver, "Thread đã được dừng");
                    twitter.followUser(driver);
                    Thread.Sleep(1000);

                    checkCancelWorker((sender as BackgroundWorker), e, driver, "Thread đã được dừng");
                    twitter.likePost(driver);
                    Thread.Sleep(1000);

                    checkCancelWorker((sender as BackgroundWorker), e, driver, "Thread đã được dừng");
                    twitter.retweetPost(driver);
                    Thread.Sleep(1000);

                    driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/header/div/div/div/div[1]/div[1]")).Click();
                    Thread.Sleep(2000);

                    int countScroll = new Random().Next(2, 5);

                    // Luot newfeed
                    while (countScroll >= 0)
                    {
                        checkCancelWorker((sender as BackgroundWorker), e, driver, "Thread đã được dừng");
                        int sleepFrom = Int32.Parse(txt_tw_sleep_from.Text) * 1000;
                        int sleepTo = Int32.Parse(txt_tw_sleep_to.Text) * 1000;
                        //new Random().Next(sleepFrom, sleepTo)
                        Thread.Sleep(new Random().Next(sleepFrom, sleepTo));
                        utilsCustom.scrollSmooth(driver);
                        //Luot giong key pageup
                        //Actions actions = new Actions(driver);
                        //actions.SendKeys(OpenQA.Selenium.Keys.PageDown).Build().Perform();
                        countScroll--;

                    };
                    driver.Close();
                    driver.Quit();
                    (sender as BackgroundWorker).ReportProgress(0, "Đã chạy xong " + chromeDirectory + " - " + profileName);

                }
            }
            catch (Exception ex)
            {
                (sender as BackgroundWorker).ReportProgress(0, "Đã xảy ra lỗi tại: " + chromeDirectory);
                (sender as BackgroundWorker).ReportProgress(0, ex.Message);
            }
            // Tra ve ket qua sau khi hoan thanh cong viec
            e.Result = "Đã hoàn thành " + chromeDirectory;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if (e.UserState != null)
                utilsCustom.outToLog(richTextBoxLog, e.UserState.ToString());
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          

            if (e.Cancelled)
            {
                utilsCustom.outToLog(richTextBoxLog, "Thread đã được đóng thủ công!");
            }
            else
            {
                utilsCustom.outToLog(richTextBoxLog, e.Result.ToString());
            }

        }

        void checkCancelWorker(BackgroundWorker worker, DoWorkEventArgs e, IWebDriver driver, string message)
        {
            if (worker.CancellationPending)

            {
                driver.Close();
                driver.Quit();
                e.Result = message;
                e.Cancel = true;
                
                return;
            }
        }
    }
}
