using UnityEngine;
using System.Collections;
using SimpleJSON;

public class Beacon {
	public int batteryLevel;
	public string iconURL;
	public string identifier;
	public string name;
	public int temperature;

	public Beacon(JSONNode node) {
		Deserialize(node);
	}

	private void Deserialize(JSONNode node) {
		batteryLevel = node ["batteryLevel"].AsInt;
		iconURL = node["iconURL"].Value;
		identifier = node["identifier"].Value;
		name = node["name"].Value;
		temperature = node["temperature"].AsInt;
	}            
}