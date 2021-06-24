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
    }
    
    public void Mew()
    {
        Debug.Log("ћое им€ - " + name + ", мой рост -" + height + ",  мне " + age + "лет, € вешу " + weight + "килограмм и длина моего хвоста целых" + tall_length + "сантиметров");
    }

    private void Start()
    {
        Cat cat = new Cat();
        cat.name = "Barsik";
        cat.height = 35;
        cat.age = 5;
        cat.weight = 3;
        cat.tail_length = 20;
        cat.Mew();
    }
       
        
    








}  