namespace csharp_cats_api.Models;

public class Cat
{
  public string Name { get; set; } // name: {type: String, required: true}
  public int Age { get; set; }
  public bool LikesCheese { get; set; }
  public string Color { get; set; }
  public int NumberOfLegs { get; set; }
  public DateTime Birthday { get; set; }

  // NOTE constructor
  public Cat(string name, int age, bool likesCheese, string color, int numberOfLegs, DateTime birthday)
  {
    // this.Name = name;
    // this.Age = age;
    Name = name;
    Age = age;
    LikesCheese = likesCheese;
    Color = color;
    NumberOfLegs = numberOfLegs;
    Birthday = birthday;
  }
}

// Cat cat = new Cat("Gopher", 17);