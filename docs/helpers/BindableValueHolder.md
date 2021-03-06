# BindableValueHolder

The **BindableValueHolder** lets users change several objects' states at a time.

## Example

You can use it to switch several object states by declaring it as a Resource (either in a page or control):

```xml

<helpers:BindableValueHolder x:Name="HighlightBrushHolder" Value="{StaticResource BlackBrush}" />

```

and using it like that:

```xml

<TextBlock x:Name="Label" Foreground="{Binding Value, ElementName=HighlightBrushHolder}" />

<TextBox x:Name="Field" BorderBrush="{Binding Value, ElementName=HighlightBrushHolder}" />

```

and switching it like that:

```xml

<VisualStateGroup x:Name="HighlightStates">
    <VisualState x:Name="Normal" />

    <VisualState x:Name="Wrong">
        <VisualState.Setters>
            <Setter Target="HighlightBrushHolder.Value" Value="{StaticResource RedBrush}" />
        </VisualState.Setters>
    </VisualState>
</VisualStateGroup>

```
