# assign-unique-color-to-each-user-name-and-message-in-a-group-chat-in-Xamarin.Forms.Chat
Describes how to assign a separate color to each user in a group chat to display that user's name and that user's message in one unique color.

## Sample

```xaml

        <ContentPage.Resources>
        <ResourceDictionary>
            <local:AuthorColorConverter x:Name="authorColorConverter" x:Key="authorColorConverter" />

            <!--Defining outgoing message author color-->
            <Style TargetType="sfChat:OutgoingMessageAuthorView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <Label Text="{Binding Author.Name}" BackgroundColor="Transparent" TextColor="{TemplateBinding BindingContext, Converter= {StaticResource authorColorConverter},ConverterParameter={x:Reference viewModel}}" BindingContext="{TemplateBinding BindingContext}"/>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>

            <!--Defining incoming message author color-->
            <Style TargetType="sfChat:IncomingMessageAuthorView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <Label Text="{Binding Author.Name}" BackgroundColor="Transparent" TextColor="{TemplateBinding BindingContext, Converter= {StaticResource authorColorConverter},ConverterParameter={x:Reference viewModel}}" BindingContext="{TemplateBinding BindingContext}"/>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
        </ResourceDictionary>
    </ContentPage.Resources>

Converter:

    public class AuthorColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var viewModel = parameter as ViewModel;
            var message = value as IMessage;

            if (viewModel.AuthorColors.ContainsKey(message.Author))
            {
                Color color;
                viewModel.AuthorColors.TryGetValue(message.Author, out color);
                return color;
            }
            else
            {
                return viewModel.AddColorForAuthor(message.Author);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.White;
        }
    }

```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements)

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
