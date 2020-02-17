using UnityEngine;
using System.Collections;

public class Lesson4_array : MonoBehaviour {

    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化。
        int[] array = { 1, 20, 300, 4000, 50000 };

        Debug.Log("順番に表示");

        //配列の要素数を順番に表示。
        for (int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
        }

        Debug.Log("逆順に表示");

        //配列の各要素を逆順に表示。
        for (int i = array.Length - 1; i >= 0; i--){
            Debug.Log(array[i]);
        }
    }
}