#  Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j) | public | Class | Bottom drawer control with a border | 

Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="n-xam.plugin.simplebottomdrawer__1g187w7" />  Xam.Plugin.SimpleBottomDrawer Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j) | public | Bottom drawer control with a border | 

 


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j" />  BottomDrawer Class ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Sources: BottomDrawer.cs</small>


Bottom drawer control with a border



```csharp
[Preserve(AllMembers = true)]
public class BottomDrawer : Frame
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; Xamarin.Forms.BindableObject -&gt; Xamarin.Forms.Element -&gt; Xamarin.Forms.NavigableElement -&gt; Xamarin.Forms.VisualElement -&gt; Xamarin.Forms.View -&gt; Xamarin.Forms.Layout -&gt; Xamarin.Forms.TemplatedView -&gt; Xamarin.Forms.ContentView -&gt; Xamarin.Forms.Frame           
Attributes: Xamarin.Forms.Internals.PreserveAttribute           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged" target="_blank" >System.ComponentModel.INotifyPropertyChanged</a>, Xamarin.Forms.Internals.IDynamicResourceHandler, Xamarin.Forms.IElement, Xamarin.Forms.Internals.INameScope, Xamarin.Forms.Internals.INavigationProxy, Xamarin.Forms.IAnimatable, Xamarin.Forms.IResourcesProvider, Xamarin.Forms.IStyleElement, Xamarin.Forms.IFlowDirectionController, Xamarin.Forms.IPropertyPropagationController, Xamarin.Forms.IVisualController, Xamarin.Forms.ITabStopElement, Xamarin.Forms.StyleSheets.IStyleSelectable, Xamarin.Forms.StyleSheets.IStylable, Xamarin.Forms.IViewController, Xamarin.Forms.IVisualElementController, Xamarin.Forms.IElementController, Xamarin.Forms.Internals.IGestureController, Xamarin.Forms.ILayout, Xamarin.Forms.ILayoutController, Xamarin.Forms.IControlTemplated, Xamarin.Forms.IElementConfiguration&lt;Xamarin.Forms.Frame&gt;, Xamarin.Forms.IPaddingElement, Xamarin.Forms.IBorderElement


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [_height](#f-xam.plugin.simplebottomdrawer.bottomdrawer._height__v1qmb3) | private | Get height | 
 | [_width](#f-xam.plugin.simplebottomdrawer.bottomdrawer._width__1mveijo) | private | Get width | 
 | [ExpandedPercentageProperty](#f-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentageproperty__30wiej) | public static | Bindable property for the [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) property | 
 | [isDragging](#f-xam.plugin.simplebottomdrawer.bottomdrawer.isdragging__1lu1r7e) | private | Is the drawer being dragged | 
 | [IsExpandedProperty](#f-xam.plugin.simplebottomdrawer.bottomdrawer.isexpandedproperty__dxhmbp) | public static | Bindable property for the [IsExpanded](#p-xam.plugin.simplebottomdrawer.bottomdrawer.isexpanded__l5rsyo) property | 
 | [LockStatesProperty](#f-xam.plugin.simplebottomdrawer.bottomdrawer.lockstatesproperty__1gk9ber) | public static | Bindable property for the [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) property | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) | public | Gets or sets the is expanded percentage | 
 | [IsExpanded](#p-xam.plugin.simplebottomdrawer.bottomdrawer.isexpanded__l5rsyo) | public | Gets or sets the is expanded value | 
 | [LockStates](#p-xam.plugin.simplebottomdrawer.bottomdrawer.lockstates__1tc4p7w) | public | Gets or sets the lock statues | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BottomDrawer()](#m-xam.plugin.simplebottomdrawer.bottomdrawer.-ctor__13oeqsd) | public | Constructor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DetectSwipeUp(PanUpdatedEventArgs)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.detectswipeup_xamarin.forms.panupdatedeventargs___at4ktv) | private | Check if the action is a swipe up | 
 | [Dismiss()](#m-xam.plugin.simplebottomdrawer.bottomdrawer.dismiss__yfd2we) | public | Dismiss the bottom drawer | 
 | [ExpandedPercentageChanged(BindableObject, object, object)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentagechanged_xamarin.forms.bindableobject-system.object-system.object___67zqmz) | private static | Handle the change of the [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) property | 
 | [GetClosestLockState(double)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.getclosestlockstate_system.double___1nisnb2) | private | Find the closest lock state when swip is finished | 
 | [GetPropertionDistance(double)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.getpropertiondistance_system.double___1nfygs8) | private | Get the current proportion of the sheet in relation to the screen | 
 | [getProportionCoordinate(double)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.getproportioncoordinate_system.double___qck96b) | private | Get proportion coordinates | 
 | [IsExpandedPropertyChanged(BindableObject, object, object)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.isexpandedpropertychanged_xamarin.forms.bindableobject-system.object-system.object___3k1fz0) | private static | Handle the change of the [IsExpanded](#p-xam.plugin.simplebottomdrawer.bottomdrawer.isexpanded__l5rsyo) property | 
 | [OnPanChanged(object, PanUpdatedEventArgs)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.onpanchanged_system.object-xamarin.forms.panupdatedeventargs___3waqub) | private | On pan gesture changed | 
 | [OnSizeAllocated(double, double)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.onsizeallocated_system.double-system.double___b62ryi) | protected | Make sure we collapse the view on orientation change | 
 | [OnTapped(object, EventArgs)](#m-xam.plugin.simplebottomdrawer.bottomdrawer.ontapped_system.object-system.eventargs___t9erf6) | private | On tapped event | 
 | [Open()](#m-xam.plugin.simplebottomdrawer.bottomdrawer.open__meboaa) | public | Open the bottom drawer | 

 


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-xam.plugin.simplebottomdrawer.bottomdrawer._height__v1qmb3" />  BottomDrawer._height Field ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Get height



```csharp
private double _height
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-xam.plugin.simplebottomdrawer.bottomdrawer._width__1mveijo" />  BottomDrawer._width Field ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Get width



