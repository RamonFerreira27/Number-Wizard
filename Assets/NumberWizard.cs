using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000, min = 1, guess = 500;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Bem-vindo ao Number Wizard!");
        Debug.Log("Escolha um número");
        Debug.Log("O maior número que você pode escolher é " + max);
        Debug.Log("O menor número que você pode escolher é " + min);
        Debug.Log("Diga-me: seu número foi maior ou menor que " + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max++;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Então... seu número é " + guess + ", correto? ");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {          
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Então... seu número é " + guess + ", correto? ");
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Isso, eu já sabia que era esse número desde o início!!");
        }
    }
}
