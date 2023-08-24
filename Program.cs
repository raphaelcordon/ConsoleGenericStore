using ConsoleGenericStore.Controller.CustomerController;
using ConsoleGenericStore.Controller.EmployeeController;
using ConsoleGenericStore.Data.Users;

var customer1 = new Customer("Raphael", "raphael@email.co");
var customer2 = new Customer("José", "jose@email.co");
var customer3 = new Customer("Antonio", "antonio@email.co");

CustomerController.ListAllCustomers();


var employee1 = new Employee("Patricia", "patricia@email.co");
var employee2 = new Employee("Mauricio", "mauricio@email.co");
var employee3 = new Employee("Larissa", "larissa@email.co");

EmployeeController.ListAllEmployees();