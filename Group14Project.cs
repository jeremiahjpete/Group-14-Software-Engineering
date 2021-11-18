using System;

public class Class1
{
	/** TODO: Create a spam check that takes a list of predetermined spam numbers and blocks them when call is invoked
	 *	otherwise allow the call to go through and notify user **/

	public bool isSpam = false; // to check if value is spam or not
	public String[] spamList = {}; // insert spam numbers

	public Class1{
		Caller caller1 = new Caller("1111111111");
		caller1.setSpam();
		Caller caller2 = new Caller("1234567890");
		Caller caller3 = new Caller("0987654321");
		Caller caller4 = new Caller("2222222222");
		caller4.setSpam();
		Caller caller5 = new Caller("3333333333");
		Caller[] callerList = {caller1, caller2, caller3, caller4, caller5};
		
	}

	public CheckSpam()
	{
		for (int i = 0; i < callerList; i++ )
		{ if(callerList.i == spam) {
			
		}
  			Console.WriteLine("call accepted");
		}
	}
}

public class Caller 
{
	/** Caller is an object to hold the callers phone number and keep track of if they are marked as spam or not.**/
    private String number;
    private bool Spam;

    Caller(String num) 
	{
		number = num;
        Spam = false;
    }
    public void setSpam()
	{
		//sets the caller as a spam caller.
        Spam = this;
    }
    public bool isSpam() 
	{
		//returns whether the caller is a spam caller or not.
        return Spam;
    }

	// use call function to imitate a number being called
	public bool Call(String num) {
		for (int i = 0; i < spamList.Length; i++) {
			if (num.Equals(spamList[i]))
				Spam = true;
			else
				Spam = false;
		}
		return Spam;
	}

	// display options to user to allow them to mark an incoming call as spam
	public displayCallOptions(String num) {
		while (1) {
			Console.WriteLine("Incoming Call: %s\n", num);
			
		}

    }
}

