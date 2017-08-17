using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using WebArticleURLToText.Properties;
using System.Text.RegularExpressions;

namespace WebArticleURLToText
{
    public class NewsPage
    {
        //Dictionary comtainning information partating to the way we read a HTML site/article for a specific newssite 
        private Dictionary<string, Tuple<string, string>> websites = new Dictionary<string, Tuple<string, string>>();
        //HTMLDocument: Provides top-level programmatic access to a HTML document hosted by the WebBrowser control.
        private HtmlDocument doc;
        private string domain;           
        public string Headline { get; private set; }
        public List<string> BodyText = new List<string>();

        public NewsPage(string webaddress)   
        {
            InitializeWebsite();
            doc = GetWebsite(webaddress);    
            GetArticleHead();
            GetArticleBody();
        }

        //Method that downloads the HTMLcode from website.
        private HtmlDocument GetWebsite(string webaddress)  
        {
            HtmlDocument doc1 = new HtmlDocument();
            //Intanciates a WebClient and specifies the encoding type to UTF8 to prevent weird characters
            WebClient client = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            //Fetches Html document of the webite
            string websiteString = client.DownloadString(webaddress);          
            //Loads the websiteString to a HtmlDocument type              
            doc1.LoadHtml(websiteString);
            //Gets the host name of a website eks. "http:/www.123.com/1341341 --> www.123.com
            domain = new Uri(webaddress).Host;

            return doc1;
            
        }

        //Methode that gets article nods - (A node is any piece of individual content)
        private HtmlNode GetArticleNode()    
        {
            //Gets the Xpath from the dictionary
            //A turple contains a set of values in this case 2
            Tuple<string, string> vals = websites[domain];
            //GetElementById: Retrieves a single HtmlElement using the element's ID attribute as a search key.
            //SelectNodes: Return a list of nodes matching the Xpath expression, but we only want the nodes at the end of the path -> Last();
            return doc.GetElementbyId(vals.Item1).SelectNodes(vals.Item2).Last(); 
            
        }

        //Methode: Gets the article title.
        private void GetArticleHead()   
        {
            //We have one node which is converted to a list of childnodes wherein
            //we search nodes classified with h1. h1: Headline 1, the biggest headline in Htmlcode  
            foreach (HtmlNode node in GetArticleNode().SelectNodes("//h1"))
            {
                //Gets the InnerText inside Html-tags <h1>Innertext</h1>
                Headline = node.InnerText + "\n";
            }
        }

        //Methode: Gets the article content.
        private void GetArticleBody()   
        {
            //We have one node which is converted to a list of childnodes wherein
            //we search nodes classified with p. p: paragraph, for regular text in Htmlcode  
            foreach (HtmlNode node in GetArticleNode().SelectNodes("//p"))
            {
                //If the node is a p class node, the node is ignored
                if (node.ChildAttributes("class").Count() != 0)
                {
                    continue;
                }
                //Gets the InnerText inside Html-tags <p>Innertext</p> and adds it to a list
                BodyText.Add(node.InnerText);
            }
        }

        //Initiaizes preinserted newssites 
        private void InitializeWebsite()
        {
            string hostname;
            string xpathID;
            string xpathPath;

            //Splitter filen op i linjer og fjerner tomme strenge
            List<string> ListOfWebsites = Resources.Websites.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Fjerner 1. linje med info om form
            ListOfWebsites.RemoveAt(0);

            foreach (string lines in ListOfWebsites)
            {
                string[] tempWebsites = lines.Split(';');
                hostname = tempWebsites[0];
                string[] tempXpath = tempWebsites[1].Split(new string[] { "\"]"}, StringSplitOptions.None);
                if (tempXpath[0].Contains('@'))
                {
                    xpathID = tempXpath[0].TrimStart('/','/','*','[','@','i','d','=','\\','\"');
                    if (tempXpath[1] == "")
                    {
                        xpathPath = "";
                    }
                    else
                    {
                        xpathPath = "/" + tempXpath[1];
                    }
                }
                else
                {
                    xpathID = "";
                    xpathPath = "/" + tempXpath[0];
                }
                //dictionary(key: webpage hostname, value: turple(xpath))
                //xpath: contains the id / pointer for a newsspecific overall < div class> and a path to where the body text is located
                websites.Add(hostname, Tuple.Create(xpathID, xpathPath));
            }
        }
    }
}
