using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberOfObjects : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _red;
    [SerializeField]
    private TextMeshProUGUI _green;
    [SerializeField]
    private TextMeshProUGUI _yellow;
    
    public int Green = 0;
    public int Red = 0;
    public int Yellow = 0;
    
    void Update()
    {
        _green.text = Green.ToString();
        _red.text = Red.ToString();
        _yellow.text = Yellow.ToString();
    }
}
