### Introduction to Zombie Runner ###

+ **Creating a stunning 3D terrain.**
+ **Built-in character controllers.**
+ **AI navigation and pathfinding.**
+ VR compatible HUD interface.
+ Item pick-ups.

### Section 9 Game Design Document ###

**About this document...**
+ A brief specification of your game.
+ Can change as you go along.
+ Meant to help keep you focused
+ … and to remind you of your original idea.
+ We suggest you write one every time.

### Your Zombie Runner Assets ###



### Section 9 Notes ###

**In this section...**
+ **Creating a stunning 3D terrain.**
+ **Built-in character controllers.**
+ **AI navigation and pathfinding.**
+ VR compatible HUD interface.
+ Item pick-ups.

### About Unity 5.1 Features ###

+ Ensure you have Unity 5.1 or later installed.
+ What's new in Unity 5.1
+ What we'll be using in this section.

### Creating A Terrain ###

+ Read the Game Design Document.
+ How to setup your terrain.
+ Some Unity terrain settings.
+ Raising and lowering terrain.
+ Painting textures on terrain.

### First Person Character Controller ###

+ What is a First Person controller.
+ Why would we want to use it?
+ Using the standard First Person controller.
+ Previewing your terrain from ground level.
+ About slope limits.

### Placing Trees & Details ###

+ How to place trees on your terrain.
+ How to paint grass details.
+ About grass and billboards.
+ Performance impact of grass.

### Adding A Water Table ###

+ Using Unity 5's wonderful water prefab.
+ Create a “water table” in your terrain.
+ Dig down to create some water hazards.
+ Paint mud under the water's surface.
+ Preview water from the ground.

### Awsome-ify Your Scene Lighting ###

+ Moving scene view to character view.
+ Adding fog to your scene.
+ Add a lens flare to the sun.
+ Add a flare layer to the FPSController camera.

### Setting Up Your Navmesh ###

+ What is a Navmesh.
+ Setting up a terrain Navmesh.
+ About bake settings.
+ Bake our NavMesh.
+ Preview to ensure it suits our terrain.

### Scaling Your Characters ###

+ Using a reference cube in your scene.
+ Setting your first person character eye height.
+ Checking character scale against environment.

### Setup Player Spawn Points ###

+ Setup player spawn points in hierarchy.
+ Update FPSController prefab before deleting.
+ Create a **PlayerSpawner.cs** script.
+ Arrange for player to spawn randomly on **Start()**

### Using Input Mapping ###

+ About the Unity Input Manager.
+ Create input for **v**iew zoom (default v).
+ Create input for call **h**elicopter (default h).
+ Give both inputs basic 'placeholder' behaviour.
+ Preventing duplicate key presses.

### Adding 3D Helicopter Sound ###

+ About 3D sounds.
+ Attaching and tweaking your first 3D sound.
+ Arranging simple helicopter landing.
+ About 2D / 3D Spatial Blend.
+ Using multiple audio sources.

### Rigged “Mechanim” Animation ###

+ Introducing Unity's Mechanim system.
+ Exploring how Ethan is constructed.
+ Finding the rigging and muscles tool.

### Exploring Humanoid Animation ###

+ An overview of how Ethan is animated.
+ About re-targeting animations.
+ Introducing Blend Trees.
+ What is Inverse Kinematics (IK)?

### Simple Day-Night Cycle ###

+ A little about Earth's orbit.
+ Coding a simple day-night cycle.
+ Using a time scaling parameter.

### Searching For Clear Area ###

+ Looking for a suitable landing place.
+ Which type of collider to detect a clear area?
+ Creating a simple system.
+ Our vision for the game.

### Using SendMessageUpwards ###

+ Introducing **SendMessageUpwards()**\*
+ Creating a message for the helicopter call.
+ Making the helo respond to the message.

\* [Unity Scripting API - Component.SendMessageUpwards()](http://docs.unity3d.com/ScriptReference/Component.SendMessageUpwards.html)

### Inner Voice To Guide Player ###

+ Using an inner voice to guide the player.
+ Recording some sound prompts.
+ Triggering sound prompts at the right time.
+ Handling multiple AudioSources.
+ Using audio priority.

### Using BroadcastMessage() ###

+ **BroadcastMessage()** sends down the hierarchy.
+ Creating a natural parent **RadioSystem** object.
+ Creating a new child of player called **InnerVoice**.
+ Reduce to one Audio Source per game object.

### Refactoring Our Message System ###

+ Sending messages up and down the hierarchy.
+ Using **Invoke()** to delay audio playback.
+ Writing **RadioSystem.cs** for radio communication.

### Normalizing Audio Files ###

+ Recording dialog placeholders.
+ Remember you may need a .mp3 licence
+ About normalizing sound volume.
+ Organising and attaching audio.

### Landing Area Prefab ###

+ Creating a landing area prefab.
+ Using the flare particle effect.
+ Setting the game to start at dusk.
+ Making the player deploy the flare.

### Compacting Your Unity Folder ###

+ What we've left-out and why.
+ Checking our project is tidy.
+ How to compact your Unity folder.
+ Finding our code on GitHub.
+ Over to you.

### DOWNLOAD Section 9 Unity Project ###

The end state of our Zombie Runner project is attached for download.

### Section 9 Wrap-Up ###
