# 🎮 Doofus Adventure Game

## 🎯 Overview
Doofus Adventure is a 3D platformer game where players guide a cube character named Doofus across disappearing platforms called Pulpits. The goal is to traverse as many platforms as possible without falling, targeting a minimum of 50 Pulpits.

## 🌟 Game Features
- 3D gameplay environment
- Dynamic platform generation
- Time-based platform destruction
- Score tracking system
- JSON-driven game configuration
- Multiple game screens (Start, Play, Game Over)

## 🎲 Gameplay Mechanics

### Main Character: Doofus
- Simple cube design
- Four-directional movement
- Controlled via arrow keys or WASD
- Speed parameters configured via JSON

### Pulpit Platforms
- 9x9 green metallic platforms
- Timed existence
- Random duration between y and z seconds
- Maximum of 2 platforms at once
- Dynamic adjacent spawning

## 🎮 Controls
- **Forward**: W or ↑
- **Backward**: S or ↓
- **Left**: A or ←
- **Right**: D or →

## 🏗️ Technical Implementation

### Core Systems
1. **Movement System**
   - Four-directional control
   - Velocity-based movement
   - Edge detection
   - Fall handling

2. **Platform Management**
   - Dynamic generation
   - Timer-based destruction
   - Position calculation
   - Adjacent placement logic

3. **Scoring System**
   - Platform traversal tracking
   - High score management
   - Score display

### Game States
1. **Start Screen**
   - Game introduction
   - Start button
   - Instructions display

2. **Main Gameplay**
   - Active platform tracking
   - Score counter
   - Timer display

3. **Game Over Screen**
   - Final score display
   - Restart option
   - High score showcase

## 🛠️ Technical Stack
- **Engine**: Unity 2022+
- **Development Language**: C#
- **Configuration**: JSON-based settings
- **3D Assets**: Public resources

## 📋 Development Levels

### Level 1: Core Mechanics
- [x] Character movement implementation
- [x] Platform generation system
- [x] JSON configuration integration
- [x] Basic physics implementation

### Level 2: Scoring System
- [x] Platform traversal detection
- [x] Score increment logic
- [x] Score display UI
- [x] Movement validation

### Level 3: UI/UX Implementation
- [x] Start screen design
- [x] Game over screen implementation
- [x] UI transitions
- [x] Player feedback systems

## 🔧 Technical Requirements
- Unity 2022 or newer
- JSON parsing capabilities
- 3D environment setup
- Physics system integration

## 📦 Project Structure
```
Assets/
├── Scripts/
│   ├── Player/
│   ├── Platform/
│   ├── Managers/
│   └── UI/
├── Prefabs/
├── Materials/
├── Scenes/
└── Config/
    └── DoofusDiary.json
```

## 🚀 Getting Started
1. Clone the repository
2. Open project in Unity 2022+
3. Load the main scene
4. Ensure DoofusDiary.json is properly configured
5. Hit play and start testing

## 🎯 Code Quality Focus
- Modular architecture
- Clean code practices
- Robust error handling
- Efficient resource management
- Readable and maintainable codebase
- Proper exception handling

## 🔍 Edge Cases Handled
- Platform spawning boundaries
- Timer synchronization
- Player fall detection
- Invalid movement prevention
- Resource cleanup

## ⚙️ Configuration
Game parameters are configured through DoofusDiary.json:
- Player movement speed
- Platform duration ranges
- Spawn timing
- Score requirements

## 🏆 Success Criteria
1. Smooth character controls
2. Accurate platform behavior
3. Proper score tracking
4. Polished UI/UX
5. Stable performance
6. Clean, modular code

---

*This project was developed as part of Hitwicket's game development challenge.*

## 📝 Note
This implementation does not use AI-generated code and follows the originality requirements of the assignment.
