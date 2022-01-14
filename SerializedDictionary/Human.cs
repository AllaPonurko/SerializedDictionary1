using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace SerializedDictionary
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NewHumanAttribute:Attribute
    { 
       INIManager manager;
       Human human=new Human();
        public string GetHumanName()
        {
            human.Name = manager.GetPrivateString("main", "name");
            return human.Name;
        }
        public int GetHumanAge()
        {
            human.Age = Convert.ToInt32(manager.GetPrivateString("main", "age"));
            return human.Age;
        }
        public int GetHumanId()
        {
            human.Id = Convert.ToInt32(manager.GetPrivateString("main", "id"));
            return human.Id;
        }
        public NewHumanAttribute(string path)
        {
            manager = new INIManager(path);
        }
    }
    
    
    public class Human
    {
        public Human() { }
        
        public int Age { get; set; }
        
        public string Name { get; set; }
        
        public int Id { get; set; }
        public Human(string _name,int _age,int _id)
        {
            Name = _name;
            Age = _age;
            Id = _id;
        }
        public override string ToString()
        {
            return ($"{Id} " + $"{Name}" + $" {Age}");
        }
    }
}
