using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoAirdrop
{
    internal class Twitter
    {

        public void likePost(IWebDriver driver)
        {
            //driver.FindElement(By.XPath("//div[1]/div/div/article/div/div/div/div[2]/div[2]/div[2]/div[3]/div/div[3]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/main/div/div/div/div/div/section/div/div/div[1]/div/div[1]/article/div/div/div/div[3]/div[5]/div/div[3]")).Click();
            IWebElement element = driver.FindElement(By.XPath("//div/section/div/div/div[1]/div/div[1]/article/div/div/div/div[3]/div[5]/div/div[3]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
            Thread.Sleep(1000);
            element.Click();
        }

        public void retweetPost(IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            IWebElement element;
            //driver.FindElement(By.XPath("//div[1]/div/div/article/div/div/div/div[2]/div[2]/div[2]/div[3]/div/div[3]")).Click();
            element = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]" +
                "/main/div/div/div/div/div/section/div/div/div[1]/div/div[1]/article/div/div/div/div[3]/div[5]/div/div[2]"));
            actions.MoveToElement(element);
            actions.Perform();
            element.Click();
            Thread.Sleep(1000);

            string retweet = driver.FindElement(By.XPath("/ html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/div/div[2]/div/span")).Text;
            // Kiem tra neu chua retweet thi retweet lai, nguoc lai thoat 
            if (retweet.Contains("Undo"))
            {
                element =  driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/div"));
                actions.MoveToElement(element);
                actions.Perform();
                element.SendKeys(Keys.Escape);
                Thread.Sleep(1000);
                
            }
            else
            {
                
                element = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/div"));
                actions.MoveToElement(element);
                actions.Perform();
                element.Click();
                Thread.Sleep(1000);
            }

            
        }

        public void followUser(IWebDriver driver)
        {
            //Nhan dau 3 cham
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/main/div/div/div/div/div/section/div/div/div[1]/div/div[1]" +
                "/article/div/div/div/div[2]/div[2]/div/div/div/div[2]")).Click();

            Thread.Sleep(1000);

            string statusFollow = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/span")).Text;
            // kiem tra chu follow co ton tai khong
            // Neu co nghia la chua fl, tien hanh fl
            if (statusFollow.Contains("Follow"))
            {
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/div[1]")).Click();
                Thread.Sleep(1000);
            }
            else
            {
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/div[1]")).SendKeys(Keys.Escape);
                Thread.Sleep(1000);
            }
            
            

            
        }   

        public void commentPost(IWebDriver driver)
        {
            //driver.FindElement(By.XPath("//div[1]/div/div/article/div/div/div/div[2]/div[2]/div[2]/div[3]/div/div[3]")).Click();

            //click button tweet
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/main/div/div/div/div/div/section/div/div/div[1]/div/div[1]/article/div/div/div/div[3]/div[5]/div/div[2]")).Click();

            //click quotetweet
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/div[3]/div/div/div/a")).Click();

            //type friends
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div/div/div[2]" +
                "/div[2]/div/div/div/div[3]/div/div[1]/div/div/div/div/div[2]")).SendKeys("BB3");

            //click button tweet
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div/div[3]" +
                "/div/div[1]/div/div/div/div/div[2]/div[3]/div/div/div[2]")).Click();

            //"<div data-contents="true"><div class="" data-block="true" data-editor="eupct" data-offset-key="ag1ev-0-0"><div data-offset-key="ag1ev-0-0" class="public-DraftStyleDefault-block public-DraftStyleDefault-ltr"><span data-offset-key="ag1ev-0-0"><span data-text="true">hhghhhjjjhhgg</span></span></div></div></div>"
        }


    }
}
