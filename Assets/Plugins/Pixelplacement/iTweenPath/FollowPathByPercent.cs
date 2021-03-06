using UnityEngine;
using System.Collections;

public class FollowPathByPercent : MonoBehaviour
{	
	public string pathName;
	public float travelspeed;
	public float stepspeed;
	//public float travelSpeed;
	public string loopType;
	public float percentTraveled;
	void Start(){
		percentTraveled = percentTraveled / 100;
	}


	void Update() {
		percentTraveled += travelspeed;
		if (percentTraveled > 1) {
			percentTraveled = 0;
		}

		iTween.MoveUpdate(gameObject, iTween.Hash("position", iTween.PointOnPath(iTweenPath.GetPath(pathName), percentTraveled), "time", stepspeed));

	}
}


