using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AppManage : MonoBehaviour {

	public GameObject ball;
	
	// Use this for initialization
	void Start () {

		makeBall ();
	
	}

	void makeBall(){

		if(ball == null)
        {
			return;
        }

		// make rand pos
		Vector3 pos = new Vector3 (Random.Range (-4.0f, 4.0f), Random.Range (3.0f, 8.0f), Random.Range (-4.0f, 4.0f) );
		GameObject b = (GameObject)Instantiate(ball,
		            pos,
		            Quaternion.identity);

	}

	// Update is called once per frame
	void Update () {

		if (Time.frameCount % 5 == 0){
			makeBall ();
		}

	}
	
}
