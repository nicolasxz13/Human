class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor to assign custom values to all fields
    Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    // Build Attack method
    public int Attack(Human target)
    {
        Console.WriteLine("A Atacado a " + target.Name);
        //Fuerza Propia (this) x 3 da el daño inflingido.
        int dañoInflingido = target.Health + (3 * Strength);
        target.Health -= dañoInflingido;
        Console.WriteLine($"Le a quitado {dañoInflingido} de vida al objectivo\n {target.Health} Vida restante");
        return target.Health;
    }
}
