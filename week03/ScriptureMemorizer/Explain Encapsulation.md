# What is Encapsulation?
Encapsulation is a key foundation of programming. It allows us to keep our classes safe by defining the way their attributes will be managed by defining "getters" and "setters" and declaring the attributes as private.

One of the benefits of encapsulation is that prevents our code to access and modify the information of the instances of our classes directly. That gives us more control in how we store, manage and share the info of our instances. This also improves our maintainability.

This is an example of encapsulation in the class Word. I applied encapsulation by defining how the words are hidden and displayed:
```C#
private string _text;
private bool _isHidden;

public void Hide()
{
    _isHidden = true;
}

public bool IsHidden()
{
    return _isHidden;
}
```

The attriubutes _text and _isHidden are private, which means that they can't be modified and accessed directly (Word._text = "..."). Their values can only be modified and accessed by the declared methods, such as `Hide()` and `IsHidden()`.

This prevents other parts of the program from accidentally setting _isHidden to an invalid value or directly modifying the word's text. All changes must go through controlled methods.