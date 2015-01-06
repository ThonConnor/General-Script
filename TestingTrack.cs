using UnityEngine;
using System.Collections.Generic;

public class TestingTrack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RemoveDuplicate(new List<string>() { "A", "B", "A", "C", "B", "A", "C", "B", "A", "C" });
	}

	void RemoveDuplicate(List<string> lst)
	{
		if (lst != null && lst.Count > 0)
		{
			for (int i = 0; i < lst.Count-1; i++)
			{
				for (int j = i + 1; j < lst.Count; j++)
				{
					if (lst[i] == lst[j])
					{
						Debug.Log("Remove:" + lst[j]);
						lst.RemoveAt(j);
						RemoveDuplicate(lst);
						return;
					}
				}
			}

			foreach (string t in lst)
			{
				Debug.Log(t);
			}
		}
	}
}
