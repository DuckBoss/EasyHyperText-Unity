using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

public class EasyHyperText : MonoBehaviour {

	//Object Types (UI/Object)
	private enum HyperTextMode {
		UI,
		GameObject
	};

	//Methods of opening the URL depend on if the object is UI or a 3D Object.
	[SerializeField]
	private HyperTextMode Mode;

	//Link URL w/ default URL provided.
	[SerializeField]
	private string hyperlinkString = "http://www.google.com";

	//Set up click event for the text UI.
	//Check Unity Docs for more info on event triggers:
	//https://docs.unity3d.com/ScriptReference/EventSystems.EventTrigger.html
	private void Start() {
		if(Mode == HyperTextMode.UI) {
			//Warns the user if there is no EventTrigger present and then proceeds to add the EventTrigger component for the user.
			if(GetComponent<EventTrigger>() == null) {
				Debug.LogWarning("An Event Trigger Is Required For 'HyperText' Script To Run!\nAn Event Trigger Has Been Added For You.");
				this.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger trigger = GetComponent<EventTrigger>( );
			EventTrigger.Entry entry = new EventTrigger.Entry( );
			entry.eventID = EventTriggerType.PointerClick;
			entry.callback.AddListener( (data) => { OnPointerClickDelegate((PointerEventData) data); } );
			trigger.triggers.Add(entry);
		}
		else {
			//Add a mesh collider if the object doesn't have any colliders.
			//Preferably you would want to choose your collider to your specific purposes instead of
			//having the program generate one for you.
			if(GetComponent<Collider>() == null) {
				this.gameObject.AddComponent<MeshCollider>();
			}
		}
	}

	private void OnMouseDown() {
		if(Mode == HyperTextMode.GameObject) {
			//If the mode is set to GameObject, then execute the hyperlink.
			Hyperlink(hyperlinkString);
		}
	}

	//Delegate used for UI Click handling events.
	private void OnPointerClickDelegate(PointerEventData data) {
		Hyperlink(hyperlinkString);
	}

	//Hyperlink method takes a string URL parameter and opens it.
	private void Hyperlink(string link) {
		Application.OpenURL(link);
	}

}
