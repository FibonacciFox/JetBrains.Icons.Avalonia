[wpf-nuget]: https://www.nuget.org/packages/Material.Icons.WPF/
[avalonia-nuget]: https://www.nuget.org/packages/JetBrains.Icons.Avalonia/

# JetBrains.Icons.Avalonia

![image](https://github.com/FibonacciFox/JetBrains.Icons.Avalonia/blob/master/images/Int%20UI%20Icons%20(Community).png)

A publicly available [JetBrains Icons](https://www.figma.com/design/dDuoqLa6sW4MISvLc4VXQv/Int-UI-Icons-(Community)?node-id=5590-50545&t=WoQ9WTc04dKJvcnu-1) set compiled for the Avalonia UI library.

The library is taken as a basis [Material.Icons](https://github.com/SKProCH/Material.Icons/blob/master/README.md)

- Icon types are **strongly typed** enum, so your **IDE will suggest available variants**:  

- [FAQ](#faq) - frequently asked questions



## Avalonia
#### Getting started
1. Install [Material.Icons.Avalonia nuget package](https://www.nuget.org/packages/JetBrains.Icons.Avalonia/):
    ```shell
    dotnet add package JetBrains.Icons.Avalonia
    ```
   [![avalonia-nuget](https://img.shields.io/nuget/v/JetBrains.Icons.Avalonia?label=JetBrains.Icons.Avalonia&style=flat-square)][avalonia-nuget]
   [![avalonia-nuget](https://img.shields.io/nuget/dt/JetBrains.Icons.Avalonia?color=blue&label=Downloads&style=flat-square)][avalonia-nuget]
2. Include styles in `App.xaml` (for `2.0.0` version and higher):
    ```xaml
    <Application xmlns:jetBrainsIcons="clr-namespace:JetBrains.Icons.Avalonia;assembly=JetBrains.Icons.Avalonia" 
                 ...>
      <Application.Styles>
        ...
        <jetBrainsIcons:MaterialIconStyles />
      </Application.Styles>
    </Application>
    ```
#### Using
Add `JetBrains.Icons.Avalonia` namespace to the root element of your file (your IDE can suggest it or do it automatically):
```
xmlns:jetBrainsIcons="clr-namespace:JetBrains.Icons.Avalonia;assembly=JetBrains.Icons.Avalonia"
```
Use `JetBrainsIcon` control:
```xaml
<jetBrainsIcons:JetBrainsIcon Kind="HomeDark_Writerside" />
```

Also, there is `MaterialIconExt` which allows you to use is as the markup extension:
```xaml
<Button Content="{jetBrainsIcons:JetBrainsIconExt Kind=HomeDark_Writerside}" />
```

## Avalonia FuncUI (F#)
#### Getting started
1. Install [JetBrains.Icons.Avalonia nuget package](https://www.nuget.org/packages/JetBrains.Icons.Avalonia/):
    ```shell
    dotnet add package JetBrains.Icons.Avalonia
    ```
   [![avalonia-nuget](https://img.shields.io/nuget/v/JetBrains.Icons.Avalonia?label=JetBrains.Icons.Avalonia&style=flat-square)][avalonia-nuget]
   [![avalonia-nuget](https://img.shields.io/nuget/dt/JetBrains.Icons.Avalonia?color=blue&label=Downloads&style=flat-square)][avalonia-nuget]
2. Import styles in Application (or if you use XAML check instructions for plain Avalonia)
    ```fsharp
    type App() =
        inherit Application()
    
        override this.Initialize() =
            ..
            this.Styles.Add(JetBrainsIconStyles(null))
            ..
    ```
3. Create bindings for `MaterialIcon`
    ```fsharp
    namespace Avalonia.FuncUI.DSL
    
    [<AutoOpen>]
    module JetBrainsIcon =
        open JetBrains.Icons.Avalonia
        open Avalonia.FuncUI.Types
        open Avalonia.FuncUI.Builder
    
        let create (attrs: IAttr<JetBrainsIcon> list): IView<JetBrainsIcon> =
            ViewBuilder.Create<JetBrainsIcon>(attrs)
    
        type JetBrainsIcon with
    
            static member kind<'t when 't :> JetBrainsIcon>(value: JetBrainsIconKind) : IAttr<'t> =
                AttrBuilder<'t>.CreateProperty<MaterialIconKind>(JetBrainsIcon.KindProperty, value, ValueNone)
    ```
4. Use
    ```fsharp
    Button.create [
         Button.content (
             JetBrainsIcon.create [
                 JetBrainsIcon.kind JetBrainsIconKind.Export
            ]
        )
    ]
    ```
   
## FAQ
#### How to change size?
- If you are using `JetBrainsIcon` control - use `Width` or/and `Height` properties.
- If you are using `JetBrainsIconExt` - use `Size` property.

#### Icon naming

![image](https://github.com/FibonacciFox/JetBrains.Icons.Avalonia/blob/master/images/Actions.png)

- There are two versions of icons: for light and dark theme of the application. For example:
  - ProjectDirectory_Actions\ProjectDirectoryDark_Actions:
    - ProjectDirectory(icon name)
    - Dark(used for dark theme of the application)
    - _Actions(section where the icon is located)

