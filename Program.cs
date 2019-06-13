﻿using System;
using System.Collections;

namespace pratical
{
    class phonebook
    {
        static void Main(string[] args)
        {
            bool running = true;
            int choosed ;
            mainAction aciton = new mainAction();
            while (running)
            {
                Console.WriteLine("chọn số từ 1-4: ");
                Console.WriteLine("1: thêm liên hệ");
                Console.WriteLine("2: tìm liên hệ bằng tên");
                Console.WriteLine("3: hiển thị toàn bộ liên hệ");
                Console.WriteLine("4: thoát \n");
                try {
                    String choosedS = Console.ReadLine();
                    choosed = Int.Parse(choosedS); 
                } catch(FormatException){
                    Console.WriteLine("chỉ chọn số từ 1-4");
                    continue;
                }
                

                switch(choosed){
                    case 1 :
                        aciton.Add();
                        break;
                    case 2 :
                        aciton.find();
                        break;
                    case 3 :
                        aciton.display();
                        break;
                    case 4 :
                        running = false;
                        break;
                    default :
                        Console.WriteLine("đầu vào không thỏa mãn");
                        break;
                }
            }

        }
    }

    class mainAction
    {
        Hashtable contactTable= new Hashtable();
        public mainAction()
        {
        }

        public void Add(){
            Console.WriteLine("nhập tên: ");
            String conTactName = Console.ReadLine();
            Console.WriteLine("nhập số điện thoại: ");
            String phoneNumber = Console.ReadLine();
            this.contactTable.Add(conTactName,phoneNumber);
        }
        public void find(){
            String conTactName = Console.ReadLine();
            if (this.contactTable.ContainsKey(conTactName))
            {
                Console.WriteLine(conTactName + ": "+this.contactTable[conTactName]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public void display(){
            ICollection key = this.contactTable.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + this.contactTable[k]);
            }

        }
    }
}


