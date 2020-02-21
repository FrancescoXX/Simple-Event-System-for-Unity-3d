using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Subscriber1.cs
public class Subscriber1 : MonoBehaviour {

  private void OnEnable() {
    Publisher.i.StartGame += OnStartGame;
  }

  private void OnStartGame() {
    Debug.Log("Game is started, disable menu panel and enable match panel");
  }

  private void OnDisable() {
    Publisher.i.StartGame -= OnStartGame;   
  }
}