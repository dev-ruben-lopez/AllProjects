
const s = "hi npm with Js fundamentals";


console.log(s);
document.write(s)

// var can be declare anywhere !
// let is scoped, var is global


if (true){
    var varX  = 10; //try with let, will fail
}
console.log(varX);


//rest parameters always go last in a function

sendCars('Monday', 1,2,3,55,66,88)

function sendCars(day, ...carsId){
    carsId.forEach(id => console.log(id));
}



///destructuring arrays

let carIds = [21,22,32];
let [car1,car2,car3] = carIds; 
console.log(car1,car2,car3);






