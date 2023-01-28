namespace Fabulous.Maui.Compatibility

open System.Runtime.CompilerServices
open Fabulous
open Microsoft.Maui
open Microsoft.Maui.Controls

type IFabCompatLayout =
    inherit IFabCompatView
    inherit ILayout

module Layout =
    let Padding =
        Attributes.defineBindableWithEquality<Thickness> Layout.PaddingProperty

    let CascadeInputTransparent =
        Attributes.defineBindableBool Layout.CascadeInputTransparentProperty

    let IsClippedToBounds =
        Attributes.defineBindableBool Layout.IsClippedToBoundsProperty

[<Extension>]
type LayoutModifiers =
    [<Extension>]
    static member inline padding(this: WidgetBuilder<'msg, #IFabCompatLayout>, value: Thickness) =
        this.AddScalar(Layout.Padding.WithValue(value))

    [<Extension>]
    static member inline padding(this: WidgetBuilder<'msg, #IFabCompatLayout>, value: float) =
        LayoutModifiers.padding(this, Thickness(value))

    [<Extension>]
    static member inline padding(this: WidgetBuilder<'msg, #IFabCompatLayout>, left: float, top: float, right: float, bottom: float) =
        LayoutModifiers.padding(this, Thickness(left, top, right, bottom))

    [<Extension>]
    static member inline cascadeInputTransparent(this: WidgetBuilder<'msg, #IFabCompatLayout>, value: bool) =
        this.AddScalar(Layout.CascadeInputTransparent.WithValue(value))

    [<Extension>]
    static member inline isClippedToBounds(this: WidgetBuilder<'msg, #IFabCompatLayout>, value: bool) =
        this.AddScalar(Layout.IsClippedToBounds.WithValue(value))