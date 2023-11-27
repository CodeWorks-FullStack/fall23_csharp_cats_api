namespace csharp_cats_api.Models;

public class Cat
{
  public int Id { get; set; }
  public string Name { get; set; } // name: {type: String, required: true}
  public int Age { get; set; }
  public bool LikesCheese { get; set; }
  public string Color { get; set; }
  public int NumberOfLegs { get; set; }

  // NOTE constructor
  public Cat(int id, string name, int age, bool likesCheese, string color, int numberOfLegs)
  {
    // this.Name = name;
    // this.Age = age;
    Id = id;
    Name = name;
    Age = age;
    LikesCheese = likesCheese;
    Color = color;
    NumberOfLegs = numberOfLegs;
  }
}

// Cat cat = new Cat("Gopher", 17);