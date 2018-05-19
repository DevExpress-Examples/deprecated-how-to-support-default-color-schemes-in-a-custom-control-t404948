Imports DevExpress.UI.Xaml.Ribbon
Imports DevExpress.UI.Xaml.Ribbon.Internal

Public Class CustomRibbonItem
    Inherits RibbonItemBase
    Implements IRibbonItem
    Public Sub New()
        DefaultStyleKey = GetType(CustomRibbonItem)
    End Sub
End Class
