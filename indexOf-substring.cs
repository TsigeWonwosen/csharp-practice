using System;
using System.Linq;
using System.Diagnostics;

namespace taskManager
{

    class IndexOfSubstring
    {

        public IndexOfSubstring()
        {
            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters 
            // we want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // We'll use a slightly different technique for iterating through the 
            // characters in the string.  This time, we'll use the closing position
            // of the previous iteration as the starting index for the next open
            // symbol.  So, we need to initialize the closingPosition variable
            // to zero:


            //  IndexOf() gives us the first position of a character or string inside of another string.
            //  IndexOf() returns -1 if it can't find a match.
            // Substring() returns just the specified portion of a string, using a #starting position and optional #length.
            // LastIndexOf() returns the last position of a character or string inside of another string.
            // IndexOfAny() returns the #first position of an array of char that occurs inside of another string.
            // There's often more than one way to solve a problem. We used two separate techniques to find all instances of a given character or string.
            // Avoid hardcoded magic values. Instead, define a const variable.A constant variable's value can't be changed after initialization.

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now we must find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // Finally, use the techniques we've already learned to display the sub-string:

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));


                // The Remove() method works similarly to the Substring() method. You supply a starting position and 
                // the length to remove those characters from the string.
                Console.WriteLine("Remove Method.");

                string data = "12345John Smith          5000  3  ";
                string updatedData = data.Remove(5, 20);
                Console.WriteLine(updatedData);

                // The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
                // The Replace() method swaps all instances of a string with a new string.
                Console.WriteLine("Replace Method.");

                string messages = "This--is--ex-amp-le--da-ta";
                messages = messages.Replace("--", " ");
                messages = messages.Replace("-", "");
                Console.WriteLine(messages);

                Console.WriteLine("Challenge - Format , Remove, Replace.");


                // Quantity: 5000
                // Output: < h2 > Widgets & reg;</ h2 >< span > 5000 </ span >

                const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

                string quantity = "";
                string output = "";

                const string div = "<div>",
                    divClose = "</div>",
                    spanStart = "<span>",
                    spanEnd = "</span>";

                int indexOfDivStart = input.IndexOf(div);
                int indexofSpanStart = input.IndexOf(spanStart) + spanStart.Length;
                int indexofSpanEnd = input.IndexOf(spanEnd);
                int Length = indexofSpanEnd - indexofSpanStart;

                quantity = input.Substring(indexofSpanStart, Length);


                Console.WriteLine(div.Length + " ----  " + divClose.Length);
                output = input.Remove(indexOfDivStart, div.Length);
                int indexOfDivEnd = output.IndexOf(divClose);
                output = output.Remove(indexOfDivEnd, divClose.Length);
                output = output.Replace("&trade;", "&reg;");
                // Your work here

                Console.WriteLine($"Quantity : {quantity}");
                Console.WriteLine($"Output : {output}");

                int[] numbers = { 6, 9, 3, 7, 5 };

                var result = numbers.Min();

                Debug.WriteLine("Lowest number is:");
                Console.WriteLine(result);

                Console.WriteLine("Default value.");
                int i = default; // 0
                float f = default;// 0
                decimal d = default;// 0
                bool b = default;// false
                char c = default;// '\0'

                Console.WriteLine($" int : {i} float {f} boolean: {b} charactor: {c} decimal:{d}");
                string hello = "Hello";
                char[] chars = hello.ToCharArray();
                Console.WriteLine(chars);

                Array.Reverse(chars);
                string str1 = new string(chars);
                String str2 = new String(chars);
                Console.WriteLine(str2);

                foreach (char cr in str1)
                {
                    Console.WriteLine(cr);
                }

            }
        }
    }
}