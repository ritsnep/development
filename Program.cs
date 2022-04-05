using System;
    class Program
    {
        static void Main1()
        {
            byte a = 34; //smallest size only holds max 250
            short b =9999; 
            int c=1234567891;
            long d=01234567890123456790;
            float e=0123456789012346578901234567890123465789.0123467890123465798012345678901234679012346579f;
            double f=01234567890123456789.0001323;
            decimal g=111.1234m;
            //characters
            char h='a';
            //boolean 
            Boolean i=true;
            //reference
            string j= "asdfas";
            object k=true; //any type is used
            ///classes
            Program ABC=new Program();
            }
        // Fuctions
        (float,string,char) GetNumber(int x, string j)
        {
            return (123.12f,"abc",'a');
            
        }


    }
