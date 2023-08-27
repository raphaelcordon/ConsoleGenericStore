using ConsoleGenericStore.Controller.CustomerController;
using ConsoleGenericStore.Controller.EmployeeController;
using ConsoleGenericStore.Controller.ProductController;
using ConsoleGenericStore.Controller.PurchaseController;
using ConsoleGenericStore.Data.Products;
using ConsoleGenericStore.Data.Purchases;
using ConsoleGenericStore.Data.Users;

//Creating Customers
List<Customer> list = new List<Customer>();
Customer customer1 = new Customer("Raphael", "raphael@email.co");
list.Add(customer1);

Customer customer2 = new Customer("José", "jose@email.co");
list.Add(customer2);

Customer customer3 = new Customer("Antonio", "antonio@email.co");
list.Add(customer3);

CustomerController.RegisterAllCustomers(list);

Customer customer4 = new Customer("Luis", "luis@email.co");
CustomerController.RegisterCustomer(customer4);

CustomerController.ListAllCustomers();


//Creating Employees
var employee1 = new Employee("Patricia", "patricia@email.co", "012", 0);
EmployeeController.RegisterEmployee(employee1);
var employee2 = new Employee("Mauricio", "mauricio@email.co", "123", 0);
EmployeeController.RegisterEmployee(employee2);
var employee3 = new Employee("Larissa", "larissa@email.co", "234", 0);
EmployeeController.RegisterEmployee(employee3);
EmployeeController.ListAllEmployees();


//Creating Products
var product1 = new Product("Metallica - ...And Justice for All", 20.99m, "CD de Metal", 0);
var product2 = new Product("Queen - Kind of Magic", 50.99m, "Kind of Magic DVD Tour", 0);
var product3 = new Product("Led Zeppelin - IV", 30.99m, "Remastered Vinyl", 0);
var product4 = new Product("Iron Maiden - Iron Maiden", 20.99m, "Remastered K7", 0);

ProductController.RegisterProduct(product1);
ProductController.RegisterProduct(product2);
ProductController.RegisterProduct(product3);
ProductController.RegisterProduct(product4);
ProductController.ListAllProducts();


//Creating Purchases
var purchaseProds1 = new List<Product>();
purchaseProds1.Add(product1);
purchaseProds1.Add(product2);
var purchase1 = new Purchase(purchaseProds1, customer1, false);
PurchaseController.RegisterPurchase(purchase1);
PurchaseController.ListAllPurchases();