# C#: Classes and objects
This project is all about learning how classes and objects work in C#.
In order to learn this, I will be making a tiny console bank program.
The end goal of this console bank program is to create a Client and his/her bank account, where they can make different deposits and withdrawals.

## Ready, Set, GET!
I have always been used to manually writing the setters and getters of every class.
But today, I learned it is possible to generate it automatically.
You do this by right-clicking in the editor where you'd like to add the setters and getters, click generate, and then choose the right ones.

## Readability
Here's another very important thing I've learned: The Program.cs file should only contain methods that are being called.
One of my fellow Becode Learners taught me this.
This really helped me write cleaner, more readable, and more understandable code.

## Git off me' darn' property!
Properties.
The naming convention of properties in C# is something I'm still not too familiar with.
But now I learned that the properties themselves need to have an underscore in front of them.

## Classy move Mr. Sharp
Very early on in the project, I knew that I had to create a new class, and that class would then create all the different new Objects from the Client and Bankaccount classes.
Unfortunately, while working on the project, I started to forget about the Client class.
So now I need to find a way for the Register method to create a new Client, and that Client needs to be connected to the BankAccount class.

I thought of adding the Client as a property to the BankAccount class.
That way it's more connected.

## Importance of OOP: HandleBanking Method
One of the most fun, and intensive, parts of this exercise was putting as less code as possible in the Program.cs.
I tried my darn'dest to create as many methods as possible to handle all the logic.
I even went as far as to create a method that handles other methods.

The method in question, is the HandleBanking method from the BankAccount class.
The way this method works, is that it starts out by giving the user an option to pick between different functionalities of the app.
If the user picks an invalid choice, they need to re-enter their choice.

After this, according to what the user picked, a method gets called.
For the sake of this explanation, let's say the user wants to deposit some money.

The HandleBanking method recognizes this, and calls the Deposit method.
The Deposit method then makes sure the deposit goes smoothly without errors.
After the Deposit method's job is done, the HandleBanking method gets called again.
The user can then select their next move.


## Final Thoughts
I'm pretty sure that even after ten years, this project will hold a special place in my heart.
This was my very first step into Software Development, and I absolutely loved it.

The project also made me realize just how important OOP is to C#.
And that is also exactly why I chose to delve more into C#.
OOP is really, really tough to understand, but it is also my preferred way of working.
It's as challenging as it is rewarding to understand.
This first step into C# will most **definitely** not be my last!

![spongebob-meme](readme-images/spongebob-gif.gif)