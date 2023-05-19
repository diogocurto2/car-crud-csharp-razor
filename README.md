% The Coding Assessment

# Instructions for Run
For run this Solution, execute the project car-crud-csharp-razor-web.


This project is devide into:

1 - car-crud-csharp-razor-web
	objective: run the solution and store the razor pages

2 - car-crud-csharp-razor-services
	Objective: store the usecases and call the repositoryu on infra.

3 - car-crud-csharp-razor-model
	Objective: store the cars model and execute business process

4 - car-crud-csharp-razor-infra
	Objective: store the cars repository and execute repository functions

# The Coding Assessment 1:

## Instructions:

C#/Razor
You have a model that is a car. You want to define its make, model, year, doors, colors, price. Build a simple service that contains some basic CRUD operations against a list of cars:

private List<Car> cars = new (){
        new Car { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 2, Make = “Tesla", Model = “3", Year = 2018, Doors = 4, Color = "Black", Price = 54995 },
        new Car { Id = 3, Make = "Porsche", Model = " 911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 5, Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 },
    };

Build a simple page markup with where you display the car information and allow the user to guess the price. If within 5,000 of the guess, display a great job message in green. 


# The Coding Assessment 2:

## Instructions:
SQL
You have three different tables
A Customer Table with FirstName, LastName, Age, Occupation, MartialStatus, PersonID

An Orders Table with OrderID, PersonID, DateCreated, MethodofPurchase

An Orders Details table with OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin



Please return a result of the customers who ordered product ID = 1112222333 and return
FirstName and LastName as full name, age, orderid, datecreated, MethodOfPurchase as Purchase Method, ProductNumber and ProductOrigin

## Initial Resolution:
You need to create this tables using this SQL commands:

Customer Table:
CREATE TABLE Customer (
    PersonID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    Occupation VARCHAR(100),
    MartialStatus VARCHAR(20)
);

Orders Table:
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    PersonID INT,
    DateCreated DATE,
    MethodofPurchase VARCHAR(50),
    FOREIGN KEY (PersonID) REFERENCES Customer(PersonID)
);

OrderDetails Table:
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductNumber VARCHAR(50),
    ProductID VARCHAR(50),
    ProductOrigin VARCHAR(50),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);


## Result

The final results can execute by this SQL command:
SELECT 
    CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
    c.Age,
    o.OrderID,
    o.DateCreated,
    o.MethodofPurchase AS PurchaseMethod,
    od.ProductNumber,
    od.ProductOrigin
FROM 
    Customer c
JOIN 
    Orders o ON c.PersonID = o.PersonID
JOIN 
    OrderDetails od ON o.OrderID = od.OrderID
WHERE 
    od.ProductID = '1112222333';