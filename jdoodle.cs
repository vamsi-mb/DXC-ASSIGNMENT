using System;  
  public class Fibonacci  
   {  
     public static void Main(string[] args)  
      {  
        int preprev=0,prevs=1,next_term,i,number;    
        Console.Write("Enter the number of terms to display: ");    
        number = int.Parse(Console.ReadLine()); 
        Console.WriteLine("The Fibonacci Sequence is the series of numbers:" );
        Console.Write("{0},{1}",preprev,prevs);   
        for(i=2;i<number;i++)    
        {    
         next_term=preprev+prevs;    
         Console.Write(",{0}",next_term);    
         preprev=prevs;    
         prevs=next_term;    
        }    
      }  
    }