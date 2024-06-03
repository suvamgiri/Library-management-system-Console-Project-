using System;
using System.Collections.Generic;

public class Book{
  public string title{get;set;}
  public string author{get;set;}
  public int pages{get;set;}
  public string genre{get;set;}
  public int year{get;set;}
 
  public Book(string aTitle, string aAuthor, int aPages, string aGenre, int aYear){
    title=aTitle;
    author=aAuthor;
    pages=aPages;
    genre=aGenre;
    year=aYear;
   
  }
}
public class User{
  public string name{get;set;}
  public string bookname{get;set;}
  public User(string aName, string aBookname){
    this.name=aName;
    this.bookname=aBookname;
  }
}


class Program {

  public static void Main (string[] args) {
    List<Book> books = new List<Book>(){
      new Book("Harry Potter","JK Rowling",500,"Fantasy",1997),
    };

    List<User> users =new List<User>();
   bool ram = true;

    Console.WriteLine("\t welcome to the libarary");
    while(ram!){ 
    Console.WriteLine("1:ADD");
    Console.WriteLine("2.see");
    Console.WriteLine("3.buy");
    Console.WriteLine("4.book buy detailes");
    Console.WriteLine("5.exit");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
    case 1:
      Add(books);
      break;
    case 2:
      see(books);
      break;
    case 3:
      buy(users);
      
    break;

    case 4:

      bookrecode(users);
      break;
      
    case 5:
      exit(books);
      ram = false ;
      break;
    default:
      Console.WriteLine("Invalid choice");
      break;
    }
     }
  }
  public static void Add(List<Book> books){
    Console.Write("Enter title  ");
    string title = Console.ReadLine();
    Console.Write("Enter author  ");
    string author = Console.ReadLine();
    Console.Write("Enter pages  ");
    int pages = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter genre  ");
    string genre = Console.ReadLine();
    Console.Write("Enter year  ");
    int year = Convert.ToInt32(Console.ReadLine());
    books.Add(new Book(title,author,pages,genre,year));
  }
  public static void see(List<Book> books){
   
    Console.Write("title   | ");
    Console.Write("author  |  ");
    Console.Write("pages   |  ");
    Console.Write("genre   | ");
    Console.Write("year     \n");
    
    foreach(Book book in books){
    
      Console.Write(book.title + "|");
      Console.Write(book.author+" |");
      Console.Write(book.pages+"  |");
      Console.Write(book.genre+"  |");
      Console.Write(book.year+"   \n");
    }
  }
public static void buy(List<User> users){

  Console.Write("enter your name  : ");
  string name = Console.ReadLine();
  Console.Write("enter book name : ");
  string bookname = Console.ReadLine();
  users.Add(new User(name,bookname));
}
  public static void exit(List<Book> books){
    
    Console.WriteLine("thankyou for visiting");
    Console.WriteLine("press any key to exit");
    Console.ReadKey();
    Environment.Exit(0);
    
  }
  public static void bookrecode(List<User> users){
    foreach(User user in users){
      Console.WriteLine(user.name+" "+user.bookname);
    }
    
  }
  }

