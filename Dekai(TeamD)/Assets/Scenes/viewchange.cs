﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;
using UnityEngine.UI;

public class viewchange : MonoBehaviour
{
    //ゲームオブジェクト、ボタンの設定
    public GameObject North, East, South, West;
    public Button Left, Right;

    int compass = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //ボタンの有効・無効設定
        North.SetActive(true);
        East.SetActive(false);
        South.SetActive(false);
        West.SetActive(false);
        //ボタンを押したときの動作
        Left.onClick.AddListener(Left_Click);
        Right.onClick.AddListener(Right_Click);
    }

    // Update is called once per frame
    void Update()
    {
        
     
    }
    //ボタンを押したらどうなるか
    private void Left_Click()
    {
        compass = (compass + 3) % 4;
        CompassCheck();
    }
    private void Right_Click()
    {
        compass = (compass + 1) % 4;
        CompassCheck();
    }
    //コンパスを確認して向きを変えたい
    private void CompassCheck()
    {
        switch (compass)
        {
            case 0:
                North.SetActive(true);
                East.SetActive(false);
                South.SetActive(false);
                West.SetActive(false);
                Debug.Log("North");
                break;
            case 1:
                North.SetActive(false);
                East.SetActive(true);
                South.SetActive(false);
                West.SetActive(false);
                Debug.Log("East");
                break;
            case 2:
                North.SetActive(false);
                East.SetActive(false);
                South.SetActive(true);
                West.SetActive(false);
                Debug.Log("South");
                break;
            case 3:
                North.SetActive(false);
                East.SetActive(false);
                South.SetActive(false);
                West.SetActive(true);
                Debug.Log("West");
                break;
        }
    }
}
