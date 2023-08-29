# CALCULATOR_APP_CODESOFT_INTERNSHIP
Windows Calculator :  A simple yet powerful calculator that ships with Windows

Calculator
The Windows Calculator app is a modern Windows app written in C++ and C# that ships pre-installed with Windows. The app provides standard, scientific, and programmer calculator functionality, as well as a set of converters between various units of measurement and currencies.

Calculator ships regularly with new features and bug fixes. You can get the latest version of Calculator in the Microsoft Store.

Build Status

![image](https://github.com/ErrorByNight2004/CALCULATOR_APP_CODESOFT_INTERNSHIP/assets/143543812/51375f6c-5768-4ed3-bb49-6e8d82ff84e7)


Features
Standard Calculator functionality which offers basic operations and evaluates commands immediately as they are entered.
Scientific Calculator functionality which offers expanded operations and evaluates commands using order of operations.
Programmer Calculator functionality which offers common mathematical operations for developers including conversion between common bases.
Date Calculation functionality which offers the difference between two dates, as well as the ability to add/subtract years, months and/or days to/from a given input date.
Calculation history and memory capabilities.
Conversion between many units of measurement.
Currency conversion based on data retrieved from Bing.
Infinite precision for basic arithmetic operations (addition, subtraction, multiplication, division) so that calculations never lose precision.
Getting started
Prerequisites:

Your computer must be running Windows 11, build 22000 or newer.

Install the latest version of Visual Studio (the free community edition is sufficient).

Install the "Universal Windows Platform Development" workload.
Install the optional "C++ Universal Windows Platform tools" component.
Install the latest Windows 11 SDK.
Visual Studio Installation Screenshot

Install the XAML Styler Visual Studio extension.
![image](https://github.com/ErrorByNight2004/CALCULATOR_APP_CODESOFT_INTERNSHIP/assets/143543812/b4148c61-1673-465e-8da4-292b151b5cb6)


Get the code:

git clone https://github.com/ErrorByNight2004/calculator.git
Open src\Calculator.sln in Visual Studio to build and run the Calculator app.

For a general description of the Calculator project architecture see ApplicationArchitecture.md.

To run the UI Tests, you need to make sure that Windows Application Driver (WinAppDriver) is installed.

Contributing
Want to contribute? The team encourages community feedback and contributions. Please follow our contributing guidelines.

If Calculator is not working properly, please file a report in the Feedback Hub. We also welcome issues submitted on GitHub.

Roadmap
For information regarding Windows Calculator plans and release schedule, please see the Windows Calculator Roadmap.

Graphing Mode
Adding graphing calculator functionality is on the project roadmap and we hope that this project can create a great end-user experience around graphing. To that end, the UI from the official in-box Windows Calculator is currently part of this repository, although the proprietary Microsoft-built graphing engine, which also drives graphing in Microsoft Mathematics and OneNote, is not. Community members can still be involved in the creation of the UI, however developer builds will not have graphing functionality due to the use of a mock implementation of the engine built on top of a common graphing API.

Diagnostic Data
This project collects usage data and sends it to Microsoft to help improve our products and services. Read our privacy statement to learn more. Diagnostic data is disabled in development builds by default, and can be enabled with the SEND_DIAGNOSTICS build flag.

Currency Converter
Windows Calculator includes a currency converter feature that uses mock data in developer builds. The data that Microsoft uses for the currency converter feature (e.g., in the retail version of the application) is not licensed for your use. The mock data will be clearly identifiable as it references planets instead of countries, and remains static regardless of selected inputs.

Reporting Security Issues
Please refer to SECURITY.md.

License
Copyright (c) Microsoft Corporation. All rights reserved.

Licensed under the MIT License.
