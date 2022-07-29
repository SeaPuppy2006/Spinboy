using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsMenu : MonoBehaviour
{
	
	private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
	
	public Text up, left, down, right, jump, action;
	
    // Start is called before the first frame update
    void Start()
    {
        keys.Add("Up", KeyCode.W);
		keys.Add("Down", KeyCode.S);
		keys.Add("Left", KeyCode.A);
		keys.Add("Right", KeyCode.D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
