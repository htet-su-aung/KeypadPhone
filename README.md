# Keypad Phone Converter

This repository contains a C# console application that converts input from an old phone keypad layout into readable text. It's designed to demonstrate string manipulation and basic input handling in C#.

## Prerequisites

.NET SDK - 7.0

## Setup

### Debug Version

Clone the repository from GitHub:
git clone https://github.com/htet-su-aung/KeypadPhone.git

Navigate to the directory containing the .csproj file in your terminal.

Build and run the application:
dotnet run

### Release Version

Build the application in release mode.

Navigate to the folder where the output files (xxx.dll) are located.

Run the application using the following command:

dotnet xxx.dll

## Usage

When the program starts, it will prompt you with "Enter input:". Here, you can input a string of digits and special characters using the old phone keypad layout. Press Enter, and the application will convert the input into readable text.

## Technical Explanation

keypadData: Dictionary mapping digit inputs to corresponding alphabet text outputs.
del, hold, send: Variables declaring special characters (#, *, ^) to reduce duplicate code.
Main() function: Accepts user input, processes it, and prints the output.
oldPhoneKeypad() function: Generates output based on input validation, checks, and character mapping.
Validates input format using regex to ensure only numbers and special characters are entered.
Utilizes the findChars() function to generate a list of characters from the input string.
Maps characters using keypadData and concatenates them into a final output string.
findChars() function: Generates a list of characters to be used in the final output.
Loops through each character in the input string, handling special cases (del, hold, send).
Concatenates characters until a different character or a special character is encountered.
Returns a list (resultList) containing individual characters or groups of characters based on input sequence.
