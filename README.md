# Implementation of Client-Server architecture

First, user creates three instances of server application manually by passing port numbers for each of them on command line window.
Then user runs the client app that prompts to enter a number of integer data type.
Each time an integer number is entered in client app terminal, doubled value of that entered number will get
printed out on one of the server app instances sequentially.

# Installation

The project written in C# requires .net sdk version of at least 6.0 installed on the machine.
If there isn't any, open the below link and download .net sdk 6.0 choosing the appropriate OS under the Installers column:
if your machine is based on 64-bit architecture then click on the x64.

[download link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

When downloaded and installed, you can see .NET SDKs installed by executing the
"dotnet --list-sdks" command. 
If you can see a version number starting with 6.0, it means it's installed:

![dotnetsdkversion](https://github.com/ADA-GWU/understanding-the-systems-with-complex-connections-AslanIbadullayevDev/assets/113417854/4a204ddf-3302-4e05-a970-22c0ec38046c)



# Usage

Once you have downloaded the zip file of source code files. Extract them to a folder named "Project"

![directory](https://github.com/ADA-GWU/understanding-the-systems-with-complex-connections-AslanIbadullayevDev/assets/113417854/6c30c8b1-eb49-4700-bd17-a2fa17f74959)

Applications are run separately therefore multiple command line windows should be opened up.
For running instances of server app, current directory should be changed to the location of ServerApp folder
To execute, type and press "dotnet run 9001" command. Here 9001 is the port number you can enter different ones for other server app instances.
But keep in mind that two applications with the same ip addresses and port numbers cannot be executed simultaineously.
Once three instances of the server app are up and running, client app instance can be started.
For running instances of server app, current directory should be changed to the location of Client folder.
Afterwards, type and press "dotnet run" command.
Now just enter an integer in client app instance command line window, it will be displayed doubled by one
of the running server app instances:

![finalresult](https://github.com/ADA-GWU/understanding-the-systems-with-complex-connections-AslanIbadullayevDev/assets/113417854/9c346e4e-e69e-4c26-b4e2-1d6291ad42b2)

You can watch this video to install and execute the applications:
[youtube link](https://youtu.be/KHiMT-7-r30?si=HVU7QKglsJlubXyi)

Similar to this execution guideline the same steps be taken for running apps on MacOs. 
You can watch the video in the below link:

[youtube link](https://youtu.be/Jr0XGKHoYU0?si=Yqe5wfqDwoUaeJYo)
time interval 1:52 - 3:17 

