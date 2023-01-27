# Fabulous for .NET MAUI

[![build](https://img.shields.io/github/actions/workflow/status/fabulous-dev/Fabulous.Maui/build.yml?branch=main)](https://github.com/fabulous-dev/Fabulous.Maui/actions/workflows/build.yml) [![NuGet version](https://img.shields.io/nuget/v/Fabulous.Maui)](https://www.nuget.org/packages/Fabulous.Maui) [![NuGet downloads](https://img.shields.io/nuget/dt/Fabulous.Maui)](https://www.nuget.org/packages/Fabulous.Maui) [![Discord](https://img.shields.io/discord/716980335593914419?label=discord&logo=discord)](https://discord.gg/bpTJMbSSYK) [![Twitter Follow](https://img.shields.io/twitter/follow/FabulousAppDev?style=social)](https://twitter.com/FabulousAppDev)

Fabulous.Maui brings the great development experience of Fabulous to .NET MAUI, allowing you to take advantage of the latest cross-platform UI framework from Microsoft with a tailored declarative UI DSL and clean architecture.

Deploy to any platform supported by .NET MAUI, such as Android, iOS, macOS, Windows, Linux and more!

```fs
/// A simple Counter app

type Model =
    { Count: int }

type Msg =
    | Increment
    | Decrement

let init () =
    { Count = 0 }

let update msg model =
    match msg with
    | Increment -> { model with Count = model.Count + 1 }
    | Decrement -> { model with Count = model.Count - 1 }

let view model =
    Application() {
        Window(
            VStack(spacing = 16.) {
                Image(Aspect.AspectFit, "fabulous.png")

                Label($"Count is {model.Count}")

                TextButton("Increment", Increment)
                TextButton("Decrement", Decrement)
            }
        )
    }
```

## Getting Started

You can start your new Fabulous.Maui app in a matter of seconds using the dotnet CLI templates.  
For a starter guide see our [Get Started with Fabulous.Maui](https://fabulous.dev/maui/get-started).

```sh
dotnet new install Fabulous.Maui.Templates
dotnet new fabulous-maui -n MyApp
```

## Documentation

The full documentation for Fabulous.Maui can be found at [docs.fabulous.dev/v2/maui](https://docs.fabulous.dev/v2/maui).

Other useful links:
- [The official Fabulous website](https://fabulous.dev)
- [Get started](https://fabulous.dev/maui/get-started)
- [API Reference](https://api.fabulous.dev/v2/maui)
- [Contributor Guide](CONTRIBUTING.md)

Additionally, we have the [Fabulous Discord server](https://discord.gg/bpTJMbSSYK) where you can ask any of your Fabulous related questions.

## Supporting Fabulous

The simplest way to show us your support is by giving this project and the [Fabulous project](https://github.com/fabulous-dev/Fabulous) a star.

You can also support us by becoming our sponsor on the GitHub Sponsors program.  
This is a fantastic way to support all the efforts going into making Fabulous the best declarative UI framework for dotnet.

If you need support see Commercial Support section below.

## Contributing

Have you found a bug or have a suggestion of how to enhance Fabulous? Open an issue and we will take a look at it as soon as possible.

Do you want to contribute with a PR? PRs are always welcome, just make sure to create it from the correct branch (main) and follow the [Contributor Guide](CONTRIBUTING.md).

For bigger changes, or if in doubt, make sure to talk about your contribution to the team. Either via an issue, GitHub discussion, or reach out to the team either using the [Discord server](https://discord.gg/bpTJMbSSYK).

## Commercial support

If you would like us to provide you with:

- training and workshops,
- support services,
- and consulting services.

Feel free to contact us: [support@fabulous.dev](mailto:support@fabulous.dev)