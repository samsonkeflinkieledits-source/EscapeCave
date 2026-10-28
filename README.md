Samson Keflinkiel - Programmer/Modeler
Luke Vilmanis-Bakker - Level Designer, Tech Art

Project Proposal link ---> https://docs.google.com/document/d/1cgVxvhcrBarRWZ2Oo1jzlEZpVi2K_Mm8HDd8Gz7h37c/edit?tab=t.0

Proposal Pitch Video --> https://www.youtube.com/watch?v=PPaMBdlobH0

Project progression:

Progress Reflection --> https://docs.google.com/document/d/1D0TGUVDF7p9-0WOWuD6RfhsXshLRrOg_E0VPJCZU1uI/edit?tab=t.0

Progress report video --> https://www.youtube.com/watch?v=xBWFWsgP2H4

Part 1: Base game

Samson- I started by creating a capsule to represent the player and adding a player movement script that allows the player to move left to right, forward and backward, and jump. I also made the movement settings adjustable in the Inspector so I could change them easily. We decided to use a first-person perspective, so I placed the camera inside the player capsule and made it a child of the player. This allows the camera to move with the player. I then added a camera control script so the player could look around. Next, I created the level layout using simple primitive shapes, mainly cubes. I designed the level to be completed in one minute, creating a short but challenging experience. To add urgency, I implemented a game timer that counts down from 60 seconds. I also created win and lose scenes to give the player clear outcomes depending on their performance. The lose scene activates when the timer reaches zero or when the player touches the water, which uses a trigger to detect collisions. The win scene activates when the player reaches and collides with the end flag. These mechanics create a clear objective and encourage the player to complete the level before time runs out.

Part 2: Illumination

Luke- Using lit shaders I created a basic lambert, ambient, and specular shader. Using light point light sources and directional light sources the colours of objects could be seen. This will further be used for the final project submission for torches or lanterns to give the moody, dark cave feeling we are looking. Experimenting with directional lighting and point lighting we are trying to find a balance of what works in the scene while giving each object its own vibe. For the lambert shader was very basic involving a single colour and using a light source to show light and dark values of an object. The specular shader is uses what we learned from class and adds a time and velocity feature to make the surface have an emitting effect. This will be useful for the dark caves because the light coming from a torch on the wall does not always provide consistent light as it sometimes flickers. I also implemented a script that when number keys are pressed it goes through different lighting views if an object were to have multiple lighting effects on them.

Part 3: Shaders

Rim Lighting: This shader in our game creates a animated rim lighting by blending white and green along the objects edges using a lerp node. The rim effect is created by using the view direction and surface normals. I created a float called Rim Power that dictates the sharpness of the edges, while the base color remains unchanged.

Luke- Vertex Water Shader: The vertex water shader consists of 2 parts. The first part consists of a scrolling textures that change the colour of the object over time. Lerping together 2 different colours and a sine wave to get the scrolling effect on the colour we wanted. The second part changes the position of the shader over time. This is done by gathering the x and z value to make the waves scroll diagonally. Then using 2 float variable to change the height of the wave and the speed of the wave. By getting the position of the world and the object the waves are able to tile together smoothly throughout the world space.

Luke- Normal Mapping: To the specular shader I also added the normal mapping taught in class. The normal mapping will be super useful for us since the object doesn't need to have the same lighting properties for the main view direction and we can use a point light on the object to cell shade our objects.