```csharp
private double _width
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentageproperty__30wiej" />  BottomDrawer.ExpandedPercentageProperty Field ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Bindable property for the [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) property



```csharp
public static readonly BindableProperty ExpandedPercentageProperty
```

<strong>Field value</strong><dl><dt>Xamarin.Forms.BindableProperty</dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-xam.plugin.simplebottomdrawer.bottomdrawer.isdragging__1lu1r7e" />  BottomDrawer.isDragging Field ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Is the drawer being dragged



```csharp
private bool isDragging
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-xam.plugin.simplebottomdrawer.bottomdrawer.isexpandedproperty__dxhmbp" />  BottomDrawer.IsExpandedProperty Field ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Bindable property for the [IsExpanded](#p-xam.plugin.simplebottomdrawer.bottomdrawer.isexpanded__l5rsyo) property



```csharp
public static readonly BindableProperty IsExpandedProperty
```

<strong>Field value</strong><dl><dt>Xamarin.Forms.BindableProperty</dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-xam.plugin.simplebottomdrawer.bottomdrawer.lockstatesproperty__1gk9ber" />  BottomDrawer.LockStatesProperty Field ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Bindable property for the [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) property



```csharp
public static readonly BindableProperty LockStatesProperty
```

<strong>Field value</strong><dl><dt>Xamarin.Forms.BindableProperty</dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg" />  BottomDrawer.ExpandedPercentage Property ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Gets or sets the is expanded percentage



