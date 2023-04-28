# ThaiTanic

## Usage

### Entities
- ### Items `CLASS`
  - ### ItemCategory `ENUM` <br>
    #### Is a mapping of the MySql enum found in the `items` table.
  - ### CreateItem `STATIC METHOD` <br>
    #### Takes the item fields and administrator credentials as the parameters. If the entered user credentials do not have administrator privileges it will return `false`.
  - ### GetAllItems `STATIC METHOD` <br>
    #### Returns all `Items` as `List<Items>`.
  - ### GetItemById `STATIC METHOD` <br>

- ### OrderBatch `CLASS`
- ### Orders `CLASS`
- ### User `CLASS`
  - ### AuthUser `STATIC METHOD` <br>
    #### Takes a `username` and a `password` as the parameters, and returns the user, as an instance of the `User` class, that matches the parameters. If none exists, it will return `null`.