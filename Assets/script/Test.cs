
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      initialIntroduction(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initialIntroduction(int state)
    {
        Debug.Log("Hello, World!");
        int life_time = 5;
        Debug.Log($"Life time is {life_time}");
        int die_time = 5 - life_time;
        Debug.Log($"Die time is {die_time}");

        string name = "John";
        Debug.Log($"My name is {name}");

        string str1 = "Mr.";
        string str2 = "Smith";
        string fullName = str1 + str2;
        Debug.Log($"Full name is {fullName}");
        str1 += str2;
        Debug.Log($"Full name is {str1}");
        int num = 123;
        string message = str2 + num;
        Debug.Log($"Message is {message}");

        if (life_time > 0)
        {
            Debug.Log("You alive.");
        }
        else
        {
            Debug.Log("You dead.");
        }

        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    }



}
