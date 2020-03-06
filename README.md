# _Word Counter_

#### _C# Independent Project for Epicodus_, _Mar. 6, 2020_

#### By _**Michelle Morin**_

## Description

_This project is a console application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. The application checks for full word matches only (e.g., if provided the word "cat" and the sentence "I'm walking the cat to the cathedral", the first three letters of the word cathedral would not be counted._ 

## Specifications:

| Specification | Example Input | Example Output | Explanation of Selected Input Values |
| ------------- |:-------------:| :-------------:| -----------------:|
| Application takes input of a word and returns error message when the input is more than one word (contains spaces) | "hello there" | "invalid input" | This input value includes one space and thus is easily rejected by the sentence validation method. |
| Application takes input of a word and returns the word in lowercase form when the input is a single word (does not contain spaces) | "Hello" | "hello" | This input value includes one capital letter and thus provides a clear pass/fail depending upon whether the "H" is lowercased. |
| Application takes input of a sentence and returns an error message when the input sentence does not contain spaces (i.e., is a single word) | "cat" | "please enter a sentence" | This input value is a single word containing no spaces. |
| Application takes input of a sentence and returns the sentence in lowercase form when the input sentence contains at least one space (i.e., more than one word) | "Hello There" | "hello there" | This input includes two words with a single capital letter, and thus provides a clear pass/fail based upon whether the "H" is lowercased |
| If sentence is a valid sentence, the application removes all punctuation from input sentence before lowercasing sentence | "The cat walked." | "the cat walked" | This input includes only one punctuation mark to remove |
| Application splits sentence into array of individual words (delimited by spaces) and, for each word of the sentence that matches the input word, adds the matching word to a static list | "cat", "I'm walking the cat to the cathedral" | static List<string> contains one string | There is only one occurance of the input word "cat" in this input sentence, and the sentence includes another partial match (cathedral), so this test should also ensure the application accepts only complete matches |

_In addition to the above specifications, the application implements the following UI behaviors:_
* _When input sentence does not include any words matching the input word, the application returns a message indicating no matches were found (e.g., input word: "hello", input sentence: "the weather is great today" would result in output of: "the number of times the word {hello} appears in the sentence {the weather is great today} is {0}!")_
* _When the input sentence does include a word(s) matching the input word, the application returns a message indicating the number of matches found (e.g., input word: "cat", input sentence: "i walked the cat" would result in the output: "the number of times the word {cat} appears in the sentence {i walked the cat} is {1}!)_

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