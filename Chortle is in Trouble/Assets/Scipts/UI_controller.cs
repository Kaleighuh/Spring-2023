using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_controller : MonoBehaviour
{
    Player player;
    Text distanceText;
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        //distanceText = GameObject.Find("Distance Text").GetComponent<Text>();
    }
    void Start()
    {
        
    }
    void Update()
    { 
        int distance = Mathf.FloorToInt(player.distance);
        //distanceText.text = distance + " m";
    }
}
