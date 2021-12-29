//CallBack 

//It is a function that will be called when a process is done executing a specific task.
//To create a callback you need to store  function address inside a variable and it is achived by using  delegate.


using System;

namespace ConsoleApp17
{
    class Program
    {
        //Method Signature is same(return type and parameter should be same)
        static void myCallBack(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            myCallBack obj = new myCallBack();
            obj.myDoAndDelay(myCallBack); 
        }

    }
    class myCallBack
    {
        public delegate void callBackPointer(int i);  //delegate function
        public void myDoAndDelay(callBackPointer NewObj)  // store function address inside a variable
        {
            for (int i = 0; i < 10; i++)
            {
                NewObj(i);
            }
            Console.ReadLine();
        }

       
    }
    
}

