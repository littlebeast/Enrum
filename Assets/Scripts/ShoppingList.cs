using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShoppingList : MonoBehaviour {

	bool firstTime = true;
	public static Dictionary<string , bool> myList;
	public static double bankAccount = 25000;
	Text text;

	void Awake(){
		text = GetComponent <Text> ();
	}

	void Update() {
		//hopefully this will run after all furniture objects have called their Start initialization functions
		if (firstTime){

			myList = new Dictionary<string , bool>();
			int numProducts =ImportNameFile.usedNameList.Count;

			Debug.Log ("number of products");
			Debug.Log (numProducts);
			//Debug.Log ("Shopping list:");
			while( myList.Count <6){
				//randomly pick things to buy
				int randomIndex = (int)Mathf.Floor (Random.Range (0, numProducts));
				string objectName = ImportNameFile.usedNameList [randomIndex];
				if (!myList.ContainsKey (objectName)) {
					myList.Add (objectName, false);
					text.text = text.text + "\n" + objectName;
				}
				//Debug.Log (objectName);
			}
			firstTime =false;
		}



	}		
}


