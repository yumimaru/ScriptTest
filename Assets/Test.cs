﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//個数が5のint型の配列arrayを宣言
		int[] array = new int[5];

		//配列の各要素の値を順番に表示
		array [0] = 7;
		array [1] = 8;
		array [2] = 9;
		array [3] = 10;
		array [4] = 11;

		//for文で配列の各要素の値を逆順に表示
		//初期値は最後の4からスタート
		for (int i = 4; i < array.Length; i--) {
			Debug.Log (array [i]);
	}
	}

	// Update is called once per frame
	void Update () {

	}
}