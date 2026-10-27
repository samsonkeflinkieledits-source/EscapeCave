Samson Keflinkiel - Programmer/Modeler
Luke Vilmanis-Bakker - Level Designer, Tech Art

Project Proposal link ---> https://docs.google.com/document/d/1cgVxvhcrBarRWZ2Oo1jzlEZpVi2K_Mm8HDd8Gz7h37c/edit?tab=t.0

Proposal Pitch Video --> https://www.youtube.com/watch?v=PPaMBdlobH0

Progress Reflection --> https://docs.google.com/document/d/1D0TGUVDF7p9-0WOWuD6RfhsXshLRrOg_E0VPJCZU1uI/edit?tab=t.0

Project progression:

Part 1: Base game:

Samson- I started by creating a capsule to represent the player and adding a player movement script that allows the player to move left to right, forward and backward, and jump. I also made the movement settings adjustable in the Inspector so I could change them easily. We decided to use a first-person perspective, so I placed the camera inside the player capsule and made it a child of the player. This allows the camera to move with the player. I then added a camera control script so the player could look around. Next, I created the level layout using simple primitive shapes, mainly cubes. I designed the level to be completed in one minute, creating a short but challenging experience. To add urgency, I implemented a game timer that counts down from 60 seconds. I also created win and lose scenes to give the player clear outcomes depending on their performance. The lose scene activates when the timer reaches zero or when the player touches the water, which uses a trigger to detect collisions. The win scene activates when the player reaches and collides with the end flag. These mechanics create a clear objective and encourage the player to complete the level before time runs out.

Part 2: Illumination




Part 3: Shaders
