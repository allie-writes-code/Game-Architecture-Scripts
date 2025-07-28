# Unity / Game Architecture and Framework Scripts

This repo is a collection of helper classes, scripts and code to assist with implementing design and architecture patterns into projects.

## The [Delegate Subscriber Pattern](https://github.com/allie-writes-code/Unity-Framework-Scripts/tree/main/Delegate%20Subscriber%20Pattern) - Unity
makes use of Unity's ScriptableObjects to allow for shared / monitored variables that can broadcast upon update / interaction to subscribed methods, allowing objects to more easily monitor for changes to values or states. Note that the intent is to reduce update checks, i.e. an object doesn't need to check if a value has changed every frame, it only needs to know when it does.

Flow:
Game Start -> Subscribers register their methods with SO (instance of the shared var).
At runtime: Publisher makes change to value (SO / var) -> SO broadcasts to subs -> Subscriber receives and reacts.

The intent of the files in this repo is to provide easy to implement code that allows easier reuse this pattern.

Setup video TBD
