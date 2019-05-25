import '../styles/index.scss';

console.log('webpack starterkit');


let arr = [1,5,6,2,7,9,10,11,234];


function printArr(array){
    array.forEach(element => {
        console.log(element);
    });
}


//Lets play to order manually an array.

function orderArrayDesc(array){
    array.forEach(i => {
        array.forEach(j => {
            if(j < i){
                console.log('i and j are : ' + i + ', ' + j);
                let item = array.pop(j);
                console.log('Item : ' + item);
                array.push(item);
            }
            
        })
    });

    return array;

}


printArr(arr);
let arr2 = orderArrayDesc(arr);
printArr(arr2);