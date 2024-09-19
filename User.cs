class User{
    private string name;
    private int id;

    public string Name { get => name; set => name = value; }
    public int Id { get => id; set => id = value; }

    public User(string name, int id) {
        Name = name;
        Id = id;
    }
    public override string ToString(){
        return $"{Id}\t{Name}";
    }
}