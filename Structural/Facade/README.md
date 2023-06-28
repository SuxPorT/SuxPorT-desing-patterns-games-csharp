# Facade
## Challenge Game: RTS game

In this challenge, we will have an epic game in the style of RTS 
(Real Time Strategy). In this game, there are different types of troops and the 
goal is to get stronger to beat enemy troops.

Each troop has a fundamental build that is the center of command. Internally, in
the command center, are executed various operations such as harvesting energy 
resources, producing weapons, train warriors, etc. We don't care how each 
operation (subsystem) of the control center is performed internally, we want the
control center to just send them to do. Therefore, this will be our challenge: 
to create a structure that hide how internal operations are performed, allowing 
that the control center just had them executed.
