using Learn_Factory_Method.DTO;
using Learn_Factory_Method.Services;


/*
 ایجاد شیء در زمان اجرا (Runtime) 
مثلا میخاهیم در زمان اجرا در شرایطی به یک دیتابیس وصل شه واگر اون شرط برقرار نباشه به دیتابیس دیگه ا وصل شود .

 */


var factory = new DatabaseConnectionFactoryService();

Console.Write("connectionString : ");
var connectionString = Console.ReadLine();

Console.Write("db Type : Select sqlserver = 1 , mysql = 2 , postgresql =3 : ");
var dbType = Console.ReadLine();

var connection = factory.CreateConnection(connectionString, (DataBaseEnum)Convert.ToInt32(dbType));

connection.Connect();

connection.Disconnect();



