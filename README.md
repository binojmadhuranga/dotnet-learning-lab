# HelloCSharp - Simple CLI Calculator

A command-line calculator application built with C# and .NET 10.0 that performs basic arithmetic operations.

## Overview

This is a simple console-based calculator that allows users to perform basic arithmetic operations (addition, subtraction, multiplication, and division) on two numbers through an interactive command-line interface.

## Features

- **Addition**: Add two numbers
- **Subtraction**: Subtract the second number from the first
- **Multiplication**: Multiply two numbers
- **Division**: Divide the first number by the second (with division-by-zero protection)
- **Error Handling**: Graceful handling of invalid inputs and division by zero
- **User-Friendly CLI**: Clean and intuitive command-line interface

## Project Structure

```
HelloCSharp/
├── Program.cs          # Main entry point with CLI interface
├── Calculator.cs       # Calculator class with arithmetic operations
├── HelloCSharp.csproj  # Project configuration file
└── README.md          # Project documentation
```

## Requirements

- .NET 10.0 SDK or later
- Windows, macOS, or Linux operating system

## Installation

1. Clone or download this repository to your local machine
2. Navigate to the project directory:
   ```bash
   cd HelloCSharp
   ```

## Usage

### Running the Application

Execute the following command in the project directory:

```bash
dotnet run
```

### Using the Calculator

1. When prompted, enter the first number
2. Enter the second number
3. Choose an operation by entering the corresponding number:
   - `1` for Addition
   - `2` for Subtraction
   - `3` for Multiplication
   - `4` for Division
4. The result will be displayed on the screen

### Example Session

```
=== Simple CLI Calculator ===
Enter first number: 10
Enter second number: 5
Choose operation:
1 - Addition
2 - Subtraction
3 - Multiplication
4 - Division
Enter choice: 1

Result: 15
```

## Code Structure

### Calculator Class

The `Calculator` class (`Calculator.cs`) provides four public methods:

- `Add(double a, double b)`: Returns the sum of two numbers
- `Subtract(double a, double b)`: Returns the difference between two numbers
- `Multiply(double a, double b)`: Returns the product of two numbers
- `Divide(double a, double b)`: Returns the quotient of two numbers (throws `ArgumentException` if dividing by zero)

### Program Class

The `Program` class (`Program.cs`) contains the main entry point and handles:
- User input collection
- Operation selection
- Calculator method invocation
- Result display
- Error handling and display

## Error Handling

The application includes error handling for:
- **Division by Zero**: Displays an error message when attempting to divide by zero
- **Invalid Operation Choice**: Catches invalid operation selections
- **Input Validation**: Handles non-numeric inputs gracefully

## Building the Project

To build the project without running it:

```bash
dotnet build
```

## Development

This project uses:
- **Target Framework**: .NET 10.0
- **Language**: C# with implicit usings enabled
- **Nullable Reference Types**: Enabled for better null safety

## License

This is a practice/educational project.

## Author

Created as a .NET practice project.
