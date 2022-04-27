using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutoAirdrop
{

    public class Brower
    {
        public Brower()
        {
        }

        public IWebDriver CreateBrowserProfile(string pathData, string profile, string pathExe)
        {
            try
            {
                var options = new ChromeOptions();
                //options.AddArgument("test-type");
                options.AddArgument("--ignore-certificate-errors");
                //options.AddArgument("no-sandbox");
                options.AddArgument("disable-infobars");
                //options.AddArgument("--headless"); //hide browser
                //options.AddArgument("--start-maximized");
                //options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);

                // Profile [Change:User name]
                options.AddArgument(@"user-data-dir=" + @pathData);
                options.AddArgument("profile-directory=" + @profile);
                options.BinaryLocation = @pathExe;
                options.AddUserProfilePreference("media.peerconnection.enabled", false);



                string dir = System.IO.Directory.GetCurrentDirectory() + @"\chromedriver";
                var service = ChromeDriverService.CreateDefaultService(@".\chromedriver");
                service.HideCommandPromptWindow = true;
                service.SuppressInitialDiagnosticInformation = true;
                //new DriverManager().SetUpDriver(new ChromeConfig());

                ChromeDriver chromeDriver = new ChromeDriver(service,options);

                return chromeDriver;
            }
            catch
            {
                throw;
            }
        }


    }
}
