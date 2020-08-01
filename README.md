# Unity-2018-Fundamentals-Tony-Kim (Creating a Third Person Game)
This repository contains assets I created studying Unity with Unity 2018 Fundamentals in Pluralsight, a lecture provided by Joshua Kinney.  
The Third Person Game prototype I made includes following features listed below.

## What's Included
 Content | Detail 
 ---|---
Player Control | NavMeshAgent 
| | Animator Controller(Blend Tree) 
| | Player Controller(C# Script) 
Mouse Manager | Player moves to the clicked point. (C# Script)
| | Changing cursor images depending on what it's pointing at. (C# Script)
| | Triggering event when a tagged object is clicked. (C# Script)
NavMesh (Navigation) | [NavMeshComponents](https://github.com/Unity-Technologies/NavMeshComponents) 
NPC Patrol & Chase Behavior | NavMeshAgent |
| | Animator Controller(Blend Tree)
| | NPC Controller(C# Script): NPC patrols from a waypoint to another, and chases the player if the player is within a certain range.
Level Design | Using environment assests(fbx, material, texture, etc): Rigidbody, Collider, 
| | Light(Skybox, Point Light, Directional Light, Reflection Probe)
| | Particle System(Creating fire, fog)
| | Audio
UI | Start Screen(TextMeshPro, Button, Image)
| | Switching scenes from one to another (C# Script)
Post Processing | Post Processing stack 2.3.0v
Cinemachine | Cinemachine 2.6.0v 
| | Virtual Camera: Creating a camera that follows the player character.

### Start Screen
![image](https://user-images.githubusercontent.com/60923302/89005507-9a19bd80-d33f-11ea-9920-eb1942b99822.png)
Click the play button and the game starts.

### Game Screen
![image](https://user-images.githubusercontent.com/60923302/89010015-c5ed7100-d348-11ea-80b2-b1647559c851.png)
* NPC patrols from waypoints to waypoints, chases the player character if it's within a certain range.
* The player can move the player character by clicking the clickable objects.
* The camera follows the player character.
