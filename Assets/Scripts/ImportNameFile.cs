using UnityEngine;
using System.Collections.Generic;

public class ImportNameFile : MonoBehaviour {

	public TextAsset dataFile;

	//way too many lists.  Not elegant at all, but should work
	public static string[] productNames;
	public static List<string> productNameList;
	public static List<string> usedNameList;
	public static Dictionary<string , GameObject> productCatalog; 
	public static Dictionary<GameObject, string> inverseProductCatalog; 


	//setup product names before initializing game objects
	void Awake() {
		productNames = dataFile.text.Split('\n');

		productNameList = new List<string>();
		usedNameList = new List<string>();


		for (int i=0;i<productNames.Length ; i++){
			productNameList.Add (productNames [i]);
		}
		productCatalog = new Dictionary <string , GameObject>();
		inverseProductCatalog = new Dictionary <GameObject, string>();

	}		
}
