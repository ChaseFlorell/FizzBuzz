##FizzBuzz Challenge using Chain of Responsibility (CoR) pattern in C#.

[As described by Jeff Atwood](http://www.codinghorror.com/blog/2007/02/why-cant-programmers-program.html)

> Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".

There's a lot of [controversy](https://twitter.com/ayende/status/359221698790309888) as to whether or not these test's are [valid](https://twitter.com/kellabyte/status/359309409131827201) in an interview process, and IMO, the answer is `yes & no`.

A quick [Google Search](https://www.google.ca/search?q=fizzbuzz) will present you with a large number of programmers proving that they can [solve FuzzBuzz](http://c2.com/cgi/wiki?FizzBuzzTest). There's even a [Code Golf](http://codegolf.stackexchange.com/) challenge on how to [obfuscate FizzBuzz](http://codegolf.stackexchange.com/questions/88/obfuscated-fizzbuzz-golf).

In fact, any hack should be able to pull off FizzBuzz in just a few lines of code. I believe this is why [Kellabyte](https://github.com/kellabyte) ([twitter](https://twitter.com/kellabyte)) wishes it would disappear. The below code doesn't really show anyone's specific skills beyond some really basic logic.

	for(var i = 1; i <= 100; i++)
	{
	    var builder = new StringBuilder();
	    if(i%3==0) 
	    {
	        builder.Append("Fizz");
	    }
	    
	    if(i%5==0) 
	    {
	        builder.Append("Buzz");
	    }
	
	    if(i%3 !=0 && i%5 !=0)
	    {
	        builder.Append(i.ToString());
	    }
	    
	    Console.WriteLine(builder.ToString());
	}

This being said however, I believe the value in FizzBuzz can be found in how the candidate approaches the problem. A successful candidate will not only solve FizzBuzz, but will also "show their chops" in the process.

This example shows how to prep for that interview. 

 - Brush up on your design patters. 
 - Make sure your code is testable AND tested
 - Build scripts are a definite plus.

This FizzBuzz solution is showing the [Chain of Responsibility (CoR)](http://www.dofactory.com/Patterns/PatternChain.aspx) design pattern.

##Run It:

Launch Powershell:

    > git clone https://github.com/ChaseFlorell/FizzBuzz.git
    > cd FizzBuzz
    > cmd /c build