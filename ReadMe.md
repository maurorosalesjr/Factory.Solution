# Machine Repair Database

#### By Mauro Rosales jr

#### enables Foreman to keep track of Machine repairs

## Technologies Used

* SQL
* MySQL
* VSCode
* C#
* HTML
* CSS
* Entity Framework
* LazyLoading
* MVC

## Description

Enables Factory Foreman to input new Engineers and their certifications. As well as, being able to add Machines that get repaired by select engineers based on their certifications.

![SQL Design](Factory/wwwroot/img/SQLDesign.png "SQL Design")

## Setup/Installation Requirements

* clone repo from https://github.com/maurorosalesjr/Factory.Solution
* create appsettings.json file to allow user to create a SQL database to this project
* add this code to the appsettings.json file and add the missing information { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=[PORT];database=[DATABASE NAME];uid=[UID];pwd=[PASSWORD];" } }
* make sure appsettings.json file is on the .gitignore file
* in terminal type : dotnet restore
* in terminal type : dotnet build 
*  if no errors, in terminal type : dotnet ef migrations add Initial
* the previous step will build the database
* in terminal type : dotnet ef database update
* in terminal type : dotnet run
* copy/paste : http://localhost:5000 into browser window
* use links to create and build out database


## Sample
![create engineer view](Factory/wwwroot/img/sample2.png "Adding a new engineer")

![machine details view](Factory/wwwroot/img/sample1.png "Checking who is certified to work on machine")

## Known Bugs

* CSS styling doesnt always load properly

## License

open source

for any questions or comments email me here: mauro.rosales247@gmail.com

Copyright (c) August 2022, Mauro Rosales Jr