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

Take the below steps to configure and run the applications on MacOS:
Configuration steps:
1. Go to the .NET 6.0 SDK installer webpage [download link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). Click on .NET 6.0 SDK MacOs x64
2. Once the installer downloaded open it and let the installation process begin after clicking on next, next, next buttons.
3. Open up a terminal window and type in cd /usr/local/share/dotnet/x64/ press enter
4. Then type in ./dotnet and press enter
5. If you get no error it means it's installed.
6. Then in order for the command "dotnet" to be runnable globally, type in sudo su then you will be prompted for your admin password or usual password enter it
7. Afterwards, type in this command ln -s /usr/local/share/dotnet/x64/dotnet /usr/local/bin/ then hit enter
8. Finally to ensure it's globally runnable type in dotnet and hit enter if no error it's ok. Below is the screenshot for the configuration steps.
    ![ConfigImage](./images/configurationForMacOs.png)
   
Execution steps:
1. Download the ZIP file of the project.
2. Extract the folder named understanding-the-systems-with-complex-connections-AslanIbadullayevDev-main to the Desktop
3. Open up a new terminal window and change directory by typing in cd Desktop/understanding-the-systems-with-complex-connections-AslanIbadullayevDev-main/ServerApp and hit enter
4. Type in dotnet run 9001
5. You should see activated server instance
6. Repeat the steps 3-4 by typing in different port numbers(9002, 9003) on different terminal windows.
7. Finally open up another terminal window change directory by typing in cd Desktop/understanding-the-systems-with-complex-connections-AslanIbadullayevDev-main/ClientApp and hit enter
8. Execute dotnet run
9. Enter numbers on client app instance terminal window server app instances will respond with doubled values of the entered numbers sequentially. Final result should be as follows:
    ![ExecutionImg](./images/finalresultMacOs.png)



