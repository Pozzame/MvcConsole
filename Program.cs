using System.Data.SQLite;
class Program
{
    static void Main(string[] args)
    {
        var db = new Database();
        var view = new View(db);
        var controller = new Controller(db, view);
        controller.MainMenu();
    }
}

// class Database{
//     private SQLiteConnection _connection;

//     public Database(){
//         _connection = new SQLiteConnection("Data Source=database.db");
//         _connection.Open();
//         var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, name, TEXT)", _connection);
//         command.ExecuteNonQuery();
//     }

//     public void AddUser(string name){
//         var command = new SQLiteCommand($"INSERT INTO users (name) VALUES ('{name}')", _connection);
//         command.ExecuteNonQuery();
//     }

//     public List<string> GetUsers()
//     {
//         var command = new SQLiteCommand("SELECT name FROM users", _connection);
//         var reader = command.ExecuteReader();
//         var users = new List<string>();
//         while (reader.Read()){
//             users.Add(reader.GetString(0));
//         }
//         return users;
//     }
// }


// class View{
//     private Database _db;
//     public View(Database db){
//         _db = db;
//     } 
//     public void ShowMainMenu(){
//         Console.WriteLine("1. Aggiungi user");
//         Console.WriteLine("2. Leggi users");
//         Console.WriteLine("3. Esci");
//     }

//     public void ShowUser(List<string> users){
//         foreach (var user in users){
//             Console.WriteLine(user);
//         }
//     }

//     public string GetInput(){
//         return Console.ReadLine()!;
//     }
// }

// class Controller{
//     private Database _db;
//     private View _view;
//     public Controller(Database db, View view){
//         _db = db;
//         _view = view;
//     }

//     public void MainMenu(){
//         while (true){
//             _view.ShowMainMenu();
//             var input = _view.GetInput();
//             if (input == "1"){
//                 AddUser();
//             }
//             else if (input=="2") {
//                 ShowUsers();
//             }
//             else if(input=="3") {
//                 break;
//             }
//         }
//     }
//     private void AddUser(){
//         Console.WriteLine("Enter user name:");
//         var name = _view.GetInput();
//         _db.AddUser(name);
//     }
//     private void ShowUsers(){
//         var users = _db.GetUsers();
//         _view.ShowUser(users);
//     }
// }