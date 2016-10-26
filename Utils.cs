/*

automation challenge 7 (Crawler and get text):
Extension of last project.  Use the crawler and catalog every word used and the number of instance each word occurs.  
Go to https://www.skiutah.com/

use the crawler written in the past challenges and write a method to keep track of all the words on each page on the site and return to me a list or dictionary of words that exists on the site.  Also send me the list or dictionary in a text document.  
map.put(key, map.get(key) + 1);

*/
namespace Automation_Code_Challenge_7_CSharp
{
    [TestClass]
    class Utils : SeleniumWebdriverBaseClass
    {
        [TestMethod]
        public void TestLauncher()
        {
            // Verify Page Title
            verifyPageTitle(URL, Expected_Value);
            // Visit every page of the skiutah.com domain once, compiling a list of all the words on each page.
            // Return a list of all the words found, with the number of occurences for each word
            webCrawler();
        }
    }
}
