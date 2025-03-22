# WPFCurrencyConverterAPI

# 📌 Project Overview
WPFCurrencyConverterAPI is a Windows Presentation Foundation (WPF) application that allows users to convert currencies using an external API. The project is built with C# and .NET, providing a user-friendly interface for real-time currency exchange rate conversions.

# 🛠 Technologies Used
- Language: C#
- Framework: .NET (WPF)
- IDE: Microsoft Visual Studio
- API Integration: Exchange rate API (in this case: openexchangerates.org)

# 🚀 Getting Started
**📥 Prerequisites**
- Visual Studio 2022+ installed
- .NET SDK installed
- API key from a currency exchange rate provider (if applicable)

**🔧 Setup & Installation**
- Clone the repository:
    git clone <repository-url>

- Open the solution WPFCurrencyConverterAPI.sln in Visual Studio.
- Restore NuGet packages (if required):
    dotnet restore

- Build the project:
    Debug Mode: Ctrl + Shift + B
    Release Mode: Change the build configuration to "Release" and build.

**▶️ Running the Application**
- Ensure API configuration settings (if applicable).
- Run the application using F5 (Debug) or Ctrl + F5 (Without Debugging).

**📂 Project Structure**
- WPFCurrencyConverterAPI.sln – Solution file containing project configuration.
- WPFCurrencyConverterAPI.csproj – Project file with dependencies and build settings.
- MainWindow.xaml – WPF UI design for the main currency converter window.
- MainWindow.xaml.cs – Backend logic for handling user interactions.
- Services/ – API service calls to fetch currency exchange rates.
- Models/ – Data models representing currency information.
- App.xaml & App.xaml.cs – Application lifecycle and resource management.
- README.md – Project documentation.

# ✨ Features
✅ Fetch real-time exchange rates from an API
✅ Convert between multiple currencies
✅ User-friendly WPF interface with responsive UI
✅ Error handling for API failures and invalid inputs
