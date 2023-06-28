# Flyweight
## Challenge Game: Super Mario World

The classic Super Mario World from the Super Nintendo console, which still marks
generations. In this game, then in one of the initial phases, several turtles 
appear.

Now, imagine that each turtle is an object and that in addition to red turtles, 
it is possible to find other colors in the course about the game. So, let's 
imagine six turtles, being: three red, one green, one orange and one blue. The 
challenge is develop a solution that guarantees only one instance for each type 
of turtle, to avoid overloading memory.

To solve this challenge, we can share objects similar ones that are already 
instantiated and reduce the amount of objects allocated in memory. In the 
example, instead of having six instances of turtles, decreased to just four, 
because using the Flyweight pattern a single instance of the red turtle can be 
shared with the three red hulls that are in the game.

Therefore, the Flyweight pattern has two characteristics: intrinsic and 
extrinsic. A feature intrinsic property of the object is an immutable property, 
that is, which characterizes the shared object, but that does not change (in the
example, all objects are turtles). It is a characteristic extrinsic are variable
properties that can receive new values at each access (for example, each turtle 
can have its own color).
