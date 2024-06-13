using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Catalog
{
    internal class Creator : CatalogFill
    {
        private readonly IView _view;
        private readonly string catalogPath = @"C:\Users\79089\source\repos\Tests\Tests\Catalog.txt"; // C:\Users\amelc\source\repos\Catalog\Catalog.txt адрес файла для примера

        public Creator(IView view, CatalogFill Catalog)
        {
            _view = view;
            _view.UpdateContent += new EventHandler<EventArgs>(StartFilling);

        }

        public void StartFilling(object sender, EventArgs e)
        {
            CatalogFilling(catalogPath);
            List<string> price = GetPriceList();
            List<string> content = GetContentList();
            for (int item = 0; item < content.Count; ++item)
            {
                string itemWithPrice = $"{content[item]} . {price[item]}";
                _view.AddContentList(itemWithPrice);
            }

        }

    }
}
