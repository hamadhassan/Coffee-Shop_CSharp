# Coffee Shop
## Case Study Scenario
### Create a Class MenuItem, which has three instances
    1. name: name of the item
    2. type: whether food or a drink
    3. price: price of the item
### Write a class called CoffeeShop, which has three instance variables:
    1. name : a string (basically, of the shop)
    2. menu : an list of items (of object type), with each item containing the item (name of the item),type (whether food or a drink) and price.
    3. orders : an empty list of string type.
### A parameterized constructor which takes the name of the CoffeeShop as a parameter, eight methods:
    1. addMenuItem: adds the menu item in the list of menu
    2. addOrder: adds the name of the item to the end of the orders list if it exists on the menu.Otherwise, return "This item is currently unavailable!"
    3. fulfillOrder: if the orders list is not empty, return "The {item} is ready!" and make the list empty.If the order list is empty, return "All orders have been fulfilled!"
    4. listOrders: returns the list of orders taken, otherwise null.
    5. dueAmount: returns the total amount due for the orders taken.
    6. cheapestItem: returns the name of the cheapest item on the menu.
    7. drinksOnly: returns only the item names of type drink from the menu.
    8. foodOnly: returns only the item names of type food from the menu.
## Domain Model

### Class name
![class name only](https://user-images.githubusercontent.com/96945594/180646709-b5897d61-d9bc-4b84-8d59-e6f6bc3a1aee.jpg)
### Relations and Constraints
![relation](https://user-images.githubusercontent.com/96945594/180646706-d6e14da5-2e8d-4c61-acba-8838232fb439.jpg)
### Multiplicity
![multiplicity](https://user-images.githubusercontent.com/96945594/180646705-a45cbed2-819a-4cc2-a8d4-b7b18282b5e1.jpg)
### Attributes and Function
#### Business Logic Layer
![bl](https://user-images.githubusercontent.com/96945594/180646708-4d57e617-b3f2-4be4-a33c-4d0553f9961c.JPG)
#### Data Layer
![dl](https://user-images.githubusercontent.com/96945594/180646704-a8252f6d-5ef5-4769-9f29-42a89a22b6c7.JPG)
#### User Interfaces Layer
![ul](https://user-images.githubusercontent.com/96945594/180646707-532544ba-aeee-47ae-8194-f05bf51fcac0.JPG)
