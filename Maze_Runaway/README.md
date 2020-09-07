# Studying Unity: Maze_Runaway
This repository contains what I studied after finishing my [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals)  
Features included in [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals) are not descripted in this README.  
Please refer to [Pluralsight Unity 2018 Fundamentals: Studying Unity for the First Time](https://github.com/kkkh0315/Unity_Tony_Kim/tree/master/Pluralsight%20Unity%202018%20Fundamentals) for basic components like Mouse Manager, NavMesh, UI, Post Processing, Cinemachine, etc.

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
