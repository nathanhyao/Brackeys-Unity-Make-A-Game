# Starter Unity Video Game, Brackeys

## Notable issues encountered

**VS Code C# Intellisense not working for Unity**

- Follow [Unity Development with VS Code Article](https://code.visualstudio.com/docs/other/unity).
- Install .NET SDK (+set path), install .NET Framework Developer Pack.
- **Unique steps (1)** VS Code C# Extension settings: omnisharp.useModernNet ON.
- **Unique steps (2)** Unity > Edit > Preferences > External Tools > Generate .csproj files for: UNCHECK ALL.

## Series outline

(1) [How to make a Video Game in Unity - **BASICS** (E01)](https://www.youtube.com/watch?v=IlKaB1etrik&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6&index=2)

- 1:34 Creating **new project**
- 2:16 **Scene view** navigation
- 2:25 **Hierarchy** intro (game objects)
- 2:36 **Inspector** properties (object components)
- 2:50 **Project panel** (game assets)
- 2:56 Rearranging user interface (default view)
- 3:15 Create 3d object (hierarchy > create)
- 3:30 **\*Focus** on selected object (F)\*
- 4:55 Creating and assigning **material**
- 6:09 Add gravity (physics **rigidbody**)
- 6:27 _Manual **transform tools** (QWERT)_
- 7:04 _Duplicate object (Ctrl + D)_
- 7:23 **Components** basics (renderer, colliders)
- 8:51 Box vs sphere **colliders**
- 9:33 Disabling object (inspector checkbox)
- 9:55 Changing **skybox** (sky) color
- 10:16 _Maximizing game view (Shift + Space)_
- 10:21 Save scene

(2) [How to make a Video Game in Unity - **PROGRAMMING** (E02)](https://www.youtube.com/watch?v=9ZEu_I-ido4&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6&index=3)

- **C# Intellisense**: install and locate .NET SDK
- 0:19 Creating **scripts**
- 0:38 Scripts as custom components
- 1:00 Opening script editor from UI
- 1:35 **Start() and Update()**
- 2:07 **Debug.Log("Hello World");** (Console)
- 3:38 Referencing rigidbody component
- 4:25 Rigidbody **useGravity**
- 5:02 Rigidbody **AddForce()**
- 6:35 Framerate independence (**Time.deltaTime**)
- 8:15 **FixedUpdate()** for physics

(3) [How to make a Video Game in Unity - **MOVEMENT** (E03)](https://www.youtube.com/watch?v=Au8oX5pu5u4&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6&index=4)

- 0:53 Adding position/rotation constraint
- 1:20 **Physics material** (friction)
- 3:26 Edit script values in Inspector (variables)
- 5:00 **User input** if statements
- 7:30 Better ways to handle user input

(4) [Video Unavailable: How to make a Video Game in Unity - **CAMERA FOLLOW** (E04)](https://www.youtube.com/watch?v=HVB6UVcb3f8)

(Alternative) [Creating a Basic **CAMERA FOLLOW** Script in Unity](https://www.youtube.com/watch?v=IljRXDUTAms)

- 0:20 Why **parenting** doesn't work (rotation)
- 1:14 Creating camera script component
- 1:44 Transform target, **Vector3 offset**
- 2:35 **transform.position**
- 3:23 Assinging target and offset

(5) [How to make a Video Game in Unity - **COLLISION** (E05)](https://www.youtube.com/watch?v=gAB64vfbrhI)

- 0:45 Create player script component
- 1:04 **OnCollisionEnter()**
- 2:15 Add obstacle
- 2:32 Create obstacle material
- 2:43 Material smoothness
- 3:02 Rigidbody adjusting mass
- 3:21 **OnCollisionEnter(Collision collisionInfo)**
- 3:55 Check collision with specific object
- 5:18 **Tags vs object name**
- _[self node: md learned here select then CTRL+**]_
- 5:43 Adding tags
- 6:34 Disabling player movement script

(6) [**GAMEPLAY** - How to make a Video Game in Unity (E06)](https://www.youtube.com/watch?v=D4I0I3QJAvc)

- 0:22 Creating **never-ending levels**
- 0:42 Creating **prefabs** (same properties)
- 0:58 Update all prefabs at once
- 1:08 Update prefab individually (Overrides > Apply)
- 1:34 Creating endless runners
- 2:10 **Axes views** and **perspective/isometric**
- 2:34 Toggle **scene skybox, fog, flares, etc.**
- 2:43 Toggle **grid**
- 2:47 Add and assign **layer**
- 3:00 **Lock layers**, prevent selection
- 3:14 Moving object on 2 axes (plane)
- 3:20 **Snap** objects to grid (Ctrl)
- 3:40 Create level
- 4:23 More responsive controls (**ForceMode.VelocityChange**)
- 5:40 **Drag** / Air resistance
- 6:12 _Play game shortcut (Ctrl + P)_
- 6:32 Window > Lighting > Environment > **Fog**

(7) [**SCORE & UI** - How to make a Video Game in Unity (E07)](https://www.youtube.com/watch?v=TAGZxRMloyU)

- 0:10 Folder organization
- 0:33 Fixing **pass-through collisions**
- 1:27 Creating **UI text elements**
- 1:38 Canvas and text adjustments
- 2:49 Scaling UI with screen size
- 3:38 Using **unavailable fonts**
- 4:34 Creating UI score script
- 5:02 Get position of player
- 5:47 Set position as UI score (**UnityEngine.UI**)
- 7:42 Change UI score's precision
- 8:15 Canvas > Inspector: Pixel Perfect

(8) [**GAME OVER** - How to make a Video Game in Unity (E08)](https://www.youtube.com/watch?v=VbZ9_C4-Qbo)

- 0:20 Creating **GameManager object + component**
- 1:10 Custom EndGame function
- 1:37 Referencing GameManager functions
- 2:12 Problem with swapping object out of scene
- 2:40 **Searching for scripts**
- 3:30 Searching for script methods (make public)
- 4:14 Unassigned reference exception
- 4:55 Check if player falls off edge (check Y-value)
- 5:50 Preventing multiple "Game Over"s
- 7:18 **Restart game (UnityEngine.SceneManagement)**
- 8:53 Fix lighting issue with reloading scenes
- 9:55 Slight delay: **Invoke("MethodName", restartDelay);**
- 11:00 Add scene to **File > Build Settings**

(9) [**WINNING LEVELS** - How to make a Video Game in Unity (E09)](https://www.youtube.com/watch?v=Iv7A8TzreY4)

- 0:10 Creating a trigger
- 1:05 Scene icon for invisible objects
- 1:28 Trigger object script
- 1:40 OnTriggerEnter()
- 1:55 Reference GameManager script
- 2:25 Create and call win function
- 3:12 Only trigger for a certain object
- 3:30 Create winning UI panel
- 4:00 Create winning UI text
- 4:55 Code to display winning UI screen
- 5:35 Window > Animation vs Animator
- 7:00 Keyframes: fade in
- 8:16 Load new level animation event function
- 9:20 Load new level by build index
- 10:30 Scene duplication (save first)

(10) [**FINISHING UP** - How to make a Video Game in Unity (E10)](https://www.youtube.com/watch?v=r5NWZoTSjWs)

- 0:12 Optimize level creation
- 0:38 Prefabs for level creation
- 1:05 Level creation for larger games
- 1:30 Level duplications
- 2:00 End screen scene (panel + text)
- 3:38 Quit button styling
- 4:27 Quit button script Application.Quit()
- 5:54 Main screen scene
- 6:59 Start button script
- 7:47 Adding scenes to build
- 8:15 Gameplay

(Build/Export) [How to **BUILD / EXPORT** your Game in Unity (Windows | Mac | WebGL)](https://www.youtube.com/watch?v=7nxKAtxGSn8)

- 0:15 Selecting platforms
- 0:56 Export render quality
- 2:05 Company name, product name, game icon
- 3:34 Standalone (Windows/Mac/Linux) preparation
- 5:03 Windows build (+ installer)
- 10:48 MAC build (+ installer)
- 12:37 WebGL (Browser)
