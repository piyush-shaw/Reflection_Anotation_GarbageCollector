﻿using System;
namespace ReflectionDemo
{
    class CustomerInfo : Object
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public int MyProperty { get; set; }
        public CustomerInfo(int id, string name)
        {
            this.ID = id;
            this.ClassName = name;
        }
        public CustomerInfo()
        {
            this.ID = -1;
            this.ClassName = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("id " + this.ID);
        }
        public void PrintName()
        {
            Console.WriteLine("id " + this.ClassName);
        }
    }

}

