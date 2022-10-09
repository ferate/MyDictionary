// See https://aka.ms/new-console-template for more information
using MyDictionary;

Console.WriteLine("Hello, World!");

MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
myDictionary.Add(1, "Ferat EFİL");
myDictionary.Add(2, "Bahadır EFİL");

Console.WriteLine("Eklenen Eleman Sayısı : "+ myDictionary.Count);

Console.WriteLine("Eklenen Elemanlar");

myDictionary.ShowList();