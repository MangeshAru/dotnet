# dotnet
Dotnet framework is a software development framework provide predefined function so it is easy to use.
It includes a library and runtime environment.
FCL (Framework Class Library) provides user interface, database connectivity, cryptography, web development and many more.
.NET programs are executed in CLR (Common Language Runtime).
Provide language interoperability i.e., provides many languages which combine altogether.

### Advantages
   Object-oriented programming
   Language independence
   Efficient data access
   Code Sharing 
   Support for services
### dotnet stack

![dotnet stack](https://github.com/MangeshAru/dotnet/blob/main/dotnet%20framework%20stack.png)

## Compilation Process
![compilationProcess](https://github.com/MangeshAru/dotnet/blob/main/compilationProcessDotNet.png)
   It is done in two parts
    1.	Language compilers – compiler time process
    2.	JIT – runtime process
    
Compiler time process
    The .NET framework has one or more language compilers in which source code(ex: abc.exe file) is compiled by respective compiler(converted to abc.EXE) and translate source code into MSIL code (it also contains meta data) usually EXE and DLL (Dynamic Link Libraries) file.
Runtime Process
       CLR includes a JIT compiler for converting MSIL code into native code and that is then executed by OS.</br>
       
`Delegates`

   - It is a reference type.
   - It is a function pointer or it holds a reference (pointer) to a function (method).
   - It is type safe.
   - Delegates are mainly used for the event handling and the callback methods.
  Also, note this method has the same signature as that of the EligibleToPromotion delegate. This is very important because the Promote method cannot be passed as a parameter to the delegate if the signature differs. This is the reason why delegates are called type-safe function pointers. 
  
  
  
### Basic Structure of C#
{

      //include class libraries/namespace
      using System;
      
       //declare namespace 
       namespace namespaceName
       {
         //class declaration
         class className
         {
           //Data Members
           int something;
           float a;
           //Method/functions/block
           public void DoSomething()
           {
            //implementation
           }
         }
       }
      
}
  
# Object Oriented Programming (OOPs) in C#
C#.NET is a completely Object-Oriented Programming Language. It means it supports all 4 OOPs 
Principles i.e. Abstraction, Encapsulation, Inheritance, and Polymorphism.

`Class and Objects in C#`


Constructors in C#
Types of Constructors in C#
Why We Need Constructors in C#
Static vs Non-Static Constructors in C#
Private Constructors in C#
Destructors in C#
Garbage Collection in C#.NET
Access Specifiers in C#
Encapsulation in C#
Abstraction in C#
Inheritance in C#
Types of Inheritance in C#
How to use Inheritance in Application Development
IsA and HasA Relationship in C#
Generalization and Specialization in C#
Abstract Class and Abstract Methods in C#
Abstract Class and Abstract Methods Interview Questions in C#
How to Use Abstract Classes and Methods in C# Application
Interface in C#
Interface Interview Questions and Answers in C#
Interface Realtime Examples in C#
Multiple Inheritance in C#
Multiple Inheritance Realtime Example in C#
Polymorphism in C#
Method Overloading in C#
Operator Overloading in C#
Method Overriding in C#
Method Hiding in C#
Partial Class and Partial Methods in C#
Sealed Class and Sealed Methods in C#
Extension Methods in C#
Static Class in C#
Variable Reference and Instance of a Class in C#


Chapter-4 Exception Handling
Exception Handling in C#
Multiple Catch Blocks and Finally Block in C#
Custom Exception in C#
Inner Exception in C#
Exception Handling Abuse in C#


Chapter-5 Events, Delegates, and Lambda Expression in C#
Course Structure of Events, Delegates, and Lambda Expression
Roles of Events, Delegates, and Event Handler in C#
Delegates in C#
Multicast Delegates in C#
Delegates Real-Time Example in C#
Generic Delegates in C#
Anonymous Method in C#
Anonymous Method Realtime Example in C#
Lambda Expressions in C#
Events in C# with Examples


Chapter-6 MultiThreading
Multithreading in C#
Constructors of Thread class in C#
How to Pass Data to Thread Function in Type-Safe Manner in C#
How to Retrieve Data from a Thread Function in C#
IsAlive Property and Join Method of Thread Class in C#
Thread Synchronization in C#
Locking in C#
Monitor Class in C#
Mutex Class in C#
Semaphore Class in C#
SemaphoreSlim Class in C#
Deadlock in C#
Performance Testing of a Multithreaded Application
Thread Pooling in C#
Foreground and Background Threads in C#
AutoResetEvent and ManualResetEvent in C#
Thread Life Cycle in C#
Threads Priorities in C#
How to Terminate a Thread in C#
Inter Thread Communication in C#
How to Debug a Multi-threaded Application in C#


Chapter-7 Reflection
C# Reflection
Dynamic Type in C#
Var Keyword in C#
Dynamic vs Var Keyword in C#
Dynamic vs Reflection in C#
Volatile Keyword in C#


Chapter-8 File Handling in C#
File Handling in C#
FileStream Class in C#
StreamReader and StreamWriter in C#
File Class in C#
TextWriter and TextReader in C#
BinaryWriter and BinaryReader in C#
StringWriter and StringReader in C#
FileInfo Class in C#
DirectoryInfo Class in C#


Chapter-9 Collections in C#
Arrays in C#
2d Array in C#
Advantages and Disadvantages of Arrays in C#
Collections in C#
Non-Generic ArrayList in C#
Non-Generic Hashtable in C#
Non-Generic Stack in C#
Non-Generic Queue in C#
Non-Generic SortedList in C#
Advantages and Disadvantages of Non-Generic Collection in C#
Generic Collections in C#
Generics in C#
Generic Constraints in C#
Generic List Collection in C#
How to Sort a List of Complex Types in C#
Comparison Delegate in C#
Generic Dictionary Collection Class in C#
Conversion Between Array List and Dictionary in C#
List vs Dictionary in C#
Generic Stack Collection Class in C#
Generic Queue Collection Class in C#
Foreach Loop in C#
Generic HashSet Collection Class in C#
Generic SortedList Collection Class in C#
Generic SortedSet Collection Class in C#
Generic SortedDictionary Collection Class in C#
Generic LinkedList Collection Class in C#
Concurrent Collection in C#
ConcurrentDictionary Collection Class in C#
ConcurrentQueue Collection Class in C#
ConcurrentStack Collection Class in C#
ConcurrentBag Collection Class in C#
BlockingCollection Class in C#
Chapter-10 Asynchronous Programming
Introduction to Asynchronous Programming
Async and Await Operators in C#
Tasks in C#
How to Return a Value from Task in C#
How to Execute Multiple Tasks in C#
How to Limit Number of Concurrent Tasks in C#
How to Cancel a Task in C# using Cancellation Token
How to Create Synchronous Method using Task in C#
Retry Pattern in C#
Only One Pattern in C#
How to Control the Result of a Task in C#
Task-based Asynchronous Programming in C#
Chaining Tasks by Using Continuation Tasks
ValueTask in C#
How to Cancel a Non-Cancellable Task in C#
Asynchronous Streams in C#
How to Cancel Asynchronous Stream in C#


Chapter-11 Parallel Programming
Task Parallel Library in C#
Parallel For in C#
Parallel Foreach Loop in C#
Parallel Invoke in C#
Maximum Degree of Parallelism in C#
How to Cancel Parallel Operations in C#
Atomic Methods Thread Safety and Race Conditions in C#
Interlocked vs Lock in C#
Parallel LINQ in C#


Chapter-12 AutoMapper
AutoMapper in C#
AutoMapper Complex Mapping in C#
Mapping Complex type to Primitive Type using AutoMapper in C#
AutoMapper ReverseMap in C#
AutoMapper Conditional Mapping in C#
AutoMapper Ignore Property in C#
UseValue ResolveUsing and Null Substitution in AutoMapper


Chapter-13 Optional Parameter, Indexers, and Enums
How to make Optional Parameters in C#
Indexers in C#
Indexers Real-Time Example in C#
Enums in C#


Chapter-14 ADO.NET (Working with Database)
Introduction to ADO.NET
ADO.NET using SQL Server
ADO.NET SqlConnection
ADO.NET SqlCommand
ADO.NET SqlDataReader
ADO.NET SqlDataAdapter
ADO.NET DataTable in C#
DataTable Methods in C#
ADO.NET DataSet
DataSet using SQL Server
The Architecture of DataSet in .NET
ADO.NET Using Stored Procedure
Transactions in ADO.NET
ADO.NET Connection Pooling
ADO.NET Architecture


Chapter-15 .NET Framework Architecture
Introduction to .NET Framework
Common Language Runtime in .NET
.NET Program Execution Process
Intermediate Language (ILDASM & ILASM) Code in C#
Common Type System in .NET Framework
Common Language Specification in .NET Framework
Managed and Unmanaged Code in .NET
Assembly DLL EXE in .NET Framework
App Domain in .NET Framework
Strong and Weak Assemblies in .NET
What is delayed signing?
Can we see a simple example of GAC & How to handle multiple versions in GAC (Binding redirect)?


Chapter-16 C# 7 New Features
C# 7 New Features
Out Variables in C#
Pattern Matching in C#
Digit Separators in C#
Tuples in C#
Splitting Tuples in C#
Local Functions in C#
Ref Returns and Ref Locals in C#
Generalized Async Return Types in C#
Expression Bodied Members in C#
Thrown Expression in C#
Async Main in C#
Chapter-17 C# 8 Features


C# 8 New Features
ReadOnly Structs in C#
Default Interface Methods in C#
Pattern Matching in C#
Using Declarations in C#
Static Local Functions in C#
Disposable Ref Structs in C#
Nullable Reference Types in C#
Asynchronous Streams in C#
Asynchronous Disposable in C#
Indices and Ranges in C#
Null-Coalescing Assignment Operator in C#
Unmanaged Constructed Types in C#
Stackalloc in Nested Expressions in C#

Chapter-18 C# 9 Features
Top-Level Statements
Record Types
Init-Only Setters
Enhancements to Pattern Matching
Natural-Sized Integers
Function Pointers
Target Type New
Target Type Conditional
Static Anonymous Methods
Covariant Return Types
Lambda Discard Parameters
Attributes of Local Functions


Chapter-19 C# 10 Features
Record Structs
Improvements in Structure Types
Interpolated String Handlers
Global using Directives
File-scoped namespace declaration
Extended property patterns
Improvements in lambda expressions
Allow const interpolated strings
Record types can seal ToString()
Improved definite assignment
Allow both assignment and declaration in the same deconstruction
Allow AsyncMethodBuilder attribute on methods
CallerArgumentExpression attribute
Enhanced #line pragma
Chapter 20 Working with XML and JSON
Chapter-21 Entity Framework (You will know Everything about EF)
Database First Approach
Code First Approach


Chapter-22 Language Integrated Query (LINQ)
Architecture of LINQ
Different Ways to Write LINQ Query
IEnumerable and IQueryable in C#
Differences between IEnumerable and IQueryable
LINQ Extension Methods
LINQ Operators
LINQ Select Operator in C#
LINQ SelectMany in C#
Where Filtering Operators in LINQ
OfType Operator in LINQ
Set Operators in LINQ
LINQ Distinct Method in C#
LINQ Except in C#
LINQ Intersect Method in C#
LINQ Union in C#
Linq Concat Method in C#
Ordering Operators in LINQ
Linq OrderBy Method in C#
Linq OrderByDescending Method in C#
Linq ThenBy and ThenByDescending Method in C#
LINQ Reverse Method in C#
LINQ Aggregate Functions in C#
Linq Sum in C#
Linq Max in C#
Linq Min Method in C#
Linq Average Method in C#
Linq Count Method in C#
Linq Aggregate Method in C#
LINQ Quantifiers Operators
Linq All Operator in C#
Linq Any in C#
Linq Contains in C#
Linq GroupBy in C#
GroupBy By Multiple Keys in Linq
Linq ToLookup Method in C#
Linq Joins in C#
Linq Inner Join in C#
Linq Join with Multiple Data Sources
Linq Group Join in C#
Left Join in Linq
Linq Cross Join
Element Operators in LINQ
ElementAt and ElementAtOrDefault in Linq
First and FirstOrDefault Methods in Linq
Last and LastOrDefault Methods in Linq
Single and SingleOrDefault Methods in Linq
DefaultIfEmpty Method in Linq
SequenceEqual Operator in LINQ
Partitioning Operators in Linq
Take Operator in Linq
TakeWhile Method in Linq
Skip Method in Linq
SkipWhile Method in Linq
Paging Using Skip and Take Method
Linq Range Method in C#
Linq Repeat Method in C#
Linq Empty Method in C#
Linq Append Method in C#
Linq Prepend Method in C#
Linq Zip Method in C#
Deferred Execution vs Immediate Execution in LINQ
ToList and ToArray Methods
ToDictionary Method
Cast Operator
Difference between Cast and OfType Operators

Chapter-23 Design Patterns
Chapter -23-A Creational Design Pattern
Creational Design Pattern in C#
Factory Design Pattern in C#
Factory Method Design Pattern in C#
Abstract Factory Design Pattern in C#
Builder Design Pattern in C#
Builder Design Pattern Real-time Example
Fluent Interface Design Pattern in C#
Prototype Design Pattern in C#
Shallow Copy and Deep Copy in C#
Singleton Design Pattern in C#
Why Singleton Class sealed in C#
Thread-safe Singleton Design Pattern in C#
Lazy Loading and Eager Loading in Singleton Design Pattern
Singleton VS Static class in C#
Singleton Design Pattern Real-Time Examples in C#


Chapter-23-B Structural Design Pattern
Structural Design Pattern in C#
Adapter Design Pattern in C#
Adapter Design Pattern Real-time Example
Facade Design Pattern in C#
Decorator Design Pattern in C#
Decorator Design Pattern Real-Time Example
Bridge Design Pattern in C#
Bridge Design Pattern Real-Time Example
Composite Design Pattern in C#
Proxy Design Pattern in C#
Proxy Design Pattern Real-time Example
Flyweight Design Pattern in C#


Chapter-23-C Behavioral Design Pattern
Behavioral Design Pattern in C#
Iterator Design Pattern in C#
Observer Design Pattern in C#
Chain of Responsibility Design Pattern in C#
Real-Time Examples of Chain of Responsibility Design Pattern
State Design Pattern in C#
State Design Pattern Real-time Example
Template Method Design Pattern in C#
Template Method Design Pattern Real-time Example
Command Design Pattern in C#
Visitor Design Pattern in C#
Strategy Design Pattern in C#
Strategy Design Pattern Real-Time Example – Travel
Strategy Pattern Real-Time Example – Payment
Interpreter Design Pattern in C#
Mediator Design Pattern in C#
Memento Design Pattern in C#


Chapter-23-D Dependency Injection Design Pattern
Dependency Injection Design Pattern in C#
Property and Method Dependency Injection in C#
Dependency Injection using Unity Container in MVC
Chapter-23-E Repository Design Pattern
Repository Design Pattern in C#
Generic Repository Pattern in C#
Using Both Generic and Non-Generic Repository Patterns in C#
Unit Of Work in Repository Pattern


Chapter-24 SOLID Design Principles
Single Responsibility Principle in C#
Open-Closed Principle in C#
Liskov Substitution Principle in C#
Interface Segregation Principle in C#
Dependency Inversion Principle in C#


Chapter-25 Experienced Interview Questions:
What is the IDisposable interface & finalize Dispose of Pattern in GC?
What are different .NET data types and their uses according to scenarios?
Explain TypeSafe, Casting, Explicit casting, and Implicit casting.
What do you mean by Covariance & Contravariance in .NET 4.0?
What are boxing and unboxing?
What is Optimistic and Pessimistic Locking?
What are regular expressions & can we see some practical demonstrations?
.NET 4.5 feature – Why do we need REGEX timeout?
Tips to improve your C# Debugging.
Can you explain Named Parameters, Ref, Out, Volatile & Parsetry?
What is the difference between Const & ReadOnly?
Explain the difference between the “IS” and “AS” keywords.
What is the #Debug directive?
What is the difference between debugging and Release?
What are serialization and deserialization?
What are IComparable and IComparer?
What is the use of the Yield Keyword in C#?
What is a C# indexer?
What are ?? (Coalescing operators)?
What is C# reflection?
What is the Dynamic keyword & How does it differ from Reflection?
What is the difference between Early binding and Late binding?
What is the difference between VAR and Dynamic keywords?
What are Circular Dependencies and How to resolve them?
How can we mark a method as deprecated?
What is the difference between Build VS Rebuild Vs Clean?
Importance of bin folder & obj folder in C#.
What is Naming Convention?
What is NuGet?
What are portable class libraries?
What are Async and Await keywords?
Explain Concurrency VS Parallelism.
Does Async use threads?
What are ENUM and flags in ENUMS?
How to convert string to ENUM?
Explain NULLABLE Types.
What are DataAnnotations?
How to generate Random numbers in C#?
Preprocessor Directives/Symbols

