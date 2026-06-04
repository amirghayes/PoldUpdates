After enough trials and errors, I decided to discard using Epic online services for my game, I already felt it is useless in my case but I thought to give it enough testing time in case I miss something, but I was correct, it is useless.



Reference the following link:
https://dev.epicgames.com/documentation/en-us/unreal-engine/auth-interface-in-unreal-engine

"Authenticate with an External Server

Frequently, games have custom web services that provide game-specific functionality. These services need to verify the caller's identity before providing access. QueryExternalServerAuthTicket retrieves a single-use ticket for authenticating a user with an external server."

That quote is just an example of how useless it is, if I will already need my custom services, database and dedicated server to name a few, then why would I use EOS in the first place?



# Unreal inconveniences

* Server will not receive the RepNotify
* Server RPC, its implementation in the CPP file must have the suffix \_Implementation added to the function name
* string to int32: FCString::Atoi(\*FString), Atoi !! ffs
* int has no fucking ToString(), it is FString::FromInt(int)



# Tips



* Never set values On CreatWidget exposed variables, there is no guarantee when its Construct event will fire, you might end up with default value if you try to use those variables elsewhere immediately after creating the widget, this might apply to everything as well, ConstructObjectFromClass and SpawnActorFromClass. In a nutshell, try to avoid exposing variables as much as you can, explicitly call a function/event to set them after creation/spawning if your code depends on those variables outside immediately after creation/spawning.



* AnimNotify behaves differently in dedicated server versus listen server:
-- On Listen server: It fires on both Server and Client
-- On dedicated server: It runs only on Client
-- To confirm try ticking the checkbox of "Launch Separate Server" under Multiplayer Options and un ticking "Run Under One Process" to test dedicated server, then reverse to test listen server.
-- Possible issue in other parts of the engine, make sure to test in both scenarios when working on multiplayer project.

