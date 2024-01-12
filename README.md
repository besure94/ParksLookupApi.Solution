# Parks Lookup API

#### An application that lists national and state parks.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* MySQL

## Description

This application has full CRUD functionality (Create, Read, Update, Delete), and allows users to GET (Read), POST (Create), PUT (Edit), and DELETE (Delete) national and state parks. Users can view a list of all national and state parks, and also search for parks by different criteria. They can also add new parks to the list, and edit the information of existing parks. Additionally, users can delete parks from the list.

## Setup Instructions

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

1. Select the green button that says "Code", and clone this repository to your desktop.
2. Open your terminal, and navigate to this project's production directory called `ParksLookupApi`.
3. Inside this production directory, create a file called `appsettings.json`.
4. In the `appsettings.json` file, enter the following code. Make sure to replace the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL. For the LearnHowToProgram.com lessons, always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_lookup_api;uid=root;pwd=epicodus;"
  }
}
```

5. Create the database by using the `Migrations` folder in the `ParksLookupApi` production directory. In the `ParksLookupApi` directory, run the command `dotnet ef database update`. This will create the database in MySQL.
    * If you want to create a migration, run the command `dotnet ef migrations add MigrationName`. `MigrationName` is your custom name for the migration, and should be written in UpperCamelCase format.


## Testing API Endpoints

Within the production directory `ParksLookupApi`, run the command `dotnet watch run` to start making API calls using Swagger. This will automatically direct you to the domain _https://localhost:5001_.

### Available Endpoints

**Note: this API contains two versions. Version 2 contains an additional optional query parameter for a GET request that Version 1 does not.**

The different versions can be located in the upper right hand of the page in Swagger. There is a dropdown menu that contains `v2` and `v1`. The application will automatically start on `v2`, as that is the most recent version. Start with testing the endpoints for `v1`, before moving on to `v2`.

### Version 1 Endpoints

```
GET https://localhost:5001/api/v1/parks
GET https://localhost:5001/api/v1/parks/{id}
POST https://localhost:5001/api/v1/parks
PUT https://localhost:5001/api/v1/parks{id}
DELETE https://localhost:5001/api/v1/parks{id}
```

Note: `{id}` is a variable and should be replaced with the id number of the park that you want to GET, PUT, or DELETE. The id will be automatically created when you POST a park.

#### Optional Query String Parameters for GET Request (Version 1)

GET requests to `https://localhost:5001/api/v1/parks` can include optional query strings to filter parks by different criteria.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| name   | String      | not required | Returns parks with a matching "name" property value. |
| type        | String      | not required | Returns parks with a matching "type" value. |
| location  | String     | not required | Returns parks with a matching "location" property value. |
| rating    | Number      | not required | Returns parks with a matching "rating" property value. |
| pageNumber       | Number      | not required | Returns five parks from a specified page number. |

The following query will return all parks with a name property value of "Zion National Park":

```
GET https://localhost:5001/api/v1/parks?name=zion%national%park
```

The following query will return all parks with a type property value of "National":

```
GET https://localhost:5001/api/v1/parks?type=national
```

The following query will return all parks with a location property value of "Utah":

```
GET https://localhost:5001/api/v1/parks?location=utah
```

The following query will return all parks with a rating property value of 5:

```
GET https://localhost:5001/api/v1/parks?rating=5
```

The following query will return five parks from page two of the parks list:

```
GET https://localhost:5001/api/v1/parks?pageNumber=2
```

You can also include multiple query strings by separating them with an `&`. For example, the following query will return all state parks in Oregon with a rating of 4:

```
GET https://localhost:5001/api/v1/parks?type=state&location=oregon&rating=4
```

#### Additional Requirements for POST Request

When making a POST request to `https://localhost:5001/api/v1/parks`, your request needs to include a "body". **Do not** create a parkId, as these are automatically generated upon creation. Example below:

```json
{
  "name": "Crater Lake National Park",
  "type": "National",
  "location": "Oregon",
  "rating": 5
}
```

#### Additional Requirements for PUT Request

When making a PUT request, such as `https://localhost:5001/api/v1/parks/{id}`, your request needs to include a "body" that includes the park's `parkId` property. The requested id must match the `parkId` property value that exists for the specific park. Otherwise, the park will not be located and you will be unable to complete your request. Example below:

```json
{
  "parkId": 1,
  "name": "Arches National Park",
  "type": "National",
  "location": "Utah",
  "rating": 5
}
```

#### Additional Requirements for DELETE Request

When making a DELETE request, such as `https://localhost:5001/api/v1/parks/{id}`, your request's id needs to match the `parkId` property value that exists for the specific park. If the id doesn't match the `parkId`, the park will not be located, and you will be unable to complete your request.

### Version 2 Endpoints

```
GET https://localhost:5001/api/v2/parks
GET https://localhost:5001/api/v2/parks/{id}
POST https://localhost:5001/api/v2/parks
PUT https://localhost:5001/api/v2/parks{id}
DELETE https://localhost:5001/api/v2/parks{id}
```

Note: `{id}` is a variable and should be replaced with the id number of the park that you want to GET, PUT, or DELETE. The id will be automatically created when you POST a park.

**Remember:** all of the other endpoints for `v2` of this API are exactly the same as `v1`. To view the additional requirements for POST, PUT, and DELETE requests, refer to `v1` in the "Version 1 Endpoints" section above.

#### Optional Query String Parameters for GET Request

GET requests to `https://localhost:5001/api/v2/parks` can optionally include query strings to filter reviews by different criteria. These query strings are the same as `v1`, except for one additional query string.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| name   | String      | not required | Returns parks with a matching "name" property value. |
| type        | String      | not required | Returns parks with a matching "type" value. |
| location  | String     | not required | Returns parks with a matching "location" property value. |
| rating    | Number      | not required | Returns parks with a matching "rating" property value. |
| pageNumber       | Number      | not required | Returns five parks from a specified page number. |
| random | String | not required | Returns a single random park from the list. |

The following query will return all parks with a name property value of "Arches National Park":

```
GET https://localhost:5001/api/v2/parks?name=arches%national%park
```

The following query will return all parks with a type property value of "State":

```
GET https://localhost:5001/api/v2/parks?type=state
```

The following query will return all parks with a location property value of "Colorado":

```
GET https://localhost:5001/api/v2/parks?location=colorado
```

The following query will return all parks with a rating property value of 4:

```
GET https://localhost:5001/api/v2/parks?rating=4
```

The following query will return five parks from page three of the parks list:

```
GET https://localhost:5001/api/v2/parks?pageNumber=3
```

The following query will return a single random park:

```
GET https://localhost:5001/api/v2/parks?random=random
```

You can also include multiple query strings by separating them with an `&`. For example, the following query will return all national parks in California with a rating of 5:

```
GET https://localhost:5001/api/v1/parks?type=national&location=california&rating=5
```

## Known Bugs

None.

## License

MIT

Copyright(c) 2024 Brian Scherner
