# NameSorter
NameSorter is a C# console application that reads names from a text file, sorts them by last name and then by first name, and writes the sorted names to an output text file.

[![.NET Core Desktop](https://github.com/anureshmp/NameSorter/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/anureshmp/NameSorter/actions/workflows/dotnet-desktop.yml)

## Build Pipeline
This project uses GitHub Actions to automatically build and test the application. The build pipeline is defined in the `.github/workflows/dotnet-build.yml` file.

## Prerequisites
.NET Core SDK >= 8.0.4

## Features
- Reads names from a text file
- Sorts names by last name and then by first name
- The sorted names will be written to a text file named sorted-names-list.txt in the same directory as the input file.
- Prompts the user to continue processing another file after each operation
- Handles invalid file path scenario

## Getting Started
Follow these instructions to get the project up and running on your local machine.

1. Clone the Repository
2. Build the Project
3. Create an input file in any directory and add the names for sorting, each on a new line.
4. Run the Program - The program will prompt you to enter the input file path. Provide the path to your input file.
5. Output - The sorted names will be written to a text file named sorted-names-list.txt in the same directory as the input file.

## Unit Tests
Unit tests are provided and they cover the following components:
- Name class
- FileNameReader class
- FullNameSorter class
- FileNameWriter class
