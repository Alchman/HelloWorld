using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [Header("Colors")]
    public Color colorForTitle;

    [Header("UI Elements")]
    [Tooltip("Текст для заголовка")] public Text title;
    public Text gameText;
    public Image titleImage;

    [Header("Config")]
    public int min;
    public int max;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        title.text = "Magic Numbers";
        //title.color = Color.red;
        //title.fontSize = 10;
        //title.resizeTextForBestFit = false;

        titleImage.color = colorForTitle;

        print("Загадайте число от " + min + " до " + max);
        UpdateGuess();

    }

    public void Higher()
    {
        min = guess;
        UpdateGuess();
    }

    public void Lower()
    {
        max = guess;
        UpdateGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Higher();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Lower();
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("the end");
            gameText.text = "the end";
            Start();
        }
    }

    void UpdateGuess()
    {
        guess = (min + max) / 2;
        //print("Ваше число: " + guess + "?");
        gameText.text = "Ваше число: " + guess + "?";
    }
}