```csharp
public double ExpandedPercentage { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="p-xam.plugin.simplebottomdrawer.bottomdrawer.isexpanded__l5rsyo" />  BottomDrawer.IsExpanded Property ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Gets or sets the is expanded value



```csharp
public bool IsExpanded { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="p-xam.plugin.simplebottomdrawer.bottomdrawer.lockstates__1tc4p7w" />  BottomDrawer.LockStates Property ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Gets or sets the lock statues



```csharp
public double[] LockStates { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double[]</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.-ctor__13oeqsd" />  BottomDrawer.BottomDrawer() Constructor ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Constructor



```csharp
public BottomDrawer()
```

Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.detectswipeup_xamarin.forms.panupdatedeventargs___at4ktv" />  BottomDrawer.DetectSwipeUp(PanUpdatedEventArgs) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Check if the action is a swipe up



```csharp
private bool DetectSwipeUp(PanUpdatedEventArgs e)
```

<strong>Method parameters</strong><dl><dt>Xamarin.Forms.PanUpdatedEventArgs <strong>e</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.dismiss__yfd2we" />  BottomDrawer.Dismiss() Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Dismiss the bottom drawer



```csharp
public void Dismiss()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentagechanged_xamarin.forms.bindableobject-system.object-system.object___67zqmz" />  BottomDrawer.ExpandedPercentageChanged(BindableObject, object, object) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Handle the change of the [ExpandedPercentage](#p-xam.plugin.simplebottomdrawer.bottomdrawer.expandedpercentage__xn1dpg) property



```csharp
private static void ExpandedPercentageChanged(BindableObject bindable, object o, object n)
```

<strong>Method parameters</strong><dl><dt>Xamarin.Forms.BindableObject <strong>bindable</strong></dt><dd>The bindable object</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>o</strong></dt><dd>The old value</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>n</strong></dt><dd>The new value</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.getclosestlockstate_system.double___1nisnb2" />  BottomDrawer.GetClosestLockState(double) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Find the closest lock state when swip is finished



```csharp
private double GetClosestLockState(double TranslationY)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>TranslationY</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.getpropertiondistance_system.double___1nfygs8" />  BottomDrawer.GetPropertionDistance(double) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Get the current proportion of the sheet in relation to the screen



```csharp
private double GetPropertionDistance(double TranslationY)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>TranslationY</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.getproportioncoordinate_system.double___qck96b" />  BottomDrawer.getProportionCoordinate(double) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Get proportion coordinates



```csharp
private double getProportionCoordinate(double proportion)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>proportion</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.isexpandedpropertychanged_xamarin.forms.bindableobject-system.object-system.object___3k1fz0" />  BottomDrawer.IsExpandedPropertyChanged(BindableObject, object, object) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Handle the change of the [IsExpanded](#p-xam.plugin.simplebottomdrawer.bottomdrawer.isexpanded__l5rsyo) property



```csharp
private static void IsExpandedPropertyChanged(BindableObject bindable, object o, object n)
```

<strong>Method parameters</strong><dl><dt>Xamarin.Forms.BindableObject <strong>bindable</strong></dt><dd>The bindable object</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>o</strong></dt><dd>The old value</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>n</strong></dt><dd>The new value</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.onpanchanged_system.object-xamarin.forms.panupdatedeventargs___3waqub" />  BottomDrawer.OnPanChanged(object, PanUpdatedEventArgs) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


On pan gesture changed



```csharp
private void OnPanChanged(object sender, PanUpdatedEventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd></dd><dt>Xamarin.Forms.PanUpdatedEventArgs <strong>e</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.onsizeallocated_system.double-system.double___b62ryi" />  BottomDrawer.OnSizeAllocated(double, double) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Make sure we collapse the view on orientation change



```csharp
protected override void OnSizeAllocated(double width, double height)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>width</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>height</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: Forms.Layout.OnSizeAllocated


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.ontapped_system.object-system.eventargs___t9erf6" />  BottomDrawer.OnTapped(object, EventArgs) Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


On tapped event



```csharp
private void OnTapped(object sender, EventArgs e)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventargs" target="_blank" >System.EventArgs</a> <strong>e</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-xam.plugin.simplebottomdrawer.bottomdrawer.open__meboaa" />  BottomDrawer.Open() Method ##
<small>Namespace: [Xam.Plugin.SimpleBottomDrawer](#n-xam.plugin.simplebottomdrawer__1g187w7)           
Assembly: Xam.Plugin.SimpleBottomDrawer           
Type: [BottomDrawer](#t-xam.plugin.simplebottomdrawer.bottomdrawer__25049j)           
Sources: BottomDrawer.cs</small>


Open the bottom drawer



```csharp
public void Open()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 



