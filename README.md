# GitHub Countdown Badge Generator

A simple C# CLI tool that generates dynamic countdown badges for your GitHub READMEs. 

## What it does

If you have a release, a hackathon, or an event coming up, you can generate a dynamic Markdown badge. The badge will automatically update every day, counting down to your event!

Here is an example of what the badge looks like:
[![Countdown](https://img.shields.io/date/1798675200?label=New%20Year&color=orange&style=for-the-badge)]()

## Features
- Simple console interface.
- Converts your date into a UNIX timestamp.
- Automatically encodes spaces in your event name for valid URLs.
- Generates ready-to-copy Markdown code.

## How to run

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1. Clone the repository:
   ```bash
   git clone https://github.com/ilyashulga13/CountdownGen.git
   ```
2. Navigate to the project folder:
   ```bash
   cd CountdownGen
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

## Usage Example

When you run the app, it will ask you for the event name and the target date.

```text
==================================================
        GITHUB COUNTDOWN BADGE GENERATOR          
==================================================

>> Event name: Hackathon 2026
>> Target date (YYYY-MM-DD): 2026-12-31

--------------------------------------------------
>> Success! Your code is ready below:

[![Countdown](https://img.shields.io/date/1798675200?label=Hackathon%202026&color=orange&style=for-the-badge)]()
```

Just copy the generated line and paste it directly into your `README.md`.

## Tech Stack
- C#
- .NET
- [Shields.io](https://shields.io/) API

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
