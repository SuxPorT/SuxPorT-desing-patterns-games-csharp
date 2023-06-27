# Abstract Factory
## Challenge Game: StarCraft

In this challenge, the scenario will be StarCraft, the classic real-time 
strategy game, where there are three races of characters: the Protoss, Zergs 
and Terrans. Each race has its different units and buildings, but very well 
balanced.

Each species has its base, which in the game has the function of  generating and
expanding the amount of warriors. So a base is a building that is available for 
all three types of characters, however, with some differences according to race 
(Protoss, Zerg and Terrans). Therefore, a strategy is needed to create bases 
with their individual characteristics, but also share the characteristics that 
all bases have in common.

Another aspect of this game is that the technology and buildings that are 
available expand, evolving with the game. So it needs to develop a solution 
that works without having to change the existing code when adding new products 
or product families, as the update happens very often and without changing the 
game's source code every time.
