/*
Author          : Sr Programmer Analyst Oleg Gorlov
Description:	: Assigment 
Copyright       : GMedia-IT-Consulting 
email           : oleg_gorlov@yahoo.com
Date            : 03/11/2018
Release         : 1.0.0
Comment         : 
1) Write a function that reverses the order of words of a sentence.
2) Create your own class or a set of functions that implement a stack. 

    Include the following four methods:a. Push: Adds a data element to the top of the stackb. 
    Pop: Removes a data element from the top of the stackc. 
    Size: Returns the total number of elements in the stackd. 
    isEmpty: Returns true if the stack is empty.Insert your answer here

3) Write a function f(a, b) which takes two character string arguments and returns a string containing only the characters found in both strings.

 */
using System;
using System.Collections.Generic;
using System.Text;
using SmartSystems;

public class programm
{
    static void Main(string[] args)
    {

        //string st_Original = "Able was I ere I saw elba";
        string st_Original = "kayaka";

        StringUtils su = new StringUtils();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Is sub1 equal to sub2?: {0}", su.IsMirrorSequence(st_Original));
        Console.WriteLine("Is string of MirrorSequence pattern ?: '{0}' ", su.IsMirrorSequence(st_Original));

        Console.ReadLine();

        Console.ReadKey();

    }
}
