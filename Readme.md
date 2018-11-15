<!-- default file list -->
*Files to look at*:

* **[CustomItemColors.xaml](./CS/Themes/CustomItemColors.xaml) (VB: [CustomItemColors.xaml](./VB/Themes/CustomItemColors.xaml))**
* [generic.xaml](./CS/Themes/generic.xaml) (VB: [generic.xaml](./VB/Themes/generic.xaml))
<!-- default file list end -->
# [Deprecated] How to support default Color Schemes in a custom control


<p>Starting with <strong>v17.1</strong>, we provide a more powerful and flexible way of linking custom colors to colors from predefined Color Schemes. Refer to the updated <a href="https://www.devexpress.com/Support/Center/p/T510179">How to introduce Color Scheme support for a custom control</a> example for more information.<br><br>This example illustrates how to support default Color Schemes (Generic and Win8) in a custom control. In this implementation, a <strong>CustomRibbonItem </strong>control uses colors defined for the default Color Schemes and changes its appearance according to the current Color Scheme. <br><br>All the required colors for different Color Schemes should be defined within a separate ResourceDictionary file. To use these colors in styles or templates declared within a certain ResourceDictionary, include the dictionary with colors into the MergedDictionaries collection of the target ResourceDictionary by using the <strong>ColorSchemeDictionary</strong> class and its <strong>Source</strong> property. </p>

<br/>


