# UnitySoundController

A simple wrapper that simplifies sound effects managing in Unity 3D.

Configuration:

1. Copy "SoundController" in your Scripts folder.
2. Add "SoundController" and an empty "AudioSource" component to your GameObject.
3. Copy you sounds clips into a "Resources" folder.
4. Create the XML audio source. Check "sourceExample.xml" for more information.
5. Using the Inspector, attach the file created in the step 4 to "SoundController".

Usage:

1. Get a reference to the "SoundController" component (gameObject.GetComponent<SoundController>())
2. Call the method "MakeSound(string sound)". The string "sound" must be define inside the XML, as a "name" attribute of the "soundType" tag.
3. Your buddy "MakeSound" will choose a random sound for you from the specified in the XML, and play it! :D

EXTRA: Create an string enum to hide the concrete strings!
