# ThaiTanic

## Usage

### Entities
- ### Items `CLASS`
  - ### ItemCategory `ENUM` <br>
    Is a mapping of the MySql enum found in the `items` table.
  - ### CreateItem `STATIC METHOD` <br>
    Takes the item fields and administrator credentials as the parameters. If the entered user credentials do not have administrator privileges it will return `false`.
  - ### GetAllItems `STATIC METHOD` <br>
    Returns all `Items` as `List<Items>`.
  - ### GetItemById `STATIC METHOD` <br>
  - ### Fetch `INSTANCE METHOD` <br>
    Updates the instance to reflect the changes made to the record in the `items` table.
  - ### UpdateItem `INSTANCE METHOD` <br>
    In contrast to `Fetch()`, this method updates the record in the database and updates the instance via `Fetch()` method.

- ### OrderBatch `CLASS`
- ### Orders `CLASS`
- ### User `CLASS`
  - ### AuthUser `STATIC METHOD` <br>
    Takes a `username` and a `password` as the parameters, and returns the user, as an instance of the `User` class, that matches the parameters. If none exists, it will return `null`.
  - ### GetUserById `STATIC METHOD` <br>

## To Implement (Back-End)
 1. ~~`UpdateItem` instance method for `Items`~~
 2. ~~`AddEntry` static method for `Cart`~~ **API MAY CHANGE**
 3. ~~`SubtractEntry` static method for `Cart`~~ **API MAY CHANGE**
 4. Database `Exception` handling for each `Entity`. (Low Priority)
 5. ~~Conversion of `OrderBatch` instance to `CartEntry` instance. (Low Priority)~~