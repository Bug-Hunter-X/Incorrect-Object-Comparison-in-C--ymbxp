# Incorrect Object Comparison in C#

This code demonstrates a common error in C# where object comparisons use reference equality instead of value equality.  The `==` operator checks for reference equality by default. To compare the values of objects, you must override the `Equals()` method and implement the `IEquatable<T>` interface.