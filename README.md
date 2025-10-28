# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.\
Hello World!\
Pretend I wrote a beautiful metaphor describing Components, GameObjects, and Scenes here.

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.\
Why are the r, g, and b variables floats instead of ints, bools, or strings?\
The RBG values that are stored need need decimal values to acurately represent the data of the color. Not an string because it is not storing characters. Not a bool because it is not storing a true or flase state.\
Why is the _bounce variable an int instead of a float, bool, or string?\
Bounces are whole numbers therefor having and INT variable is more efficent to track number of bounces and store them.\
The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?\
You can't natively add int and float variables in the code without the "f" declaration. Nummber storage types do not go together.\
Link to W2 Actvity: https://sinnabardev.itch.io/bouncey-ball-cat \
### W3
Table #6
You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.\
The input parameters DidPLayerHitBeat would input is the key.input and timeinput. By comparing the input and the time of input with the time of accurate hit is less than margin of error in seconds like 1 second.  We can return a boolean of true or false.\
Classes are like rectangle while components are squares. Component and Classes are similar as they both contains methods and varible to create functions. Classes are like blueprints able to be edited and developed for certain unique functions. Components are reusable classes which functions that can be spread and use for common use.\
The balls in the scene become extremely bright because the getcolormultipler is being called as the speedthreshold is being reached over surpassed.\
### W4
Table #6
Tables 1-10: lines 5, 22, and 25\
Line 5 is delacring a float variable called movespeed with is serialize to edit in inspect, this is a foward movement based on time delta.\
Line 22 is a line of code that get input verticle native to unity c# and multiples the movespeed to get a float of the translation placement away from the origin.\
Line 25 transform is tracking the xyz data and translating the data to create a function for the new input data to 0,0, translation. translation in the z of foward axis.\
Rigid Body = Cat, Soccerball\
All need colliders\
but, Collider isTrigger = Goal\
### W5
Step 1 (2 min): Write down a question you have about vectors, the Transform Component, gameObject, or GetComponent().
Is there a way for the GetComponent gameObject Childern that are also GameObjects?
Yes, GetComponent can call transfrom or we can attach a unique component like GetComponentInChild.
What member variable(s) does this class need?
We need a GameObject variable to declare as a target with a serializedfield
We also need to declare a NavMeshAgent
What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
The method we need is Start() unless the deer is following a moving object then we can use Update()
What should the method(s) do?
The method should transform and get the postion of the get component target. Then the Navmesh should set postion to the target gameobject transform postion.
=======
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
