# Fizzbuzz OO
The best Fizzbuzz implementation, because it uses OO.

# Goals
The main goal of this project is to create a Fizzbuzz implementation that is up to date with today's standards and implements well known OO-Patterns, so it's easy for others to understand.

Fizzbuzz OO is very flexible and robust at the same time, due to its multi-layer implementation.

# Implementation

As you can see from this easy to understand [Code Map of the project](http://i.imgur.com/ebj8369.png), the code is divided into several logical parts.

* **Fizzbuzz**

	The main Fizzbuzz namespace holds basic classes like the main entry point Program.
	
	It also has the StackExecutor, which collects executable objects (IExecutable) and performs their actions one after the other.
	
	That makes it easy for developers to extend the application and find errors, by adding all their actions to the stack. When the order of operations is wrong, they can easily see this in the stack by debugging the application before the stack gets processed.
	
	The Singleton is the first classic OO pattern that this project uses. It creates objects that are only used once in the lifetime of the application.

* **Fizzbuzz.Core**

	This is the core of the application: The logic part is implemented in FizzbuzzLogic.
	Also, a standarized application is used by the FizzbuzzLogicExecutable class, which is based on the interface IStandardExecutable.
	
* **Fizzbuzz.Loops**

	The Loops section of the project is an implementation of a logical loop for the StackExecutor to handle.
	A LoopExecutorFactory provides easy access to all kinds of loops.
	The typical for loop is implemented in the *Fizzbuzz.Loops.For* namespace.

* **Fizzbuzz.Printables**

	This namespace holds the different printable types of the project.
	
* **Fizzbuzz.Adapters**

	Adapters are an OO-Pattern that maps objects from one type to another.
	The adapters provided by the AdapterFactory can be used for exactly that.
	The standard adapter pattern is used here.
	
