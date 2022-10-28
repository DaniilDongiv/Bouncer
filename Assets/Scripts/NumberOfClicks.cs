using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberOfClicks : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _click;
    
    public int Click = 0;
    
    void Update()
    {
       _click.text = Click.ToString();
    }
}
