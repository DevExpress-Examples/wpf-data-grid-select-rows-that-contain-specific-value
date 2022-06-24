using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;
using System.Linq;

namespace DXGrid_SelectRows {
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Products = ProductList.GetData();
            Selection = new ObservableCollection<Product>() { Products.ElementAt(0) };
        }
        public ObservableCollection<Product> Products { get { return this.GetValue<ObservableCollection<Product>>(); } set { SetValue(value); } }
        public ObservableCollection<Product> Selection { get { return this.GetValue<ObservableCollection<Product>>(); } set { SetValue(value); } }

        [Command]
        public void SelectRows(string textValue) {
            var value = double.Parse(textValue);
            Selection = new ObservableCollection<Product>(from item in Products where item.UnitPrice >= value select item);
        }
        public bool CanSelectRows(string textValue) {
            return double.TryParse(textValue, out _);
        }
    }
}
