using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MauiApp1;

public class MainPage : ContentPage
{
    public MainPage()
    {
        Title = "User Info";
        BackgroundColor = Color.FromArgb("#F3F4F6");

        var details = new VerticalStackLayout
        {
            Spacing = 16,
            Children =
            {
                CreateInfoRow("Name", "John Doe"),
                CreateInfoRow("Email", "john.doe@example.com"),
                CreateInfoRow("Age", "28"),
                CreateInfoRow("Telephone", "+1 555 123 4567")
            }
        };

        var cardContent = new VerticalStackLayout
        {
            Spacing = 20,
            Children =
            {
                new Label
                {
                    Text = "User Information",
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromArgb("#111827"),
                    HorizontalOptions = LayoutOptions.Center
                },
                details
            }
        };

        var card = new Border
        {
            Stroke = Color.FromArgb("#D0D5DD"),
            StrokeThickness = 1,
            BackgroundColor = Colors.White,
            Padding = 20,
            StrokeShape = new RoundRectangle { CornerRadius = 18 },
            Content = cardContent,
            HorizontalOptions = LayoutOptions.Fill
        };

        Content = new Grid
        {
            Padding = 20,
            VerticalOptions = LayoutOptions.Center,
            Children = { card }
        };
    }

    private static Grid CreateInfoRow(string title, string value)
    {
        var row = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Auto },
                new ColumnDefinition { Width = GridLength.Star }
            },
            ColumnSpacing = 12
        };

        row.Add(new Label
        {
            Text = $"{title}:",
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#374151")
        }, 0, 0);

        row.Add(new Label
        {
            Text = value,
            TextColor = Color.FromArgb("#111827")
        }, 1, 0);

        return row;
    }
}