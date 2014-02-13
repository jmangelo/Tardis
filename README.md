# Tardis

An experiment in unit testing DateTime dependent code. 

## Use Cases

1. You want to write your code using DateTime directly and then have an interception mechanism in place just when running the tests.

2. You already have a bunch of code directly depending on DateTime and you want to make it testable with the minimal amount of effort.

If you are on one of these situations then give a Tardis a go; it couldn't be simpler.

## Example

```csharp

    public class Example
    {
	    #if YOUR_TEST_ONLY_SYMBOL
	    internal IDateTimeProvider DateTime { get; set; }
	    
	    internal Example(IDateTimeProvider provider)
	    {
	    	this.DateTime = provider;
	    }
	    #endif
	    
		// Plain old DateTime dependent code that will now support interception
		// when built with the specified symbol
	    private string title;
	    
	    public string Title
	    {
		    get { return this.title; }
		    set
		    {
			    this.title = value;
			    this.UpdatedAt = DateTime.UtcNow;
		    }
	    }
	    
	    public DateTime UpdatedAt { get; private set; }
    }

```

