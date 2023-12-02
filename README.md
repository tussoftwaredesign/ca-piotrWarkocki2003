Virtual Reality Project Report:
Part 1:

Initial Idea for the Game:
        -My idea for the game consisted of designing my real life student accomodation in VR and having the player complete various tasks before being able to leave the house again!
        I wanted to design my real life accomodation to test my designing skills and to see how close I can get to the original .

Objectives in Game:
        -Tasks in game consist of finding keys to unlock new rooms.
        -Player needs to complete tasks and unlock each key to be able to escape/leave the apartment!
        -Player needs to complete tasks in each room to unlock the key to the next room, for example put the dishes in the sink to get key for the bedroom...
        -Tasks will be different in each room to keep it interesting and not make it repetetive.
        -

Things implemented:
        -Grabbable objects such as keys are one of many objects the player can interact with.
        -I added a flashlight if the player wants to use it to help them traverse the Game.
        -Color coded keys to unlock certain doors, ie.Red key unlocks door with red handle...Gives player a clear path and 
         objective.
        -Clue in the Boiler room that hints the player to check paintings in one of the bedrooms. This code will reveal a secret code that the player then needs to figure out the use for.
        -The Painting has a code on it, another painting is a decoy that says "try again elsewhere!"
        - I already messed around with some user interface to let player know what is going on in my game.
        -I have user interface in the bathroom(starting point of the game) which welcomes the player to the game.
        

Further ideas to implement in future weeks:        
        -As mentioned already, I want to get the tasks implemented such as the dishes as i didnt have time to do so this time around.
        -I will be adding more user interface to let the player seek help/instructions for each room.
        -There will be a functioning TV (already is to a certain extend)that will allow player to interact with for certain tasks.
        -I will be adding Audio to the game(soft background music) to make the game appear less dull as it might get quite boring without any sound.
        -I want to also add some sort of activation events for eg, turning TV ON/OFF with a remote control.
        -I will be adding LED lights to rooms to make the enviroment feel more vibrant and colorful.
        -I will be adding an area to place 3D numbers to sockets that, if placed in correct order, will open the front Door
        -I also want to add my hamster into the game that would be controlled via Finite state Machine or Waypoint systems.
        
        
Struggles along the way:
        -I struggled with many things in the first half of this Assingment.
        -XR RIG-- i found the Xr Rig to be very annoying to work with at times!... I had problems with phasing through floors/walls and even items making me phase through floors when interacted with.
        -If picked up , the key, for example it made my xr rig bug/jitter resulting in the game not being playable.I had to add layers to both the key and the xr rig and in the Physics settings disable them being able to
         collide with one another.That fixed that issue.
        -I had a problem with implementing the keys opening the doors,I found that when the key collided with the correct door it wouldnt open 100% of the time.I realised that changing the script from onCollisionEnter to
         OnTriggerEnter fixed that issue for me personally.
        -I also had to mess around with the height and width of the player as it was hard to find the right size to make the house not look massive/tiny.
        -I also struggled with the map design in itself, I found it hard to copy my real life apartment and make it look the same in game!
        -I experimented with lighting as I wanted to completely black out my boiler room to make the flashlight come in handy for that part of the game. I wasnt able to implement that as I didnt have the knowledge of
         doing so and tutorials online didnt seem to help either.

Reflection:
        - I had a lot of fun designing and building the first half of my game.
        - I learned a lot along the way about creating unity projects for Virtual Reality!
        - I realised that persistence and determnination was very important when creating anything in VR as VR may be a little buggy sometimes.
        - I will make sure to continue using my new knowledge when creating the rest of my project but also will put time into learning new ways and new mechanics to further improve my skills and understandning of Virtual 
          Reality development.
        - I think I do need to put a bit more time between now and the end of the semester to implement the features I would like inside my game, I think I now have the knowledge and understadning for VR to continue
          improving my game.


Screenshots: 
        -FirstKey In the Level:

![First Key](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/9ad311d1-1cca-4cb8-8e0a-a680bbff0b2d)
-Dishes:  
![Dishes](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/c82c6773-e983-4739-bbf6-a7e962b744c4)
        -FlashLight:
![FlashLight](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/fffba7f4-6d05-44a7-962b-c04f00b8b147)
        -FrontDoor/Exit:
![FrontDoor-EndPoint](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/cea28891-cea0-4f81-9f6d-26121966baf6)
        -Color Coded Doors:
![ColorCodedDoors](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/d3df6e7e-06e8-48c3-a889-5b700a0fa4d7)
        -Hint:
