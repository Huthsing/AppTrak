using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using AppTrak.Models;

namespace AppTrak.Helpers
{
    public class FileHelper
    {
        public static void CreateFolders()
        {
            if (!Directory.Exists(AssemblyDirectory + @"\Cache"))
            {
                Directory.CreateDirectory(AssemblyDirectory + @"\Cache");
            }
        }

        public static void DeleteBackUp(Opportunity opportunity)
        {
            var folderLocation = AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}\{opportunity.Position}";
            if (!Directory.Exists(folderLocation))
                return;
            if (Directory.EnumerateDirectories(AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}").Count() <= 1)
                Directory.Delete(AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}");
            else
                Directory.Delete(folderLocation);
        }

        
        public static void CreateBackUp(Opportunity opportunity, string resume, string cover)
        {
            Thread backupThread = new Thread(() =>
            {
                var folderLocation = AssemblyDirectory + $@"\Cache\{opportunity.CompanyName}\{opportunity.Position}";
                //Create the folder if it does not exist
                if (!Directory.Exists(folderLocation))
                    Directory.CreateDirectory(folderLocation);
                //Create the Image of the Webpage if it does not already exist
                if (!File.Exists(folderLocation + @"\website.jpg"))
                {
                    WebsiteToImage websiteToImage = new WebsiteToImage(opportunity.WebLink, folderLocation + @"\website.jpg");
                    websiteToImage.Generate();
                }
                //Create the Backup of the Webpage if it does not already exist
                if (!File.Exists(folderLocation + @"\web.html"))
                {
                    //using (WebClient wb = new WebClient())
                    //{
                    //    string source = wb.DownloadString(opportunity.WebLink);
                    //    //Write the string to a file.
                    //    File.WriteAllText(folderLocation + @"\web.html", source);
                    //}
                    var uri = new Uri(opportunity.WebLink);
                    var request = (HttpWebRequest)WebRequest.Create(uri);
                    var response = (HttpWebResponse)request.GetResponse();
                    try
                    {
                        // Hope GetEncoding() knows how to parse the CharacterSet
                        Encoding encoding = Encoding.GetEncoding(response.CharacterSet);
                        StreamReader reader = new StreamReader(response.GetResponseStream(), encoding);
                        using (
                            StreamWriter sw =
                                new StreamWriter(folderLocation + @"\web.html", false, encoding)
                            )
                        {
                            sw.Write(reader.ReadToEnd());
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    finally
                    {
                        response.Close();
                    }
                }

                if (!string.IsNullOrEmpty(resume) &&
                    !File.Exists(folderLocation + $@"\Resume_{Path.GetFileName(resume)}"))
                    File.Copy(resume, folderLocation + $@"\Resume_{Path.GetFileName(resume)}",
                        true);

                if (!string.IsNullOrEmpty(cover) && !File.Exists(folderLocation + $@"\Cover_{Path.GetFileName(cover)}"))
                    File.Copy(cover, folderLocation + $@"\Cover_{Path.GetFileName(cover)}",
                        true);
            });
            backupThread.Start();
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static T DeserializeFromXmlFile<T>(string fileName) where T : class
        {
            try
            {
                using (TextReader reader = new StreamReader(fileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    return ser.Deserialize(reader) as T;
                }
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }

        public static void Load()
        {
            Program.Opportunities = new OpportunityList();
            var configFiles = Directory.GetFiles(AssemblyDirectory + @"\Cache");
            foreach (var file in configFiles.Where(x => x.Contains(".xml")))
            {
                try
                {
                    var setting = DeserializeFromXmlFile<OpportunityList>(file);
                    Program.Opportunities = setting;
                }
                catch (Exception ex)
                {
                    // Console.WriteLine($"Unable to load settings from: {file}");
                }
            }
        }
    }
}