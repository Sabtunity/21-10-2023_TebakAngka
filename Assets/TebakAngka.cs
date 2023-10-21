// #include <iostream>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class TebakAngka : MonoBehaviour
{   
    int soal;
    int playerInput;

    public TMP_InputField playerInputField;
    public TextMeshProUGUI hasilText;


    void Start()
    {
        soal = Random.Range(0, 1000);
    }



    void Update()
    {
        // cout << soal;
        Debug.Log(soal);

        //  cin >> playerInput;
        int.TryParse(playerInputField.text, out playerInput);

        // if (playerInput < soal)
        if (playerInput < soal) {
            // cout << "Tebakan kurang\n";
            Debug.Log("Tebakan kurang");
            hasilText.text = "Tebakan kurang";
        }
        // else if (playerInput > soal)
        else if (playerInput > soal) {
            // cout << "Tebakan lebih\n";
            Debug.Log("Tebakan lebih");
            hasilText.text = "Tebakan lebih";
        }
        // else
        else {
            // cout << "Benarr!\n";
            Debug.Log("Benarr!");
            hasilText.text = "Benarr!";
            Application.Quit();
        }
    }
}
