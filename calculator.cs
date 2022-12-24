using System;

class Program {
  public static void Main (string[] args) {
    int num1,num2,num3,choice;
    Console.WriteLine(" WELCOME TO THE CALCULATOR");
     Console.WriteLine("Press any key to start ");
    Console.ReadLine();
    Console.WriteLine("about - this calculator perform different operation on the values \n 1 for sum \n 2 for subtract \n 3 for multiply \n 4 for division ");
    choice=Console.ReadLine();
    Console.WriteLine("Enter first  number :: ");
    num1=Console.ReadLine();
    Console.WriteLine("Enter second  number :: ");
    num2=Console.ReadLine();
    if (choice == 1){
      num3=add(num1, num2);
      Console.WriteLine("Total of " +num1 + " and " + num2 " is " +num3);
    }
    else if(choice ==2 ){
      num3=diff(num1,num2);
      Console.WriteLine("Diff of " +num1 + " and " + num2 " is " +num3);
    }
    else if(choice ==3 ){
      num3=multiply(num1,num2);
      Console.WriteLine("product of " +num1 + " and " + num2 " is " +num3);
    }
    else if(choice ==4 ){
      num3=divison(num1,num2);
      Console.WriteLine("Divison  of " +num1 + " and " + num2 " is " +num3);
    }
    else{
      Console.WriteLine("wrong input");
    }
    
  }
  static add(int a, int b){
      int c ;
      c=a+b;
      return c;
    }
    static diff(int a , int b){
      int c;
      c=a-b;
      return c;
    }
    static multiply(int a , int b){
      int c;
      c=a*b;
      return c;
    }
    static division(int a , int b){
      int c;
      c=a/b;
      return c;
    }
}
