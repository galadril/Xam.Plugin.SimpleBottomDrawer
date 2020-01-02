
# Xam.Plugin.SimpleBottomDrawer
Just a nice and simple BottomDrawer for your Xamarin Forms project 


# Setup
* Available on Nuget:
https://www.nuget.org/packages/Xam.Plugin.SimpleBottomDrawer

!!Install into your .net standaard project. !!


# Example
TODO: Add screenshots/gif


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
                                Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at ex justo. Maecenas in convallis eros. Nunc semper vitae ex ut condimentum. Vivamus euismod magna ac enim interdum, ac lacinia nisi luctus. Integer consectetur metus nibh, tempor gravida enim placerat eget. Proin orci ex, fringilla sit amet eros bibendum, tincidunt feugiat mi. Proin sollicitudin imperdiet augue, quis porttitor turpis aliquet ut. Pellentesque lacinia, nisi nec dignissim eleifend, leo elit commodo nulla, et volutpat enim arcu at eros. Sed et sagittis sem.  Integer lacinia maximus arcu, eu pharetra purus tincidunt vitae. Nam laoreet varius vestibulum. Duis id risus id purus suscipit pharetra id eget nibh. In pretium mollis lacus, nec maximus tortor porttitor eget. Fusce ac sodales ligula, eget ultricies dolor. In vitae interdum nibh. Ut non sodales diam, eu rhoncus nunc. Sed mattis eros vitae rutrum tristique.  Integer urna odio, iaculis quis turpis porta, congue mattis metus. Vestibulum orci libero, placerat a laoreet non, auctor et mauris. Fusce ex dolor, iaculis in velit vel, rhoncus semper ligula. Aliquam posuere condimentum tincidunt. Aenean vel luctus mi, vel luctus libero. Cras gravida sed nisi in fermentum. Maecenas ex odio, vulputate non ligula ut, aliquam eleifend felis. Duis in erat enim. Sed dapibus lorem et vehicula bibendum. Duis interdum non erat sit amet tempus. Etiam purus turpis, blandit ut ante sed, pellentesque rutrum arcu. Nullam vel quam eu libero finibus efficitur. Pellentesque nisi lacus, fringilla a leo at, gravida fermentum tellus.  Fusce in lacus id tellus condimentum dignissim. " />
                            <Label
                                Padding="20"
                                FontSize="Subtitle"
                                HorizontalOptions="Start"
                                Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at ex justo. Maecenas in convallis eros. Nunc semper vitae ex ut condimentum. Vivamus euismod magna ac enim interdum, ac lacinia nisi luctus. Integer consectetur metus nibh, tempor gravida enim placerat eget. Proin orci ex, fringilla sit amet eros bibendum, tincidunt feugiat mi. Proin sollicitudin imperdiet augue, quis porttitor turpis aliquet ut. Pellentesque lacinia, nisi nec dignissim eleifend, leo elit commodo nulla, et volutpat enim arcu at eros. Sed et sagittis sem.  Integer lacinia maximus arcu, eu pharetra purus tincidunt vitae. Nam laoreet varius vestibulum. Duis id risus id purus suscipit pharetra id eget nibh. In pretium mollis lacus, nec maximus tortor porttitor eget. Fusce ac sodales ligula, eget ultricies dolor. In vitae interdum nibh. Ut non sodales diam, eu rhoncus nunc. Sed mattis eros vitae rutrum tristique.  Integer urna odio, iaculis quis turpis porta, congue mattis metus. Vestibulum orci libero, placerat a laoreet non, auctor et mauris. Fusce ex dolor, iaculis in velit vel, rhoncus semper ligula. Aliquam posuere condimentum tincidunt. Aenean vel luctus mi, vel luctus libero. Cras gravida sed nisi in fermentum. Maecenas ex odio, vulputate non ligula ut, aliquam eleifend felis. Duis in erat enim. Sed dapibus lorem et vehicula bibendum. Duis interdum non erat sit amet tempus. Etiam purus turpis, blandit ut ante sed, pellentesque rutrum arcu. Nullam vel quam eu libero finibus efficitur. Pellentesque nisi lacus, fringilla a leo at, gravida fermentum tellus.  Fusce in lacus id tellus condimentum dignissim. " />
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





