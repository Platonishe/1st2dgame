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
        Debug.Log("��� ��� - " + name + ", ��� ���� -" + height + ",  ��� " + age + "���, � ���� " + weight + "��������� � ����� ����� ������ �����" + tall_length + "�����������");
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