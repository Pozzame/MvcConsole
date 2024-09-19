class View{
    private Database _db;

    public View(Database db) {
        _db = db;
    }

    public void ShowMainMenu(){
        Console.WriteLine("1. Aggiungi user");
        Console.WriteLine("2. Leggi users");
        Console.WriteLine("3. Modifica user");
        Console.WriteLine("4. Elimina user");
        Console.WriteLine("5. Search user By Name");
        Console.WriteLine("6. Esci");
    }

    public void ShowUsers(List<User> users){
        foreach (User user in users) {
            Console.WriteLine( user );
        }
    }

    public string GetInput(){
        return Console.ReadLine()!;
    }
}