# HubConnect_Win
Windows GUI client for registering a WetMyPlants Hub via Bluetooth

### The problem
When first setting up a WetMyPlants hub, there is no easy way to connect it to a Wi-Fi network.
The current method involves remoting in through SSH and modifying the wpa_supplicants file, then restarting.
For the average end-user, this is far too technical and would prevent most people from using the product.

### The solution
This GUI client allows the user to enter their Wi-Fi network name and password and transmit it to their WetMyPlants hub from any Windows computer. Everything else is taken care of by the GUI client software and the software on the WetMyPlants hub.

### How it works
The WetMyPlants hub is a Raspberry Pi-based system that includes a Wi-Fi antenna and a Bluetooth antenna.
When the hub first boots up, there is a 3 minute waiting period where it will listen for incoming Bluetooth data transfers; This period allows the GUI client to transmit a file containing the Wi-Fi network name and password.

If the WetMyPlants hub detects that a file has been transferred, a series of scripts will run that parse the data file and modify the wpa_supplicants file with the information given by the user. The hub then automatically reboots and, upon starting up, will automatically connect to the Wi-Fi network.
