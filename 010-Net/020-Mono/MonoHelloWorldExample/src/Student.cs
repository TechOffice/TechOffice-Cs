using System;

public class Student{

  private string name;

  public Student(string name){
    this.name = name;
  }

  public string getName(){
    return name;
  }

  public void setName(string name){
    this.name = name;
  }

  static public void Main(string[] args){
      Console.WriteLine("Hello World! This is Tech Office C# Example.");
      Student student = new Student("Tester");
      Console.WriteLine("The name of Student: " + student.getName());
  }

}
