# Simple-Event-System-for-Unity-3d

publish-subscriber + singleton design pattern to handle events in Unity3d with C#
We can easily implement the publisher-subscriber pattern along with the singleton pattern, to have a simple yet powerful system to handle event in our Unity App/Game.

Medium Article

https://medium.com/@francescociullaroma/simple-event-system-for-unity-3d-8fe24ed7c7ce


Quick recap: 

- A Publisher has events, which can or can not have arguments.
- Some subscribers subscribe to that specific event.
- Multiple subscribers can subscribe to the same event, or an event could not be subscribed by any subscribers. The publisher just doesn’t care about that.
- When a special event happens, the Publisher fires the Event, and all the subscribers get notified about the event fired.
- The key thing is that the publisher doesn’t know what the subscribers are, but just fires the event when we know that is the right moment to do so