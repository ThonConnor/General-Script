using UnityEngine;
using System.Collections;

public class CountAlpha : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] test = {"C","B","A","A","A","B","B"};
		CountDuplicate(test);
	}

	void CountDuplicate(string[] test)
	{
		int count = 1;
		string temp = "";
		for (int i = 0; i < test.Length; i++)
		{
			for (int j = i + 1; j < test.Length; j++)
			{
				if (test[i] != null)
				{
					temp = test[i];
					if (test[j] != null)
					{
						if (test[i] == test[j])
						{
							count++;
							test[j] = null;
						}
					}
				}
			}
			if (temp != "")
			{
				string result = temp + "-";
				for (int x = 1; x <= count; x++)
				{
					result += "*";
				}
				Debug.Log(result);
				temp = "";
				count = 1;
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
