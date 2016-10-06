using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Xml;

public class SoundController : MonoBehaviour {

	AudioSource audioSource;
	Dictionary<string, AudioClip[]> soundDict;
	public TextAsset soundsSource;


	void LoadDictionary() {
		string tag;
		AudioClip[] sounds;
		int index;
		XmlDocument xml = new XmlDocument();
		xml.LoadXml(soundsSource.text);
		soundDict  = new Dictionary<string, AudioClip[]>();
		XmlNodeList resources = xml.SelectNodes("sounds/soundType");
		foreach (XmlNode node in resources){
			tag = node.Attributes["name"].Value;
			index = 0;
			sounds = new AudioClip[node.ChildNodes.Count];
			foreach (XmlNode childNode in node.ChildNodes) {
				sounds[index] = Resources.Load(childNode.InnerText) as AudioClip;
				index++;
			}
			soundDict.Add(tag, sounds);
		}
	}

	void Start () {
		audioSource = GetComponent<AudioSource>();
		LoadDictionary();
	}
	
	void MakeSound(string soundType) {
		/*Reproduces a random sound of the given type*/
		AudioClip[] sounds = soundDict[soundType];
		int clipIndex = UnityEngine.Random.Range(0, sounds.Length-1);
		audioSource.clip = sounds[clipIndex];
		audioSource.Play();
	}
}
