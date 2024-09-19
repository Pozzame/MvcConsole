class User{
    private String name;
    private int id;

    public string Name { get => name; set => name = value; }
    public int Id { get => id; set => id = value; }

    public User(String name, int id) {
        Name = name;
        Id = id;
    }
    public override String ToString(){
        return $"{Id}\t{Name}";
    }
}