using DevExpress.UI.Xaml.Ribbon;
using DevExpress.UI.Xaml.Ribbon.Internal;

namespace ColosSchemesDemo1 {
    public class CustomRibbonItem : RibbonItemBase, IRibbonItem {
        public CustomRibbonItem() {
            DefaultStyleKey = typeof(CustomRibbonItem);
        }
    }
}
