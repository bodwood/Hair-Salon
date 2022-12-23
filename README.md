# Hair Salon

#### By Bodie Wood

## Technologies Used

- C#
- .NET 6
- ASP.NET Core MVC
- Entity
- MySQL
- HTML
- CSS

## Description

This application allows the user to track stylists and their clients for a hair salon using a MySQL database.

## Setup/Installation Requirements

* _Open up your terminal and navigate to the desired landing folder_
* _In terminal Run:  ```git clone https://github.com/BodWood/HairSalon```_
* _In terminal enter ```code .``` to open files in Visual Studio Code_
* _In VS Code open a new terminal_
  1. _In VS Code termainl run:  ```dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0```_
  2. _In VS Code terminal run:  ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0```_
  3. _Run:  ```dotnet restore```_
* _Create a new file called ```appsettings.json``` within the HairSalon directory_
  *  In VS Code terminal: 
      - Run:  ```cd HairSalon```
      - Run:  ```touch appsettings.json```
* _Enter the following into the file:_
```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=bodie_wood;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
  }
```
* Make sure to set uid and pwd
* _Open MySQL and select **Administration** select **Data Import**_
* _Check **Import from self contained file** option and enter file path of the HairSalon Database, then start import_
* _Run: ```dotnet run``` in VS Code termainl to start the program_