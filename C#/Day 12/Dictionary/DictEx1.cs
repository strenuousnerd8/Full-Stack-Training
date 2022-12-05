using System;
using System.Collections.Generic;  
  
class Hello {
    
    static public void Main () 
    {

        Dictionary<int, string> My_dict1 = new Dictionary<int, string>(); 
                       
          My_dict1.Add(1123, "Welcome");
          My_dict1.Add(1124, "to");
          My_dict1.Add(1125, "Dictionaries");
            
          foreach(KeyValuePair<int, string> ele1 in My_dict1)
          {
              Console.WriteLine("{0} and {1}",
                        ele1.Key, ele1.Value);
          }
          Console.WriteLine();
            
      Dictionary<string, string> My_dict2 =  
              new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "Pig"} }; 
           
          foreach(KeyValuePair<string, string> ele2 in My_dict2)
          {
              Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
          }
    }
}