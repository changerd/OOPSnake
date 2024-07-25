# OOPSnake

**OOPSnake** is a console-based Snake game implemented in C#. This project serves as a practical example of object-oriented programming principles, demonstrating how to manage game state, handle user input, and implement game mechanics.

## Features

- **Snake Movement**: Control the snake using arrow keys to navigate the console window.
- **Food Consumption**: Eat food to grow the snake and increase the score.
- **Collision Detection**: The game ends when the snake collides with the walls or itself.
- **Dynamic Walls**: Walls are represented as lines drawn at the edges of the console window.

## How It Works

- **Console Window Setup**: The game runs in an 80x25 console window with adjustable buffer size.
- **Game Entities**: The game includes the snake, food, and walls, each managed by its respective class:
  - `Snake`: Handles movement, growth, and collision detection.
  - `FoodCreator`: Generates food items at random positions.
  - `Walls`: Creates and manages the boundaries of the game.
- **Game Loop**: The main game loop checks for collisions, processes user input, and updates the game state at regular intervals.

## Getting Started

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/changerd/OOPSnake
   ```
2. **Open the Project**:
Open the OOPSnake project in Visual Studio or any C# compatible IDE.
3. **Build and run**:
Build the project and run the application to start playing the game in the console window.

## Gameplay
- Use the arrow keys to control the direction of the snake.
- Eat the food (represented by $) to grow the snake.
- Avoid collisions with the walls and the snake's own body.
- The game ends when the snake crashes into the walls or itself.
  
   
   
