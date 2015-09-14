using UnityEngine;
using System.Collections;
using Soomla.Profile;

public class Login : MonoBehaviour{

	void Start() 
	{

	}
	public void LoginFB() 
	{
		SoomlaProfile.Login (Provider.FACEBOOK, "", null);
	}
	

}
