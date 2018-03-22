using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour {
	/*Twitter Variables*/

	//Twitter Share Link
	string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";

	//Language
	string TWEET_LANGUAGE ="en";

	//This is the text which you want to show
	string textToDisplay = "Hey Guys! Check out my score: ";

	/* End of Twitter Variables*/

	// Use this for initialization
	public void shareScoreOnTwitter () {
		Application.OpenURL(TWITTER_ADDRESS+"?text=" + WWW.EscapeURL(textToDisplay) + Scoreboard.S.score + "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
