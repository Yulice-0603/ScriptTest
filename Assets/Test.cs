using System;
using System.Collections;
using UnityEngine;


//Bossクラス
public class Boss
{
    int mp = 53; //mpの初期化

    //Magic関数
    public void Magic()
    {
       
        //MPが足りて、魔法を使う場合
        if (this.mp >= 5)
        {
            this.mp -= 5; //MPを5点消費する
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);　
        }

        //MPが足りない場合
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss boss = new Boss();　//Bossクラスの変数を宣言してインスタンスを代入

        int[] array = { 10, 20, 30, 40, 50 }; //arrayの初期化

        //順番に表示
        for(int i=0; i<array.Length; i++)
        {
            Debug.Log(array [i]);
        }

        //逆順に表示
        for(int j= array.Length-1; j>=0; j--)
        {
            Debug.Log(array[j]);
        }

        //魔法を十回使う
        for (int n=1; n <= 10; n++)
        {
            boss.Magic();　
        }

        //mpが足りないメッセージを表示することの確認
        boss.Magic();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
