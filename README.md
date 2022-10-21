# _Pierre's Bakery: Sweet and Savory Treats_

#### By _**Shaniza Lingle**_

#### _Help Pierre market his sweet and savory treats at the bakery!_

## Technologies Used

* _C#_
* _.NET_
* _mySQL_
* _HTML_
* _CSS_
* _Entity_
* _Identity_


## Description

_This application has user authentication and a many-to-many relationship between treats and flavors._

## Setup/Installation Requirements

* _In your terminal enter_

```json
 git clone https://github.com/ShanizaLingle/pierres-treats
```
* _Open the directory in Visual Studio Code_
* _In VS Code terminal, navigate to the Bakery directory_ 
* _In VS Code terminal, run_

```json
 $ dotnet restore
 ```

 * _Followed by,_

```json
 $ dotnet build
 ```

* _Create file named "appsettings.json" in the /Bakery folder_
* _Enter the following into the file_

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=sillystringz_factory;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _Next in VS Code terminal, enter_

```json
 $ dotnet ef database update
 ```

* _Lastly, in VS Code terminal, to start application run_

```json
$ dotnet run
```

## Known Bugs

* _No known bugs_

## License


_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ _Shaniza Lingle_