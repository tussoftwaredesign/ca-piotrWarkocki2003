Report-part 1 for my Virtual Reality Project:

Initial Idea for the Game:
        -My idea for the game consisted of designing my real life student accomodation in VR and having the player complete          various tasks before being able to leave the house again!

Objectives in Game:
        -Tasks in game consist of finding keys to unlock new rooms.
        -Player needs to complete tasks and unlock each key to be able to escape/leave the apartment!
        -Player needs to complete tasks in each room to unlock the key to the next room, for example put the dishes in the           sink to get key for the bedroom...  

Things implemented:
        -Grabbable objects such as keys are one of many objects the player can interact with.
        -I added a flashlight if the player wants to use it to help them traverse the Game.
        -Color coded keys to unlock certain doors, ie.Red key unlocks door with red handle...Gives player a clear path and 
         objective.
        -Clue in the Boiler room that hints the player to check paintings in one of the bedrooms that will reveal a secret           code that the player then needs to figure out the use for.
        -The Painting has a code on it, another painting is a decoy that says "try again elsewhere!"
        - I already messed around with some user interface to let player know what is going on in my game.
        

Further ideas to implement in future weeks:        
        -As mentioned already, I want to get the tasks implemented such as the dishes as i didnt have time to do so 
        this time around.
        -I will be adding more user interface to let the player seek help/instructions for each room.
        -There will be a functioning TV (already is to a certain extend)that will allow player to interact with for certain          tasks.
        -I will be adding Audio to the game(soft background music) to make the game appear less dull as it might get quite           boring without any sound.
        -I want to also add some sort of activation events for eg, turning TV ON/OFF with a remote control.
        -I will be adding LED lights to rooms to make the enviroment feel more vibrant and colorful.
        -I will be adding an area to place 3D numbers to sockets that, if placed in correct order, will open the front Door
        - I also want to add my hamster into the game that would be controlled via Finite state Machine or Waypoint systems.
        
        

Struggles along the way:
        -I struggled with many things in the first half of this Assingment.
        -XR RIG-- i found the Xr Rig to be very annoying to work with at times!... I had problems with phasing through               floors/walls and even items making me phase through floors when interacted with.
        -If picked up , the key, for example it made my xr rig bug/jitter resulting in the game not being playable.I had to           add layers to both the key and the xr rig and in the Physics settings disable them being able to collide with one           another.That fixed that issue.
        -I had a problem with implementing the keys opening the doors,I found that when the key collided with the correct           door it wouldnt open 100% of the time.I realised that changing the script from onCollisionEnter to OnTriggerEnter           fixed that issue for me personally.
        -I also had to mess arounf with the height and width of the player as it was hard to find the right size to make            the house not look massive/tiny.
        -I also struggled with the map design in itself, I found it hard to copy my real life apartment and make it look             the same in game!
        -I messed around with lighting as i wanted to completely black out my boiler room to make the flashlight come in            handy for that part of the game. I wasnt able to implement that as I didnt have the knowledge of doing so and               tutorials online didnt seem to help either.

Reflection:
        - I had a lot of fun designing and building the first half of my game.
        - I learned a lot along the way about creating unity projects for Virtual Reality!
        -I realised that persistence and determnination was very important when creating anything in VR as VR may be a              little buggy sometimes.
        -I will make sure to continue using my new knowledge when creating the rest of my project but also will put time            into learning new ways and new mechanics to further improve my skills and understandning of Virtual Reality development


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


 





