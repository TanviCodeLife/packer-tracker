#PackerTracker

#### C# .NET MVC project with CRUD Routing

#### Sheila Stephen, Victoria Martinez and Tanvi Garg

## Description
A program for users to catalog things they need for upcoming camping, backpacking, bike touring, or rock climbing, road trips, or other types of travel.

The directory/file structure created follows this format:

```
PackerTracker.Solution
├── README.md
├── .gitignore
└── PackerTracker
    ├── PackerTracker.csproj
    ├── Program.cs
    ├── Startup.cs
    ├── Controllers
    │   └── HomeController.cs
    ├── Models
    └── Views
        └── Home
            └── Index.cshtml

└── PackerTracker.Tests
    └── PackerTracker.Tests.csproj
    └── ModelTests

```

### Specifications:
* _**create class: BagItem**_
* _**create properties: each Bag object string name of item; int price; int weight; bool packed or unpacked; id of item.**_
* _**create static instance property to that holds all instances of the the BagItem class.**_
* _**create getter and setter methods for each property**_
* _**test back-end logic with "Red, Green, Refactor" workflow before building your MVC front-end.**_

## Setup/Installation Requirements

Install the template using the command line interface (cli)/terminal:
* dotnet new --install [ /Users/Your/Path/Here ]/PackerTracker.Solution

Navigate to the directory that you want your project to be in (i.e. Desktop, Documents, or wherever you keep your projects).

Run the this command in the cli/terminal:
* dotnet new templatemvc -n [ PackerTracker ] -o [ PackerTracker ].Solution

Open the directory in your text editor. Open the .template.config/template.json file and change the author name to your own. Read the article mentioned above for details on this file and how to use it.

## Known Bugs

## Support and contact details
#### Sheila Stephen, Victoria Martinez and Tanvi Garg

## Technologies Used

HTML, CSS, Json, C#.

### License

Licensed under the MIT license.

Copyright (c) 2018 ** Sheila Stephen, Victoria Martinez and Tanvi Garg **
