using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessGame : MonoBehaviour
{
    //varibales for the guess game
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //reset the variables
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Guessing Game.");
        Debug.Log("Choose a number, but keep it to yourself.");
        Debug.Log("The highest number possible is " + max);
        Debug.Log("The lowest number possible is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up Arrow = Higher, Push Down Arrow = Lower, Push Enter = Correct Guess");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Debug.Log("Up Arrow was pressed.");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow was pressed.");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed.");
            Debug.Log("Your number was " + guess);
            Debug.Log("Thanks for playing. Play again.");
            StartGame();
        }

    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess);
    }
}
