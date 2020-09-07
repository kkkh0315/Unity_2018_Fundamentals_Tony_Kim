# Studying Unity: Maze_Runaway
This repository contains what I studied after finishing my [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals)  
Features included in [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals) are not descripted in this README.  
Please refer to [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals) for basic components like Mouse Manager, NavMesh, UI, Post Processing, Cinemachine, etc.

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
