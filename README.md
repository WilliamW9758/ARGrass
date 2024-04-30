# ARTouchGrass
## SDK
Unity, Apple ARKit iOS, XCode
## Platform
iOS 17.4.1
## Packages Used
AR Foundation, Apple ARKit XR Plugin, [RealtimeHand](https://github.com/ogoguel/realtimehand)
## Hardware Requirement
iPhone LiDAR
## Description
AR Touch Grass is an iOS app that aims to provide an AR experience where the user can use their hand to touch any surface, and grass grows from the surfaces they touch. This project is inspired by various interactive art that allow the user to use their body to interact with a screen or a projection. This app hopes to bring a similar artistic experience to AR, with devices that is accessible to most people. This particular implementation is inspired by various mystical creatures that are said to have plants grow wherever they touch. I think this is an interesting concept with a positive connotation. 
## Technical Challenges
There are a few steps required to achieve the effect of having something grow out of any surface you touch. 
1. The surface needs to be identified.
2. The user's hand needs to be recognized to some degree.
3. Real-time collision detection between the hand and the surfaces needs to be implemented.
4. 3D models of grasses need to grow from the identified surfaces and remain there.
## Purposed Methods
First, in order for the surface to be identified, I considered using familiar techniques in Vuforia such as image tracker or virtual buttons. However, these options are either limiting in the space of interaction one can do, or don't quite fit the need. Thus, in order to have a more immersive surface, I remembered iPhone LiDAR is essentially a depth sensor. This limits the development to using Apple ARKit only, which is not ideal but will suffice for now.

Second, after researching for hand tracking package that works with Unity and ARKit, I found that while Apple has invested heavily into hand tracking (Vision Pro's whole interface revolves around hand gestures), ARKit's hand tracking support is only extended to the Apple Vision's version in Unity but not the iOS version. Unity engineers claimed that the underlying code infrastructure between ARKit VisionOS and iOS is different, and that their current top priority is to have VisionOS support. Thus, I found a GitHub Repo [RealtimeHand](https://github.com/ogoguel/realtimehand) that has hand-tracking capabilities, and hopefully, with the current setup, it is able to provide the necessary data.

Third, I intend to use Unity's built-in collision detection to detect the collision between the surface and the hand. This may be more complex than anticipated and require some manual coding.

Finally, I will search for a grass model and place it correctly using surface normals. This may require some GPU optimization if loading many grass object end up being too computationally intensive.
## Progress Update
