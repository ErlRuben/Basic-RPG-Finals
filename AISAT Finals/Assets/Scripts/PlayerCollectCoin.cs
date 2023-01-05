using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollectCoin : MonoBehaviour {


    
    
    private GUIStyle guiStyle = new GUIStyle();

    public int points = 0;

   
    


    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnGUI()
    {
        guiStyle.fontSize = 50;
        

        GUI.Label(new Rect(20, 20, 200, 40), "Coins : " + points, guiStyle);
    }
        

}
