using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework01;


//01.Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
//   Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//02.Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
//03.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
//04.Add a method in the GSM class for displaying all information about it. Try to override ToString().
//05.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.
//06.Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//07.Write a class GSMTest to test the GSM class:
//  Create an array of few instances of the GSM class.
//  Display the information about the GSMs in the array.
//  Display the information about the static property IPhone4S
//08.Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
//09.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
//10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
//11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
//
//



namespace MobilePhone
{
    class Test
    {
        static void Main()
        {
            GSM gsmTest = new GSM("Nokia", "E7");
            gsmTest.Owner = "Me";
            gsmTest.Price = 680;
            gsmTest.battery.HoursIdle = 90f;
            gsmTest.battery.Model = "BL-4";
            gsmTest.battery.Type = BatteryType.NiCd;
            gsmTest.battery.HoursTalk = 8.33f;
            gsmTest.display.ColoursCount = 16000000;
            gsmTest.display.Size = 4;
            gsmTest.call.DialedNumber = "654135416516";
            gsmTest.call.DurationInSeconds = 123;
            gsmTest.AddCall(new Call("number+3590000", 120));
            gsmTest.AddCall(new Call("number+3590001", 25));
            gsmTest.AddCall(new Call("number+3590002", 0));

            //  gsmTest.PrintSpecs();
            Console.WriteLine(gsmTest.ToString());
            //
            Console.WriteLine(gsmTest.call.DurationInSeconds);
          //  gsmTest.DeleteCall(1);
          //  gsmTest.ClearCall();
            for (int i = 0; i < gsmTest.CallHistory.Count; i++)
            {
                Console.WriteLine(gsmTest.CallHistory[i].DurationInSeconds);
            }

            Console.WriteLine("Total price of the call on phone {0} {1} is : {2}", gsmTest.Manufacturer, gsmTest.Model, gsmTest.GetTotalPriceOfCalls(0.18, gsmTest));

            Console.WriteLine(GSM.Iphone4S.battery.Model);
      //      Console.WriteLine(gsmTest.call.DurationInSeconds);

        }
    }
}
