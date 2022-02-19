console.log('This is first loop, its the easy way to get the same result.');
for(a = 5; a < 10; a++){
    console.log(a);
}

console.log('This is Second loop, same result more complex, but valid.');

a = 5;
while(true){
    if(a>=10){
        break;
    }
    console.log(a);
    a++;
}

console.log('The end.');




var x = 10;
var b = foo(3);


function foo(b){
    x = x * 2;
    x = x + b;
    return x / 2;
}

console.log(a);

console.log(b);



/**Solution to Challenge */

var bankAccountLimit = 10000.00;
var bankBalance = bankAccountLimit;
var accessoriesPurchaseLimit = 500.00;
const taxRate = 9.00;
const phoneValue = 999.99;

console.log('Lets buy some phones !!! *************');

while(bankBalance > 0){
    PurchasePhone(phoneValue);
}

function CalculateTax(price){
    return price * (taxRate/100);
}

function PurchasePhone(value){

    var totalPrice = value + CalculateTax(value)
    if(bankBalance >= totalPrice){
        console.log('Total Price : ' + FormatValue(totalPrice));
        bankBalance = bankBalance - totalPrice;
        console.log('Purchase completed!');
        console.log('New Bank Balance : ' + FormatValue(bankBalance));

    }

}

function FormatValue(value){
    return '$' + value.toFixed(2);
}


