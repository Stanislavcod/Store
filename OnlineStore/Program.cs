using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineStore;
using OnlineStore.Entities;
using Microsoft.Data.SqlClient;

#region creating a configuration
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;
#endregion
using (ApplicationContext db = new ApplicationContext(options))
{
    Buyer buyer1 = new Buyer { Login = "login123", Password = "Password" };
    Buyer buyer2 = new Buyer { Login = "login2", Password = "Password" };
    db.Buyers.AddRange(buyer1, buyer2);
    db.SaveChanges();
    Phone phone1 = new Phone { PhoneNumber = "+37529550", User = buyer1 };
    Phone phone2 = new Phone { PhoneNumber = "+37528444", User = buyer1 };
    Phone phone3 = new Phone { PhoneNumber = "+37529542", User = buyer2 };
    db.Phones.AddRange(phone1, phone2, phone3);
    db.SaveChanges();
    Category category = new Category { Description = "Техника" };
    db.Categories.Add(category);
    Supplier supplier = new Supplier { Name = "Иван Васильевич" };
    db.Suppliers.Add(supplier);
    Product product = new Product { Name = "Айфооон", Supplier = supplier, Price = 5, Category = category };
    db.Products.Add(product);
    db.SaveChanges();

    // StoredProcedure
    SqlParameter parameter = new SqlParameter("@login", "login123");
    var phonesfromProcedure = db.Phones.FromSqlRaw("GetPhonesUsers @login", parameter).ToList();
    foreach (var item in phonesfromProcedure)
        Console.WriteLine($"{item.PhoneNumber}");

    // View ProductSuppliersGroup

    var productSuppliers = db.ProductSuppliersGroup.ToList();
    foreach (var item in productSuppliers)
        Console.WriteLine($"Название продукта: {item.ProductName}, Цена: {item.ProductPrice}, Имя поставщика: {item.SupplierName}");

    //Using the Include method
    // Get data about phones by uploading users
    var phones = db.Phones.Include(i => i.User).ToList();
    foreach (var item in phones)
        Console.WriteLine($"Логин пользователя: {item.UserLogin}. Телефон: {item.PhoneNumber}");

}