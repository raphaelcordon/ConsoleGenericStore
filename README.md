# Console Generic Store

### First C# project as part of a sequence of reviewing courses I'm doing on C# and Dot.Net.
### This project is a console implementation of basic concepts by simulating a **Shop** where you can create:
  - **Customers** with Name and email;
  - **Employees** with Name, email, Registry Number and Role;
  - **Products** with Name, Price, Description and Category;
  - **Purchase** with List<Product>, Customer, and bool IsConcluded to confirm if the purchase was concluded.

This project is just console based without persistence, but part of the structure is already prepared for further courses including Web implementation and persistence in Database.

## For executing this project
	You only need to run the console, executing the actions in Program.cs.
	The folder Controller has static classes to "persist" new users (customers and employees), products and purchases in lists.
	Also, it has a class for listing the entries from those lists.
	CRUD isn't fully done here as this first project only concerns on implementing basic concepts.