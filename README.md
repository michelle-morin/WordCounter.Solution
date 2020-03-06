# _Word Counter_

#### _C# Independent Project for Epicodus_, _Mar. 6, 2020_

#### By _**Michelle Morin**_

## Description

_This project is a console application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. The application checks for full word matches only (e.g., if provided the word "cat" and the sentence "I'm walking the cat to the cathedral", the first three letters of the word cathedral would not be counted._ 

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application takes input of a word and returns error message when the input is more than one word (contains spaces) | "hello there" | "invalid input" |
| Application takes input of a word and returns the word in lowercase form when the input is a single word (does not contain spaces) | "Hello" | "hello" |
| Application takes input of a sentence and returns an error message when the input sentence does not contain spaces (i.e., is a single word) | "cat" | "please enter a sentence" |
| Application takes inout of a sentence and returns the sentence in lowercase form when the input sentence contains at least one space (i.e., more than one word) | "Hello There" | "hello there" |
| If sentence is a valid sentence, the application removes all punctuation from input sentence before lowercasing sentence | "The cat walked." | "the cat walked" |
| Application splits sentence into array of individual words (delimited by spaces) and, for each word of the sentence that matches the input word, adds the matching word to a static list | "cat", "I'm walking the cat to the cathedral" | RepeatCounter.GetMatchingWords() returns a List<string> containing a single instance of "cat" |
| When input sentence does not include any words matching the input word, the application returns a message indicating no matches were found | "hello", "the weather is great today" | "the word {hello} does not appear in the sentence {the weather is great today}!" |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/WordCounter``
* ``cd WordCounter``

_Confirm that you have navigated to the WordCounter directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of the WordCounter directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**