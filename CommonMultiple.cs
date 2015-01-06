using UnityEngine;
using System.Collections;

public class CommonMultiple : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(FindCommonMultiple(8, 9));
	}

	bool FindCommonMultiple(int num1, int num2)
	{
		int i = 1;
		while (true)
		{
			int temp = num1 * i;
			if (temp < (num1 * num2))
			{
				if ((temp % num2) == 0)
				{
					Debug.Log(temp);
					return true;
				}
			}
			else
			{
				return false;
			}
			i++;
		}

	}
}
