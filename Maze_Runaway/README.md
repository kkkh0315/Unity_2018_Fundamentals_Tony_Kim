# Studying Unity: Maze_Runaway
This repository contains what I studied after finishing my [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals).  
Please refer to [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals) for the fundamental Unity features I studied before starting this project.

## What was included in [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals) 
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

## What's Included
 Content | Detail 
 ---|---
Player Control | [PlayerController.cs](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/PlayerController.cs)
| | Healthbar System: [Healthbar](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/Healthbar.cs), [HealthPotion](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/HealthPotion.cs)
| | Singleton Pattern
Item | [TreasureChests](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/TreasureChest.cs): When pressing spacebar near treasure chests, the chest opens and a key pops out.
| | [Keys](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/Key.cs): When pressing spacebar near a key, the key disappears from the screen, the character obtains the key which is shown in the inventory.
Weapon | [Weapons](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/Weapon.cs): The character can give an enemy some damage when a weapon collides with the enemy due to the swinging animation.
Enemy | [EnemyController](https://github.com/kkkh0315/Unity_Tony_Kim/blob/master/Maze_Runaway/Assets/Scripts/EnemyController.cs)
| | Health system updated. The enemy dies(with an animation) when the heatlh reaches 0.
| | Attacking system updated. When the enemy reaches the main character, it starts to attack(with an animation).
Level Design | Using environment assests(fbx, material, texture, etc) 
| | Light(Skybox, Point Light, Directional Light, Reflection Probe)
| | Particle System(Creating fire, fog)
| | The map is a maze.

## Reminder
This project is for studying basic features of Unity and Unity C# Scripts. Thus, it's not for making a game.
