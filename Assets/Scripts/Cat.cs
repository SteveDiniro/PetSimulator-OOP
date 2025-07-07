using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance (Cat inherits from Pet)
public class Cat : Pet
{
    public Cat(string name) : base(name) { }

    public override string Speak()
    {
        return $"{Name} says: Meow!";
    }
}

