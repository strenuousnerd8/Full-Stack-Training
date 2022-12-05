using System;
class Hello {
    int[, ] data = new int[5, 5];
      
    public int this[int index1, int index2]
    {
        get 
        {
            return data[index1, index2];
        }
        set 
        {
            data[index1, index2] = value;
        }
    }
}

class Test {
      
    public static void Main(String []args)
    {
        Hello index = new Hello();
          
        index[0, 0] = 1;
        index[0, 1] = 2;
        index[0, 2] = 3;
          
        index[1, 0] = 4;
        index[1, 1] = 5;
        index[1, 2] = 6;
          
        index[2, 0] = 7;
        index[2, 1] = 8;
        index[2, 2] = 9;
      
        Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}",
                                  index[0, 0], index[0, 1], index[0, 2],
                                  index[1, 0], index[1, 1], index[1, 2], 
                                  index[2, 0], index[2, 1], index[2, 2]);
      
    }
}