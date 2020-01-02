[![xam-plugin-simplebottomdrawer MyGet Build Status](https://www.myget.org/BuildSource/Badge/xam-plugin-simplebottomdrawer?identifier=bf5f13ba-cf47-4f75-8a63-728714c84446)](https://www.myget.org/)

# Xam.Plugin.SimpleBottomDrawer
Just a nice and simple BottomDrawer for your Xamarin Forms project 


# Setup
* Available on Nuget:
https://www.nuget.org/packages/Xam.Plugin.SimpleBottomDrawer

!!Install into your .net standaard Forms project. !!


# Example
![simplebottomdrawer](https://user-images.githubusercontent.com/14561640/71672219-a623a980-2d75-11ea-8377-0f5e272a9f3c.gif)



# Usage
You can now use the BottomDrawer to create a panel like this:

```

  <controls:BottomDrawer
                Padding="1,4,1,0"
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
                                                                  Factor=.9,
                                                                  Constant=0}">
																  
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

```



# Properties
You can set/use the next properties

```
                ExpendedPercentage="{Binding ExpendedPercentage}"
                IsExpanded="{Binding IsExpanded}"
                IsVisible="{Binding IsVisible}"

```

(see sample project)