![Hint](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/2a4e755d-83c7-481c-859e-1dd245dd961a)
        -Painting with code:
![PaintingWithCode](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/241c8fe8-24d6-4e37-8b5c-82ec98432f3c)
![Code](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/7589ed25-4cec-435f-909f-a43ec122ddff)
        -TV:
![TV and Key](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/ce150212-dfd7-43f9-af52-7fe8e52db209)
        -User Interface:
![UserInterface](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/7d42d7c1-f337-453c-a798-158cbd8cdaf4)


Part 2:
Things implemented:
INVERSE KINEMATIC- I decided to add a 3D character model to my player using Inverse Kinematic. I decided to do this as I thought 
                   the game would look better and would feel more realistic if The player could see body that responds to their in
                   game movement.I got help to achieve this from a tutorial I found online which lead me in the right direction.

TIME FUNCTIONALITY-I decided that the way I can make my game have more replayability is by adding a time system which could be used
                   for potential speed running.
                   I wrote a script that stops the timer once the escape door is opened.The player can only see this time when they
                   get to the end.I thought this would be a good way of doing it as the player would have to guess how fast they are
                   going adding a feel of excitement!

CUPS AND TEDDIES-  My idea for key retrieval in 2 of the rooms in the house was to do some sort of collection system.I decided to have 
                   the player have to put cups into a sink in the kitchen in order to receive a key. I did the same for the teddies in
                   one of the bedrooms.

SPEAKERS-          I didnt want to have 1 specific background audio for the game so I came up with the radios, I added radios across 
                   the game into different rooms. I thought this would make it more interesting because the audio would change depending
                   which room you were in !.
                           
UI AND RESET GAME- I added more UI since my last report...I added a reset game UI incase the player wants to restart to try the speed run 
                   again or incase an item falls out of the map.( I later fixed this problem)!

FLASHLIGHT UPDATE- I decided to update the flashlight so that it had an ON/OFF feature. Previously the flashlight was always on no matter 
                   if the player was holding it or not.I changed it so that the player needs to hold the trigger on the controller to keep
                   the flash on.

NAV MESH AGENTS   -I decided instead of using FSM or WAYPOINT SYSTEMS, I would use Nav mesh agents to control my Hamster. This got recommended
                   to me and I thought it was Interesting. Since it was my first time doing something like this, I decided to experiment and 
                   research into it. I found a very useful tutorial that helped me understand how Nav Meshes work. I understood the concept
                   of Nav mesh Agents and Nav mesh Surfaces which was enough to allow me to implement this feature into my own game!

ROOMBA-           -I decided to still implement WAYPOINT SYSTEMS in some way, So I added A roomba hoover that goes around the kitchen. I wanted to make 
                  the environment more dynamic and I think this addition did exactly that.

ESCAPE DOOR CODE  -The way to escape in my game is to find the codes hidden around the map and put them in the right combination on their
                   designated hooks.When all codes are put on the hooks and in correct order the door would open and the player then would see
                   the time they completed the game in.

TV-               -I kept the TV simple, I added one channel on the TV. The TV is turned on using a remote. I added the SpongeBob theme song to the TV
                   as I thought it would be funny for the player to find this out.

LIGHTS-           -I scrapped the LED lights idea and went with functional light bulbs/swithes. I wanted the player to have more control in the game so I
                   added lights and switches. This way the player can decide if they want lights on/off and which rooms they want that in aswell.

EASTER EGGS-      -Easter eggs are a effective way to have someone play the game over and over again trying to find them all, I decided to add easter eggs 
                   that would correspond to my friends from class. I added subtle things such as pizza boxes, peanut butter jars or even a video on the laptop.
                   I will add screenshots of each easter Egg and who it corresponds to.


Struggles along the way:
IK-               -I struggled with the Inverse Kinematic 3D Model a few times, for example, having the legs look like they are moving with the direction of the player.
                  -I tried to make it more realistic and finally got to a point I was happy at and decided to leave it at that.



    

If I had more time:
Extra Rooms-      -I would definitely add more rooms to my game( Expand it out into the hallway of the apartment complex). I feel like I limited myself a lot with what I
                   decided to do for my game. Building my apartment meant I only had so much I could add in considering the space I provided myself with.
                   Therefore I would definitely add more space with extra challenges and little Easter Eggs.
Reflection:
Screenshots: 

Whole Map:
![WholeMap](https://github.com/tussoftwaredesign/ca-piotrWarkocki2003/assets/146718291/27559aa6-19b0-4391-9045-fc3d683768ae)







