using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	Label myLabel;
	Button myButton;

	private void OnEnable()
	{
		var uiDocument = GetComponet<uiDocument>();

		var root = uiDocument.rootVisualElement;

		myLabel = root.Q<Label>("myLebel");
		myButton = root.Q<Button>("myButton");
		myButton.clicked += MyButton_clicked;
	}
	private void MyButton_clicked()
	{
		myLabel.text = "게임 시작";
	}
}
