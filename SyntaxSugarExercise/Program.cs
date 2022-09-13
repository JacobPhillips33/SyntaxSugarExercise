//Given the following code, change the code to implement:
//DONE - inferred typing
//DONE - string interpolation
//DONE - and the ternary operator


//This was the original code that I had to change:
    //int answer = 4;
    //string response;
    //if (answer < 9)
    //{
    //    response = answer + " is less than nine";
    //}
    //else
    //{
    //    response = answer + " is greater than or equal to nine";
    //}


//Completed Code

var answer = 4;
var response = (answer < 9 ) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
Console.WriteLine(response);
