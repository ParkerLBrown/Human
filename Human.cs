namespace Human
{
  class Human
  {
    // Fields for Human
    public string Name {get;set;}
    public int Strength {get;set;}
    public int Intelligence {get;set;}
    public int Dexterity {get;set;}
    private int _health {get;set;}
    public int Health
    {
      get {return _health;}
    }

    // [X] add a public "getter" property to access health

    // [] Add a constructor that takes a value to set Name, and set the remaining fields to default values

    // [] Add a constructor to assign custom values to all fields

    // [] Build Attack method

    public Human(string name="name")
    {
      this.Name = name;
      this.Strength = 3;
      this.Intelligence = 3;
      this.Dexterity = 3;
      this._health = 100;
    }
    public Human(string name="name", int strength = 0, int intelligence = 0, int dexterity = 0, int health = 0)
    {
      this.Name = name;
      this.Strength = strength;
      this.Intelligence = intelligence;
      this.Dexterity = dexterity;
      this._health = health;
    }

    public int Attack(Human target)
    {
      target._health -= this.Strength * 5;
      return target._health;
    }
  }
}