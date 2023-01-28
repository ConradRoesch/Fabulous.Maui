namespace Fabulous.Maui.Compatibility

open System.Runtime.CompilerServices
open Fabulous
open Microsoft.Maui
open Microsoft.Maui.Controls

type IFabCompatHorizontalStackLayout =
    inherit IFabCompatStackBase

module HorizontalStackLayout =
    let WidgetKey = CompatWidgets.register<HorizontalStackLayout>()

[<AutoOpen>]
module HorizontalStackLayoutBuilders =
    type Fabulous.Maui.View with

        static member inline HStack<'msg>(?spacing: float) =
            match spacing with
            | None -> CollectionBuilder<'msg, IFabCompatHorizontalStackLayout, IView>(HorizontalStackLayout.WidgetKey, LayoutOfView.Children)
            | Some v ->
                CollectionBuilder<'msg, IFabCompatHorizontalStackLayout, IView>(
                    HorizontalStackLayout.WidgetKey,
                    LayoutOfView.Children,
                    StackBase.Spacing.WithValue(v)
                )

[<Extension>]
type HorizontalStackLayoutModifiers =
    /// <summary>Link a ViewRef to access the direct HorizontalStackLayout control instance</summary>
    [<Extension>]
    static member inline reference(this: WidgetBuilder<'msg, IFabCompatHorizontalStackLayout>, value: ViewRef<HorizontalStackLayout>) =
        this.AddScalar(ViewRefAttributes.ViewRef.WithValue(value.Unbox))