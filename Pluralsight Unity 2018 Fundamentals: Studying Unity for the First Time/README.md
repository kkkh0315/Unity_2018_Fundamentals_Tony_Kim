# Studying Unity for the First Time(Creating a Third Person Game)
* This repository contains the Unity project I made studying how to make a third person game in Unity.  
* Most, but not all, of the parts are created based on the lecture "Unity 2018 Fundamentals" provided by Pluralsight, lectured by Joshua Kinney.  
* Beginner level.

## What's Included
 Content | Detail 
 ---|---
Player Control | [NavMeshComponents](https://github.com/Unity-Technologies/NavMeshComponents): NavMeshAgent 
| | Animator Controller(Blend Tree) 
| | Player Controller(C# Script): **GetComponent, SetFloat, GetKeyDown, KeyCode, OnCollisionEnter**
Mouse Manager | Player moves to the clicked point. (C# Script): **GetMouseButtonDown, Serializable, EventVector3**
| | Changing cursor images depending on what it's pointing at. (C# Script): **Raycast, RaycastHit, Cursor.SetCursor**
| | Triggering event when a tagged object is clicked. (C# Script): **Debug.Log**
NavMesh (Navigation) | [NavMeshComponents](https://github.com/Unity-Technologies/NavMeshComponents) 
NPC Patrol & Chase Behavior | [NavMeshComponents](https://github.com/Unity-Technologies/NavMeshComponents): NavMeshAgent
| | Animator Controller(Blend Tree)
| | NPC Controller(C# Script): **InvokeRepeating, Vector3.Distance, Array**
Level Design | Using environment assests(fbx, material, texture, etc): Rigidbody, Collider, 
| | Light(Skybox, Point Light, Directional Light, Reflection Probe)
| | Particle System(Creating fire, fog)
| | Audio
UI | Start Screen(TextMeshPro, Button, Image)
| | Switching scenes from one to another (C# Script): **UnityEngine.SceneManagement, SceneManager.LoadScene**
Post Processing | Post Processing stack 2.3.0v
Cinemachine | Cinemachine 2.6.0v 
| | Virtual Camera: Creating a camera that follows the player character.

Move to [C# Scripts](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals/Assets/Scripts)

### Start Screen
![image](https://user-images.githubusercontent.com/60923302/89005507-9a19bd80-d33f-11ea-9920-eb1942b99822.png)
Click the play button and the game starts.

### Game Screen
![image](https://user-images.githubusercontent.com/60923302/89010015-c5ed7100-d348-11ea-80b2-b1647559c851.png)
* NPC patrols from waypoints to waypoints, chases the player character if it's within a certain range.
* The player can move the player character by clicking the clickable objects.
* The camera follows the player character.
