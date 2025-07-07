using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE: Dog inherits from Pet
public class Dog : Pet
{
    public Dog(string name) : base(name) { }

    // POLYMORPHISM - child class overrides the parent class
    public override string Speak()
    {
        return $"{Name} says: Woof!";
    }
}
