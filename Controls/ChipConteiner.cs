using Microsoft.Maui.Layouts;

namespace Chip.Controls;

public class ChipConteiner : ContentView
{
    #region ChipList
    public static readonly BindableProperty ChipProperty =
       BindableProperty.Create(nameof(ChipList), typeof(List<IView>), typeof(List<IView>), new List<IView>(),
           defaultBindingMode: BindingMode.OneWay, propertyChanged: ChipPropertyChanged);
    private static void ChipPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        (bindable as ChipConteiner).ChipList = (List<IView>)newValue;
        (bindable as ChipConteiner).InvalidateLayout();
    }

    public List<IView> ChipList
    {
        get => (List<IView>)GetValue(ChipProperty);
        set => SetValue(ChipProperty, value);
    }
    #endregion
    public ChipConteiner()
    {
        if (ChipList.Count < 1)
            return;
        FlexLayout flex = new FlexLayout()
        {
            AlignContent = FlexAlignContent.Start,
            AlignItems = FlexAlignItems.Start,
            Direction = FlexDirection.Row,
            Wrap = FlexWrap.Wrap,
            Padding = 2,
        };
        foreach (var chip in ChipList)
            flex.Children.Add(chip);


        Content = flex;

    }
}