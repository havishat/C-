using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }



  static void SelectionSort(string[] a){
    string min = null;
    int min =0;
    for(int place = 0; place < a.Length - 1; place++){
      string min = null;
      int min = 0;
      for(int test = place; test < a.Length; test++){
        if(a[min].CompareTo(a[test]) > 0){
          min = test;
        }
      }
      //swap 

      String temp = a[min];
      a[min] = a[place];
      a[place] = temp;


    }
  }
}