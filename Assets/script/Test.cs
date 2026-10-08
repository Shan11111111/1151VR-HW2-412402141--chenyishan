
using UnityEngine;
using UnityEngine.Rendering;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void attack()
    {
        Debug.Log("造成" + this.power + "點傷害");
    }

    public void Demage(int demage)
    {
        this.hp -= demage;
        Debug.Log("受到" + demage + "點傷害");
    }

}


public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      initialIntroduction(0);
      Debug.Log("Hello World.");

      int[] array = new int[5];

       array[0] = 2;
       array[1] = 3;
       array[2] = 4;
       array[3] = 5;
       array[4] = 6;
       
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 startPos = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        Player myPlayer = new Player();
        myPlayer.attack();
        myPlayer.Demage(30);
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
