using UnityEngine;

public class HelloWorldAndFibonacci : MonoBehaviour
{
    private int previousNumber = 0;
    private int currentNumber = 1;
    private int frameCount = 1;

    void Start()
    {
        Debug.Log("Hello, World!"); //Tulostaa syötteen

        while (previousNumber <= 1000) //Aloittaa while-silmukan, joka päättyy numeroon 1000
        {
            Debug.Log("Frame " + frameCount + ": " + previousNumber);

            int nextNumber = previousNumber + currentNumber;
            previousNumber = currentNumber;
            currentNumber = nextNumber;

            frameCount++;
        }
    }
}