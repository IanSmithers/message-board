[![standard-readme compliant](https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square)](https://github.com/RichardLitt/standard-readme)

# Message Board

## Table of Contents

- [Background](#background)
- [Usage](#usage)
- [Maintainers](#maintainers)
- [Contributing](#contributing)
- [License](#license)

## Background

This is a work-in-progress submission for the Message Board coding test. I did not finish the project but attempted to build it using the Commander design pattern.

What went well? The commander design pattern.
What went poorly? I wasted a lot of time on input parsing.

The project was built with VSCode and no external packages.

- C#
- .NET 8.0

It does use some Extensions:
- .NET Install Tool
- C#
- C# Dev Kit

Additionally for development runtime execution it uses `dotnet build` and `dotnet run --project Main`.

## Usage

To run the CLI:

```sh
$ dotnet run --project Main
```

### Issuing Commands

The CLI will accept input however as it is incomplete it does not function yet.

To exit press `CTRL C`.

### Build

Simply run:

```sh
dotnet build
```

## Maintainers

[@IanSmithers](https://github.com/IanSmithers).

## Contributing

Feel free to dive in! [Open an issue](https://github.com/IanSmithers/message-board/issues)

## License

[MIT] © Ian Smithers
