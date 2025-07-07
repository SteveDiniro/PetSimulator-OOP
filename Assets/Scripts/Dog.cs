using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    public Dog(string name) : base(name) { }

    public override string Speak()
    {
        return $"{Name} says: Woof!";
    }
}
