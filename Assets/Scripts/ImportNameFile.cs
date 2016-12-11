using UnityEngine;
using System.Collections.Generic;

public class ImportNameFile : MonoBehaviour {

	public TextAsset dataFile;
	public static string[] productNames;
	public static Dictionary<string , GameObject> productCatalog; 
	public static Dictionary<GameObject, string> inverseProductCatalog; 

	void Start() {
		productNames = dataFile.text.Split('\n');

		productCatalog = new Dictionary <string , GameObject>();
		inverseProductCatalog = new Dictionary <GameObject, string>();

	}		
}
