using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP : MonoBehaviour
{
    class Cat
    {
        public string name;
        public int age;
        public int weight;
        public int height;
        public int tail_length;

        public Cat()
        {
            name = "Barsik";
            height = 35;
            age = 5;
            weight = 3;
            tail_length = 20;
        }

        public Cat(string name, int age, int weight, int height, int tail_length)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.tail_length = tail_length;
        }


        public void Mew()
        {
            Debug.Log("ћое им€ - " + name + ", мой рост -" + height + ",  мне " + age + "лет, € вешу " + weight + "килограмм и длина моего хвоста целых" + tail_length + "сантиметров");
        }
    }

    private void Start()
    {
        //Cat cat = new Cat();
        //cat.name = "Barsik";
        //cat.height = 35;
        //cat.age = 5;
        //cat.weight = 3;
        //cat.tail_length = 20;
        //cat.Mew();

        //Dog dog = new Dog();
        //dog.name = sobaken;
        //dog.age = 5;
        //dog.height = 17;


        bus bus = new bus();
        bus.name = "avtobus";
        bus.Beep();

        car car = new car();
        car.name = "mashina";
        car.Beep();

        tractor tractor = new tractor();
        tractor.name = "tractor";
        tractor.Beep();




    }

    //class Dog
    //{
    //    public string name;
    //    public int age;
    //    public int height;
    //    public void Woof()


    //}

    private int age;

    public int getAge()
    {
        return age;
    }
  
    public void setAge(int value)
    {
        if (value >= 0 && value < 100)
        {
            age = value;
        }   
    }
    
   
    class Vehicle
    {
        public string name;
       
        public virtual void Beep()
        {
            Debug.Log("beep");
        }
    }

    class bus : Vehicle
    {
        public override void Beep()
        {
            Debug.Log("1");
        }
    }

    class car : Vehicle
    {
        public override void Beep()
        {
            Debug.Log("2");
        }
    }

    class tractor : Vehicle
    {
        public override void Beep()
        {
            Debug.Log("3");
        }
    }





}  