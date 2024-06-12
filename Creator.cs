using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    internal class Creator : CatalogFill
    {
        private readonly IView _view;
        private readonly string catalogPath = @"C:"; // C:\Users\amelc\source\repos\Catalog\Catalog.txt адрес файла для примера

        public Creator(IView view, CatalogFill Catalog)
        {
            _view = view;
            _view.UpdateContent += new EventHandler<EventArgs>(StartFilling);

        }

        public void StartFilling(object sender, EventArgs e){
            CatalogFilling(catalogPath);
            List<string> price = GetPriceList();
            List<string> content = GetContentList();
            foreach (string priceItem in price) {
                _view.AddPriceList(priceItem);
            
            }
            foreach (string contentItem in content) {
            _view.AddContentList(contentItem);
            }

        }
        
    }
}
