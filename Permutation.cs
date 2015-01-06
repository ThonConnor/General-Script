using UnityEngine;
using System.Collections;

public class Permutation : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		int[] test = {1,2,3};
		int n = test.Length;
		Permuta(test, n, 0);
	}
	void Permuta(int[] v, int n, int i)
	{
		int j = 0;
		if (i == n)
		{
			Msg(v);
		}
		else
		{
			for (j = i; j < n; j++)
			{
				Swap(v, i, j);
				Permuta(v, n, i + 1);
				Swap(v, i, j);
			}
		}
	}

	void Swap(int[] v, int i, int j)
	{
		int temp = v[i];
		v[i] = v[j];
		v[j] = temp;
	}
	void Msg(int[] t)
	{
		string result = "";
		foreach (int v in t)
		{
			result += v + "  ";
		}
		Debug.Log(result);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
