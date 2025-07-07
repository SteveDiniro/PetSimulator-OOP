using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION (Pet is an abstractable base class, from with Cat & Dog are derived)
public class Pet
{
    private string name;
    private int happiness;

    // ENCAPSULATION with get\set
    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }

    public int Happiness
    {
        get { return happiness; }
        protected set
        {
            happiness = Mathf.Clamp(value, 0, 100);
        }
    }

    public Pet(string name)
    {
        Name = name;
        Happiness = 50;
    }

    public virtual string Speak()
    {
        return $"{Name} makes a noise.";
    }

    public void PetAnimal()
    {
        Happiness += 10;
    }
}

