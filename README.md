After enough trials and errors, I decided to discard using Epic online services for my game, I already felt it is useless in my case but I thought to give it enough testing time in case I miss something, but I was correct, it is useless.



Reference the following link:
https://dev.epicgames.com/documentation/en-us/unreal-engine/auth-interface-in-unreal-engine

"Authenticate with an External Server

Frequently, games have custom web services that provide game-specific functionality. These services need to verify the caller's identity before providing access. QueryExternalServerAuthTicket retrieves a single-use ticket for authenticating a user with an external server."

That quote is just an example of how useless it is, if I will already need my custom services, database and dedicated server to name a few, then why would I use EOS in the first place?



# Unreal inconveniences

* Server will not receive the RepNotify
* Server RPC, its implementation in the CPP file must have the suffix _Implementation added to the function name
