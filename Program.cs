using ConsoleGenericStore.Controller.CustomerController;
using ConsoleGenericStore.Controller.EmployeeController;
using ConsoleGenericStore.Controller.ProductController;
using ConsoleGenericStore.Data.Products;
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

ProductController.RegisterProduct(product1);
ProductController.ListAllProducts();