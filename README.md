# Unity-Mumble
 
 Umity-Mumble is a project to showcase the creation of a Mumble server utilizing [murmur-rest](https://github.com/alfg/murmur-rest) and the management of that server using Unity. 

 ![](C:/Users/alexfriant/Pictures/MumbleTest.gif?raw=true "Title")


 ### Murmur-rest

 [murmur-rest](https://github.com/alfg/murmur-rest) is a RESTful web application wrapper over the Murmur SLICE API to administer virtual Mumble servers. The API allows you to develop your own application using the feature set and endpoints provided.

### Docker Setup

A `docker-compose` and Dockerfile are provided to easily setup a local development setup. Install [Docker](https://docs.docker.com/engine/installation/) and run the following commands:

#### `docker-compose`
* Run docker-compose:
```
docker-compose up
```

This will start the `murmurd` and `murmur-rest` containers with the default configuration defined in `docker-compose.yml`.

Load `http://localhost:8080/servers/` into the browser to test and login with `admin/password`.


## Unity setup
A unity project is included in this repo to demonstrate the management of the mumble server. It is utilizing Unity version 2020.3.33 to match the version of Unity Reflect is built off of.  

### Scene setup
* Open the example scene inside of 
```
Assets/Mumble-Unity
```

Ensure the GameObject named Mumble has the following info:
| Fields | Values |
| ---- | --------------- |
| Host Name | 127.0.0.1 |
| Port | 50000 |

### Unity Command Shortcuts
Ensure the GameObject named Mumble has the following info:
| Button | Command |
| ---- | --------------- |
| T | Send a text message to the server |
| J | Join a channel named "MyChannel"* |
| Escape | Join the root channel |
| M | Mute the first user |
| N | Unmute the first user |
| D | Delete the first channel** |
| S | Get the server stats|

*if the channel has not yet been created this will create one. 
** This command will not delete the root channel run the J command before this one.

### Optional Setup
If you would like to see the what is happening on the server download the [Mumble client](https://www.mumble.info/downloads/) and connect to the server using the same info as above.