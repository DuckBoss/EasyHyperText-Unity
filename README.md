# EasyHyperText-Unity
- An easy way to implement hyperlinking for 3D Gameobjects and UI Elements in the Unity Game Engine

## Installation :
- Open the folder as a project in the Unity Game Engine 
  OR
- Create a project in the Unity Game Engine and import the included 'EasyHyperText-Unity.unitypackage'.

## Usage : 
- Make sure the Scene has an 'EventSystem' GameObject present.
- Add The 'HyperText' script to either a 3D GameObject or Unity UI and follow the corresponding intructions.
- Set the 'Mode' to 'UI' or 'Game Object' based on what you placed the script on.
- Set the desired internet link in the 'Hyperlink String' variable in the inspector.


## 2D Unity UI Elements HyperLink Instructions:
------------------------------
- Place the 'HyperText' Script on a UI Element. (e.g. Text UI Object)
- Set the 'Mode' to 'UI' on the script.
- Add a 'Event Trigger' Component on the UI object if it is not already there.

## 3D GameObject HyperLink Instructions:
------------------------------
- Place the 'HyperText' Script on a 3D GameObject. (e.g. Cube GameObject)
- Set the 'Mode' to 'GameObject' on the script.
- 'HyperText' DOES NOT require an 'Event Trigger' Component to be present on the object.
- 'HyperText' requires the 3D GameObject to have a collider of some type. If not provided, the script will automatically add a mesh collider to the object.

## Extra Information:
------------------------------
- Check the 'Example' scene for a demo.
- The script is fully documented.




# License:
------------------------------
MIT License

Copyright (c) [2017] [Jason Jerome]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


Basically this license gives permissions for:
- Commercial Use
- Distribution
- Modification
- Private Use
