using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}
// SOLUTION START //

class MyBook : Book
{
    public int priceB;
    
    
    public MyBook(string title, string author, int price) : base(title, author){
        priceB = price; 
    }
    
    public override void display() {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + priceB);
    }
}
// SOLUTION END //
class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}