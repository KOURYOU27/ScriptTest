using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public class Boss
    {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力

        private int mp = 53;

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }

        // mpを消費して魔法攻撃をするMagic関数
        public void Magic()
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

            if (mp < 5) {

                Debug.Log("MPが足りないため魔法が使えない。");

            }
        }

    }


    // Use this for initialization
    void Start () {

        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 逆順に表示
        for (int n = 4; n >= 0; n--)
        {
            Debug.Log(array[n]);
        }


        // Bossクラスの変数を宣言

        Boss lastboss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }


    }

    // Update is called once per frame
    void Update () {
        
    }
}
