using System;

public class Student{
    public int id,age;
    public String name;
    public Student(int id,String name,int age){
        this.id = id;
        this.name = name;
        this.age = age;
    }
    public void displayInformation(){
        Console.WriteLine(this.name);
        Console.WriteLine(this.age);
        Console.WriteLine(this.id);
    }
}

class Program{
    public static void Main(String[] args){
        Student student = new Student(12,"Irfan",22);
        student.displayInformation();
    }
}
// .....