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
* _In terminal Run:  ```git clone https://github.com/bodwood/Hair-Salon.git```_
* _In terminal enter ```code .``` to open files in Visual Studio Code_
* _In VS Code open a new terminal_
  1. _In VS Code termainl run:  ```dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0```_
  2. _In VS Code terminal run:  ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0```_
  3. _Run:  ```dotnet restore```_

* _Import database dump with MySql WorkBench
  1. _Open MySql WorkBench_
  2. _Select **Server** at top of window_
  3. _Select_ **Data Import**
  4. _Select_ **bodie_wood.sql** _file in drowndown_
  5. Click **Start Import**

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
* _Make sure to set uid and pwd_
* _Open MySQL and select **Administration** select **Data Import**_
* _Check **Import from self contained file** option and enter file path of the HairSalon Database, then start import_
* _Run: ```dotnet run``` in VS Code termainl to start the program_

## Known Bugs

* _No known bugs_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ Bodie Wood_