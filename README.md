# Project: TestTask

## Code Modifications
### SQL Server Connection String Update:
Modified the connection string to connect to MS SQL Server.
### UserStatusConverter Implementation:
Created the `UserStatusConverter` class to convert `UserStatus` enum values to numeric representations for storage and retrieval from the database.
### Database Initialization:
Initialized the database using an existing migration.
### Service Registrations:
Registered services in the `Program.cs` file using `builder.Services.AddScoped` for `IUserService` and `IOrderService`.
### Interface Implementations:
Added implementations of IUserService and IOrderService interfaces

## Custom Functionalities
### UsersController
1. **Get User with the Most Orders:**
   - Implemented functionality to return the user with the highest number of orders.
2. **Get Users with Inactive Status:**
   - Implemented functionality to return users with the "Inactive" status.

### OrdersController
1. **Get Order with the Highest Total Price:**
   - Implemented functionality to return the order with the highest total price.
2. **Get Orders with Quantity Greater Than 10:**
   - Implemented functionality to return orders with a product quantity greater than 10.
