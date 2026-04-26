# cs134-team07-ball-adventure

# Motivation:

Our team has gone through the iterative approach of applying the concepts and skills learned throughout the Unity courses this semester to the Roll-a-ball game. As a team, we decided that the best way to fully master and integrate the Unity skills properly was to focus on game mechanics that had already been introduced to us early on in the semester. We thought that the creative process of developing an entirely new game from scratch would get in the way of figuring out how to implement each of the required features meaningfully. Therefore, with the Roll-a-ball game, we can put our full attention to showcasing our mastery of the Unity skills.

Although we are essentially building off of the Roll-a-ball game tutorial and focusing on applying Unity concepts, it does not mean that our team has skipped out on the core value of wanting to create a game that we fully want to create and bring to life. As a team, there were game aesthetics that we were fond of and wanted to reflect in our rendition of the Roll-a-ball game, such as the vibrant pinball aesthetic that the Waluigi Pinball map on Mario Kart had and the multiple biomes with a unifying aesthetic that Legend of Zelda: Oracle of Seasons had. Before the start of the semester, we thought that several of these features would be difficult to implement, as we did not have any prior knowledge about working with creative tools, and thought we would better showcase our skills through scripting, as we thought it would be the easiest to pick up, given our background in Computer Science. However, we were pleasantly surprised that these Unity concepts were well within our capabilities and have enjoyed each step of the creative process.

# How to Play the Game:

Across two different levels (Pinball Carnival and Four Seasons), the player controls a ball using WASD keys with the goal of traversing around the map and collecting the 12 PickUp objects that are placed at different locations on each map. There is no time limit to pick up all of the PickUp objects, but the player must carefully complete the goal while trying to run away from the enemy object in each level. The enemy has been designed to consistently move towards the player’s position, so it is up to the player to figure out the most optimal path to each of the PickUp objects while making sure not to get cut off by the enemy.

# Audio Motivation:

We have decided to choose free audio from freesound.org, as it was a website that was recommended during the Audio Unity tutorial. We wanted to find audio that best fit the pinball and Four Seasons aesthetic. Immediately, we wanted to look for a retro or arcade-like audio to be used as the Pinball level background music, as it seemed to suit it the most. In the end, we decided to pivot towards a more retro gaming-like audio as it seemed to fit more with the way the design of the pinball level. For the Four Seasons level, we decided to have more fun with it and implement a unique background music that plays whenever the player is positioned in each biome. This decision was also a good way to demonstrate what we have learned about 3D spatial audio.

# VFX Motivation:

For VFX, we were heavily inspired by the burst animations that we learned through the VFX Unity tutorial and wanted to make sure that we used them frequently throughout our game. The burst animation was originally used when applying VFX to a campfire model, which would play whenever the player “puts out” the campfire’s fire. We thought that this logic would work perfectly whenever the player collides with PickUp objects and enemy objects. This burst animation was also reused and changed for the win and loss screens.

# UI Motivation:

For UI, we didn’t want an overly complicated UI that was hard for the player to navigate. Instead, we wanted a quick UI that allowed the player to quickly get into a game and choose a level. We wanted to design the UI so that whenever the player finishes a level (either from winning or losing), the player can utilize the UI to quickly restart the game.

# Animation Motivation:

For Animations, there was undoubtedly an unlimited amount of possibilities that our team could have gone for what we could do with the Roll-a-ball level. Instead, we wanted to just have the animations be applied to the movement of the enemy object. The animations used are imported from the Unity Assets store. If given more time, we definitely would have looked into using animations to improve the obstacles on both levels.

# Materials Motivation:

For Materials, we combined both materials from the asset store and also the original materials. For the original materials, we have created a “neon” material that makes use of the emission property. Emissive properties were the perfect fit for the Pinball level. With the neon materials, it has transformed the Pinball level into a fun glow-in-the-dark level, with the neon material acting as a guide to help players traverse through a map with limited lighting. The materials from the asset store were utilized in the Four Seasons level, and a unique material was used to define each biome.

# Lighting Motivation:

For Lighting, lighting was especially important for the Pinball Carnival level because we wanted to emphasize dim lighting so that the neon material could stand out much more. This was achievable by applying the skybox materials and adjusting the Lighting Environment settings to include fog that helped the glow of the emissive materials pop out more. In addition, through the Lighting Unity tutorial, we learned about the importance of the Post processing object and how much different lighting looks once the settings were adjusted and new lighting was generated.
