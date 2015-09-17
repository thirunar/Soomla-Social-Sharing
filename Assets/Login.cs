using UnityEngine;
using System.Collections;
using Soomla.Profile;

public class Login : MonoBehaviour{

	void Start() 
	{

	}
	public void LoginFB() 
	{
		SoomlaProfile.Login (Provider.FACEBOOK);
	}

	public void SharePost() 
	{
		SoomlaProfile.UpdateStoryWithConfirmation (
			Provider.FACEBOOK,
			"My first post from app",
			"Post",
			"Hi",
			"Test Post",
			@"http://www.activatear.com",
			@"http://www.activatear.com/activatearvideos/raptor.jpg",
			"",
			null
		);
	}


	public void MultiShare() 
	{
		SoomlaProfile.MultiShare(
			"I'm happy. I can be shared everywhere."
			);
	}

}
