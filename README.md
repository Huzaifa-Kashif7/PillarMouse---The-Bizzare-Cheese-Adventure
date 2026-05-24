**🐭 PillarMouse**

"Your next line is... 'I need to collect all the cheese!'"

A Unity 6 game where you play as a mouse collecting cheese across 3D and 2D environments. Built hands-on while completing the Unity Essentials Pathway. Named after the Pillar Men Theme — Awaken from JoJo's Bizarre Adventure, which plays as the background OST — because every mouse deserves a dramatic entrance.

**🎮 Scenes**
- **Starter ->** Tutorial / entry point
0 **Main Menu ->** Title screen
1 **Playground ->** Open 3D navigation
2 **Kids Room ->** 3D collectibles
3 **Kitchen ->** Audio triggers & sound design
4 **Living Room ->** Scripting & interactive objects
5 **Top-Down 2D ->** Classic 2D gameplay
6 **Bonus ->** Custom-built extra level

**🕹️ Controls**
- **Move ->** W A S D / Arrow Keys
- **Rotate ->** A / D
- **Jump ->** Space

**✨ Features**
- Physics-based mouse character with movement, rotation, and jump
- Rotating collectibles that burst on pickup
- Final cheese triggers a victory screen + sound
- Doors that animate open when the player walks in
- 3D and 2D proximity sound triggers
- Cinemachine camera, URP post-processing, TextMesh Pro UI


**🧩 Scripts**
Located in Assets/_Unity Essentials/Scripts/:

- **PlayerController.cs ->** Movement, rotation, jumping via Rigidbody
- **Collectible.cs ->** Spinning collectible + pickup burst effect
- **FinalCheeseTrigger.cs ->** Win condition — plays audio, shows "You Win" UI
- **DoorOpener.cs ->** Triggers door-open animation on player contact
- **CheeseSoundTrigger.cs ->** One-shot sound trigger (3D)
- **CheeseSoundTrigger2D.cs ->** One-shot sound trigger (2D)

**🎵 Audio**
🎵 JoJo's Bizarre Adventure — Pillar Men Theme: Awaken (main OST)
🎵 Unravel — Tokyo Ghoul OP [Piano]
🎵 Dragon Soul — DBZ Kai Lofi / Akira Toriyama Tribute
🏆 Victory sound effect
🐦 Ambient bird chirps
🧀 Cheese pickup SFX

⚠️ All music tracks are copyrighted and included for personal/educational use only. Please swap them out if you fork this project.


**🛠️ Built With**
- Unity 6000.1.13f1 (Unity 6)
- URP 17.1.0
- Cinemachine 2.10.4
- Input System 1.14.0
- TextMesh Pro built-in
- Unity 2D Feature Set 2.0.1

**🚀 Running the Project**
1. Clone the repo and open it in Unity Hub
2. Make sure Unity 6 (6000.1.x) is installed
3. Open Assets/_Unity Essentials/Scenes/0_MainMenu_Scene.unity
4. Hit Play

**📚 What I Learned**
Built as part of the Unity Essentials Pathway. Topics covered: scene management, Prefabs, Rigidbody physics, triggers, audio, C# scripting, UI/Canvas, 2D development, Animation, URP, and Cinemachine.

**👤 Author**
Huzaifa Kashif — github.com/Huzaifa-Kashif7

Built with 🧀 and the power of the Pillar Men.
