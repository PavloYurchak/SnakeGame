# 🐍 Snake Game (Console, C#)

An educational project for learning the basics of game development: game loop, input handling, terminal rendering, collisions, and class-based architecture.

---

## 🔧 Technologies

- 🎯 Language: C# (.NET 9)
- 🖥️ Platform: Console Application
- 🧰 IDE: Visual Studio / VS Code  
  ➤ Run via `dotnet run` in a terminal (CMD)

---

## 🧩 Game Elements

- 🧱 Wall: `#`
- 🐍 Snake: `O`
- 🍎 Apple: `@`

---

## 🕹️ Controls

- ⬆️ : Move up  
- ⬅️ : Move left  
- ⬇️ : Move down  
- ➡️ : Move right  
- ⛔ Collision with a wall or yourself ends the game

---

## 🔁 Main Features

- ✅ Real-time game loop (fixed FPS)
- ✅ Snake movement on a grid
- ✅ Randomly placed apples
- ✅ Self-collision and wall collision detection
- ✅ Console-based rendering with visible borders

---

## 📘 Methods

### 🔹 `Snake.Move(mapWidth, mapHeight): bool`
Moves the snake in its current direction.  
Returns `false` if it hits a wall.

### 🔹 `Snake.CheckApple(Point apple): bool`
Returns `true` if the snake's head touches the apple.

### 🔹 `Snake.Grow()`
Appends a new segment to the tail, increasing the snake’s length.

### 🔹 `Snake.Collisions(): bool`
Returns `true` if the snake's head collides with its body.

### 🔹 `Apple.GenerateNewPosition(int mapWidth, int mapHeight, List<Point> snake)`
Generates a new random position for the apple, avoiding snake body coordinates.

---

## 📈 Potential Improvements

- [ ] Add a start menu and replay option
- [ ] Track and display high scores
- [ ] Add animation and sound effects
- [ ] Create a scoreboard

---

## 🧠 Project Goals

This project was built to practice and understand:
- how the **game loop** works
- how **entities and objects** are structured in OOP
- how **input and game logic** interact
- how to perform **console rendering with precise control**
