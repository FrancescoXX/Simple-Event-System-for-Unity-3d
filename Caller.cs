using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Caller.cs
public class Caller : MonoBehaviour {

	public void OnClickStartButton(){
    Publisher.i.CallStartGame();
  }
}