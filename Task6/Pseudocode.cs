//setup
var ordertotal = 0;
var statetax = 0.05;
var localtax = 0.03;
var statetaxamount = 0;
var localtaxamount = 0;
var grandtotal = 0;
var isNumeric = false;
var tempinput = string.Empty;

//input
PUT "What is the order total"
GET ordertotal

statetaxamount = gettax(ordertotal,statetax)
localtaxamount = gettax(ordertotal, localtax)
grandtotal = ordertotal + statetaxamount + localtaxamount

PUT "Order amount: " + ordertotal
PUT "State tax:    " + statetaxamount
PUT "Local tax:    " + localtax
PUT "___________________________"
PUT "Grand total   " + grandtotal


Function double GetTax(double ordertotal, double taxamount)
    return = ordertotal * taxamount
end Function