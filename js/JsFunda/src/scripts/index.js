
const s = "hi npm with Js fundamentals";


console.log(s);
document.write(s);

// var can be declare anywhere !
// let is scoped, var is global


if (true){
    var varX  = 10; //try with let, will fail
}
console.log(varX);


//rest parameters always go last in a function

sendCars('Monday', 1,2,3,55,66,88);

function sendCars(day, ...carsId){
    carsId.forEach(id => console.log(id));
}



///destructuring arrays

let carIds = [21,22,32];
let [car1,car2,car3] = carIds; 
console.log(car1,car2,car3);

/// Desctructuring Objects
let car = {id:5000, style:'convertible'};
let carC = {idCar:6000, styleCar:'Super Saloon'};
let {id,style} = car; //here we are destructuring an object.
let idCar, styleCar; //also a way to destructing objects, note the curly brackets
({idCar, styleCar} = carC);

console.log(id,style);
console.log(idCar, styleCar);


//Spread Syntax

function SpreadCars(car1, car2, car3){
    console.log(car1,car2,car3);
}

let cars = [1,2,3];
SpreadCars(...cars);


//typeof()

console.log(typeof(cars));
console.log(typeof(car2));
console.log(typeof(car));


//Controlling Loops

for(let i=0; i<10; i++){

    if(i===5){
        continue; //stop this iteration, continue with next one.
    }
    if(i===9){
        break; //stop this loop completely.
    }
    console.log(i);//will not print 5 and 9 or 10
}


