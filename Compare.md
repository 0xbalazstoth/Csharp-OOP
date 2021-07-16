|Method Overloading|Method Overriding|
|------------------|-----------------|
|It is done inside the same class|Base and derived class(es) are required here.|
|Overloading happens at **compile time**|Overriding happens at **runtime**|
|Gives better performance because the binding is being done at compile time.|Gives worse performance because the binding is being done at run time.|
|**Private** and **sealed** methods can be overloaded.|**Private** and **sealed** methods can not be overriden.|
|Return type of the method does not matter in case of method overloading.|Return type of the method must be the same in the case of overriding.|
|Arguments must be different in the case of overloading.|Arguments must be the same in the case of overriding.|
|Mostly used to increase the readability of the code.|Mostly used to have a separate implementation for a method that is already defined in the base class.|
|This happens at the compile time, so it can be referred to as static or *compile-time* polymorphism.|This happens at run time, so it can be called *dynamic* or *runtime polymorphism.*|