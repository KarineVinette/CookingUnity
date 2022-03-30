Mini-project: Cooking simulator

Now that you have the basics of Unity, the aim of this project is to consolidate your knowledge about Unity and get more familiar with its mechanics. And no better way than manipulating it by yourself.

In this project, we’ll develop a game where the player stands in the head of a cook! Yes, it is Overcooked inspired (but a lot simpler, no worries).The player will have to prepare a meal in his kitchen in a limited time. He will have to navigate between the fridge, the cupboards, hot plates to grab ingredients, prepare and cook them. With a press of a key, he can open or close doors or drawers, grab or release objects, or do an action with the corresponding tool (chop with a knife for example).
As a bonus, some events will occur in other rooms (phone ringing, water linking in the bathroom, …), the player will have to solve them asap or his mission will fail.


The final project has to be sent to sgoisbeault@gmail.com, either the compressed project (.zip/.rar) or the link to a git repository. In case you want to give me access to your repository on Github, here’s my Github user ID: sgoisbeault. The due date is April 8th. This will most probably not be marked/graded and you don’t have to work on it outside our courses (but can if want to)

You can find free (and not free) assets on these sites: Unity Asset Store, Sketchfab, Turbosquid, CGTrader, archive3D, …
Remember, if you need infos about a functionality in Unity, you can look at Unity Documentation and Scripting API
Project setup
Create a new project using version 2020.3.11f1(or any LTS 2020 or 2021 version). 
Create a git repository if you want to use a version control system for this project
Part 1: Environment setup
Get the different models from the following links and import them in your project:
Kitchen: https://assetstore.unity.com/packages/3d/environments/urban/furnished-cabin-71426
Building with separated roof and beams: https://drive.google.com/file/d/1uIBjmcI8a2AWCbzJyg1C6LOFTil1CWAu/view?usp=sharing of use the one in Assets\FurnishedCabin\Meshes\BuildingModular.fbx
Kitchen furniture (openable fridge):https://assetstore.unity.com/packages/3d/props/electronics/kitchen-appliance-low-poly-180419 
Pans: https://assetstore.unity.com/packages/3d/props/interior/old-pans-40282
Cutting board: https://drive.google.com/drive/folders/1shPQ6tvze2-IUhFlopCY2UR4Lu6kL-YX?usp=sharing
Knife: https://sketchfab.com/3d-models/small-knife-281538859489450cb0ba1be1d0275488
Tomato: https://www.turbosquid.com/3d-models/tomato-3ds-free/758044
Chopped tomato: https://drive.google.com/drive/folders/11D77q5VDxkNL-wE5MCXrP9-X9jYj14XG?usp=sharing
Steak: https://drive.google.com/drive/folders/1dA6BT7vSz2HpAx5i4UTLKxNOEF3KYVCl?usp=sharing
Burger bread: https://drive.google.com/drive/folders/1G6nj3Ar5tYeuSRbkClPC2fGHSZIPquyn?usp=sharing
Salad: https://drive.google.com/drive/folders/1qXvy-8bTTy7GNbcLLdRAz3OfJ2Ki8dwG?usp=sharing
Cheese: https://drive.google.com/file/d/1Vt1MgliSwBKkLBwn9_KxmL-AvEdu5Yhj/view?usp=sharing
Plates: https://assetstore.unity.com/packages/3d/props/interior/plates-bowls-mugs-pack-146682
Chef avatar: https://sketchfab.com/3d-models/skins-man-character-6a895f0f90da47cd9d2f0ff51f63df3b (better rig here)
https://www.mixamo.com/#/?page=1&query=chef&type=Character (Roth)
Prefab of a chef with character controller: https://drive.google.com/file/d/1X7FeQOMp2so2iRBmZVJThQb57xMAvf63/view?usp=sharing

Feel free to download any other assets you find cool, this project is yours!

Place all objects at their place in the scene and/or create useful prefabs
Part 2: Moving player in environment
Use the Third Person Character Controller to make the player be able to move in the environment using arrow keys (or ZQSD)
Make the camera follow the player. The camera is always looking from top but seeing the player always in the center
Part 3: Interacting with objects
Create interactable objects animations (door opening, plate heating, …)
Detect when the player is near an interactable object (fridge, cutting board) and detect press on action key. Trigger animations if needed.
Use the new Input System to get player inputs or use both old and new systems (Project Settings->Player->Active Input Handling set to ‘Both’).

Part 4: Grab/release ingredients
Make the player be able to grab an ingredient when close to it pressing a key. Make the ingredient follow the player like he is holding it (in his hands for example). Release the ingredient when pressing the same key.
Make the ingredient snap to a specific place (cutting board, pan, …) if released next to one using trigger colliders

Part 5: Transform/cook ingredients
Make the logic of each interactable: make the cutting board cut the tomatoes, make the pan cook the steak (and burn if too long).
Make the action only happen when pressing the action key when one ingredient is in the interactable.

Part 6: Assemble everything
Allow the player to put transformed (and not transformed) ingredients together in plates. Allow him to then put the finished meal to a defined place (dining table for example). Only complete burgers/meals are valid of course. 

Part 7: Add timer and score
Add a countdown and/or count how many burgers the player was able to do in a defined time or how many time he took to make a defined number of burgers
Add a UI to show the timer and/or score. See Canvas documentation

Part 8: Add unexpected events
Make some events happen at random moments outside the kitchen that the player has to fix to continue his mission. It can be an alarm clock ringing in the bedroom, a leak in the bathroom or whatever you can think of. Each event can be ‘fixed’ by pressing the action button when close to it.

Part 9: Game menu
Add to the UI a welcome page and some buttons to play, restart, replay the game.
Why not add a highscore section (Save scores to a file using File class or look at PlayerPrefs). You will need to ask the player to enter his name before or after playing the game
