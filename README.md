# Doggy Dodge 3D

Welcome to the Doggy Dodge 3D game repository! This Unity game challenges players to control a character to dodge incoming balls and launch adorable dogs into the sky. The game features a dynamic 3D environment and engaging mechanics. Let's delve into the details.

## Table of Contents

- [Overview](#overview)
- [Game Mechanics](#game-mechanics)
- [How to Play](#how-to-play)
- [Scripts](#scripts)
- [Contributing](#contributing)
- [License](#license)

## Overview

Doggy Dodge 3D is a Unity game where players navigate a 3D environment, dodging incoming balls and launching dogs into the air. The game offers an immersive experience with simple yet entertaining gameplay.

## Game Mechanics

The game includes the following key mechanics:

- **Spawn Management:** Balls are spawned at random intervals from the top of the 3D play area.
- **Dog Launch:** Players can launch their pet dogs into the air using the spacebar. Dogs can only be launched when positioned at the spawn origin.
- **Collision Detection:** Collisions with balls trigger their destruction, providing a satisfying experience for the player.
- **Destruction Limits:** Both balls and dogs are destroyed if they go beyond specific positional limits in the 3D space.

## How to Play

1. **Navigate 3D Space:**
   - Use the arrow keys or A/D keys to move your character left or right in the 3D environment.

2. **Launch Dogs:**
   - Press the spacebar to launch your adorable pet dog into the 3D sky. Launch dogs strategically, considering their position.

3. **Dodge Balls:**
   - Maneuver your character to dodge incoming balls and avoid collisions.

## Scripts

### 1. `DestroyOutOfBoundsX.cs`

This script manages the destruction of game objects (both balls and dogs) if they go beyond specified positional limits in the 3D space.

### 2. `DetectCollisionsX.cs`

Handles the detection of collisions, destroying the game object upon contact with another collider.

### 3. `MoveForwardX.cs`

Moves game objects forward in the 3D space at a specified speed.

### 4. `PlayerControllerX.cs`

Manages the player's ability to launch their dog into the 3D space using the spacebar. It also controls the position of the dog.

### 5. `SpawnManagerX.cs`

Controls the spawning of balls at random intervals and random positions at the top of the 3D play area.

## Contributing

If you're interested in contributing to the Doggy Dodge 3D game, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push to your fork and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE), allowing for both personal and commercial use.

Feel free to reach out with any questions, feedback, or suggestions.

Enjoy playing and developing Doggy Dodge 3D!
