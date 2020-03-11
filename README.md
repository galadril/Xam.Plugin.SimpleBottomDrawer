[![Nuget](https://img.shields.io/nuget/v/Xam.Plugin.SimpleBottomDrawer)](https://www.nuget.org/packages/Xam.Plugin.SimpleBottomDrawer) ![Nuget](https://img.shields.io/nuget/dt/Xam.Plugin.SimpleBottomDrawer)

![Icon](https://raw.githubusercontent.com/galadril/Xam.Plugin.SimpleBottomDrawer/master/Samples/Xam.Plugin.SimpleBottomDrawer.Samples/Xam.Plugin.SimpleBottomDrawer.Samples.Android/Resources/mipmap-xxhdpi/ic_launcher.png)

# Xam.Plugin.SimpleBottomDrawer
Just a nice and simple BottomDrawer for your Xamarin Forms project, like how it is implemented on Google Maps.


# Setup
* Available on Nuget:
https://www.nuget.org/packages/Xam.Plugin.SimpleBottomDrawer

!!Install into your .net standard Forms project. !!


# Example
This control | Google Maps
--- | --- 
![simplebottomdrawer](https://user-images.githubusercontent.com/14561640/71714517-81c7db80-2e0e-11ea-81aa-5c773ccac633.gif) | ![ezgif-6-4d6ddeae8d68](https://user-images.githubusercontent.com/14561640/71723319-7f747a00-2e2c-11ea-9091-bb4e87935215.gif)
 
 
 The content of the Bottom Drawer is completely via xaml to your preferences!!


# Usage
You can now use the BottomDrawer to create a panel like this:

```

    <RelativeLayout>
    <controls:BottomDrawer
                Padding="0"
                BackgroundColor="White"
                ExpandedPercentage="{Binding ExpandedPercentage}"
                IsExpanded="{Binding IsExpanded}"
                IsVisible="{Binding IsVisible}"
                RelativeLayout.HeightConstraint="{ConstraintExpression Type=RelativeToParent,
                                                                       Property=Height,
                                                                       Factor=1,
                                                                       Constant=0}"
                RelativeLayout.WidthConstraint="{ConstraintExpression Type=RelativeToParent,
                                                                      Property=Width,
                                                                      Factor=1,
                                                                      Constant=0}"
                RelativeLayout.YConstraint="{ConstraintExpression Type=RelativeToParent,
                                                                  Property=Height,
                                                                  Factor=1,
                                                                  Constant=-65}">
																  
					 <StackLayout Spacing="6">
                    <BoxView
                        Margin="20,16,20,5"
                        BackgroundColor="#D1D6DB"
                        CornerRadius="2"
                        HeightRequest="5"
                        HorizontalOptions="Center"
                        WidthRequest="80" />

                    <Label
                        Padding="20,0,20,0"
                        FontAttributes="Bold"
                        FontSize="18"
                        Text="This is an example" />

                    <ScrollView>
                        <StackLayout Spacing="0">
                            <Label
                                Padding="20"
                                FontSize="Subtitle"
                                HorizontalOptions="Start"
                                Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at ex justo. Maecenas in convallis eros. Nunc semper vitae ex ut condimentum. Vivamus euismod magna ac enim interdum, ac lacinia nisi luctus. Integer consectetur metus nibh, tempor gravida enim placerat eget. Proin orci ex, fringilla sit amet eros bibendum, tincidunt feugiat mi. Proin sollicitudin imperdiet augue, quis porttitor turpis aliquet ut. Pentum dignissim. " />
                            <Label
                                Padding="20"
                                FontSize="Subtitle"
                                HorizontalOptions="Start"
                                Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at ex justo. Maecenas in convallis eros. Nunc semper vitae ex ut condimentum. Vivamus euismod magna ac enim interdum, ac lacinia nisi luctus. Integer consectetur metus nibh, tempor gravida enim placerat eget. Proin orci ex, fringilla sit amet eros bibendum, tincidunt feugiat mi. Proin sollicitudin imperdiet augue, quis porttitor turpis aliquet ut. Pellentesque lacinia, nisi nec dignissim eleifend, leo elit commodo nulla, et volutpat enim arcu at eros. Sed et saavida fermentum tellus.  Fusce in lacus id tellus condimentum dignissim. " />
                        </StackLayout>
                    </ScrollView>
                </StackLayout>
					
	</controls:BottomDrawer>

    </RelativeLayout>
```


# Properties
You can set/use the next properties

```
                ExpendedPercentage="{Binding ExpendedPercentage}"
                IsExpanded="{Binding IsExpanded}"
                LockStates="{Binding LockStates}"

```


(see sample project)


More detailed documentation:
[Documentation](https://github.com/galadril/Xam.Plugin.SimpleBottomDrawer/blob/master/Xam.Plugin.SimpleBottomDrawer/doc.md)


