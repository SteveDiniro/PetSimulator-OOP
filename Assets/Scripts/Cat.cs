using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE: Cat inherits from Pet
public class Cat : Pet
{
    public Cat(string name) : base(name) { }

    // POLYMORPHISM - child class overrides the parent class
    public override string Speak()
    {
        return $"{Name} says: Meow!";
    }
}

