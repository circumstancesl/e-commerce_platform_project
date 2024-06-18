using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    class CatalogFill
    {

        protected List<string> contentList = new List<string>();
        protected List<string> priceList = new List<string>();
        protected List<List<string>> lists = new List<List<string>>();
        string content = "";
        string price = "";

        public List<List<string>> CatalogFilling(string path)
        {
            try
            {
                string filePath = path;

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        bool isCost = false;
                        while ((line = sr.ReadLine()) != null)
                        {
                            foreach (string s in line.Split())
                            {
                                if (s == ".")
                                {
                                    isCost = true;
                                }

                                if (!isCost)
                                {
                                    content += s;
                                }
                                else if (isCost)
                                {
                                    if (s == ".")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        price += s;
                                    }
                                }
                            }
                            if (price == "" || content == "")
                            {
                                break;
                            }
                            else
                            {
                                contentList.Add(content);
                                priceList.Add(price);
                                content = "";
                                price = "";

                            }
                            isCost = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Неверный путь каталога.");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }
            lists.Add(priceList);
            lists.Add(contentList);
            return lists;
        }
        public List<string> GetPriceList()
        {
            return priceList;
        }
        public List<string> GetContentList()
        {
            return contentList;
        }

    }
}
