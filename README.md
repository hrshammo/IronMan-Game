# IronMan-Game
# Game Interface
## Start Game
### Game Running
![Screenshot 2022-01-06 205824](https://user-images.githubusercontent.com/76872754/148405816-10a6a13e-eb8e-45da-9146-a0e9b330c2fb.png)
## Game Over
When IronMan Crash with any moving object or Top or Botton it's means Game Over. 
![Screenshot 2022-01-06 210101](https://user-images.githubusercontent.com/76872754/148405904-2ed5f9f3-e728-4ef7-b302-bfac7a19da17.png)
# Setup guide
Sample game\Sample game\bin\Debug\Sample game.exe 
Open Sample game.exe file and it will run. 

# Setup guide
* Install Microsoft Visual Studio 2019 or newer (Community Edition is fine)
* Install latest .NET Framework and Core (VS Installer should let you do that, otherwise check [here](https://dotnet.microsoft.com/download/dotnet-framework) for Framework, and [here](https://dotnet.microsoft.com/download/dotnet-core) for Core)
* Install Editor Guidelines (https://visualstudiogallery.msdn.microsoft.com/da227a0b-0e31-4a11-8f6b-3a149cf2e459)
	* This is strongly encouraged to follow the 120 character limit per line guideline
	
### Auto Setup (Windows x64)
* Download and run [IronMan-Game](https://github.com/hrshammo/IronMan-Game/blob/main/Sample%20game/bin/Debug/Sample%20game.exe) 

* Build and run
* If having trouble, follow the Manual Setup below
		
### Manual Setup (Windows/Mac)

* For running the git commands below, [Git Bash](https://gitforwindows.org/) is recommended
* Clone the git repository using ```git clone https://github.com/hrshammo/IronMan-Game```, then to download the necessary contents packages, run:
	* ```cd GameServer```
	* ```git submodule init```
	* ```git submodule update```
* Open the GameServer Solution in VS, set the platform to x86, Build, and run.


### Manual Setup (Linux)

* Install git and dotnet (dotnet-host, dotnet-runtime, dotnet-sdk, dotnet-targeting-pack) using your distro's package manager
* Clone the git repository using ```git clone https://github.com/hrshammo/IronMan-Game```, then to download the necessary contents packages, run:
	

# Running the game client

#### Automatically Launching from Visual Studio or Sample game.exe





# License

This repository is under the [AGPL-3.0](LICENSE) license.
All Copyright © goes to HR Shammo (https://github.com/hrshammo/) 
This essentially means that all changes that are made on top of this repository are required to be made public, regardless of where the code is being ran.
