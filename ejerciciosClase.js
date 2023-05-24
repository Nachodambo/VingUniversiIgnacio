
//1)
/*const mayorEdad = (edad) => edad >= 18? console.log("es mayor de edad") : console.log("es menor de edad");

mayorEdad(21);

mayorEdad(14);
*/

// 2) Numero primo

/*function esPrimo(num) {
    let primo = true;
    if (num <= 1) {
        primo = false;
    }
    for (let i = 2; i < num; i++) {
        if (num % i === 0) {
            primo = false;
        }
    }
    if (primo == true){
        console.log(num + " es un numero primo.")
    }else {
        console.log(num + " no es un numero primo.")
    }
}esPrimo(4);*/

// 3) hacer una lista de 10 numeros primos
/*
function esPrim(num){

    let primo = true;
    for (let i = 2 ; i < num ; i++){
        if (num % i === 0){
            primo = false;
        }
    }
    if (primo === true){
        return num;
    }else return;
    };

 function diezPrimos (){
    let numList =[];
    let x = 2;
    while (numList.length < 10){
        if (esPrim(x)>1){
        numList.push(esPrim(x))}
        x+=1;
    }
    console.log(numList);
}diezPrimos();
*/


//4- Encontrar el número más grande en un array de números negativos y positivos
/*
let nums = [4,6,-1,19,-31,9,56,45,67,-100];

function masGrande (nums){
    grande = 0;
    nums.forEach(element => {
        if (element > grande){
            grande = element;
        }
    });
    console.log(grande);
}
masGrande(nums);*/

//5- Crea una función que tome una cadena de palabras separadas por espacios y devuelva la palabra más larga.

/*
const frace = "hola como estas Alberto";

function longestWord (sentence){
    const worldList = sentence.split(" ");

    let palabraLarga = "";

    worldList.forEach(element => {
        if (element.length > palabraLarga.length){
            palabraLarga = element;
        }
    });
    console.log(palabraLarga);
}
longestWord(frace); 
*/

//6- Crea una función que tome un array y devuelva una nueva versión del objeto donde todos los valores son duplicados.
/*
let lista = [1,2,3];

function duplicar(list){

    let newList =[];
    let c =0;
    for (let i = 0; i < list.length; i ++){
        
        newList [c] = list[i];
        newList [c+1] = list [i];
        c = c+2;
    }
    console.log(newList)
}
duplicar(lista); */

//7- Obtener el promedio de las edades de los usuarios mayores de edad
/*
const listaEdades = [14,18,21,16,78];
function promedioMayores (list){

    let listaMayores =[];

    for (let i = 0; i < list.length ; i++){

        if (list[i] >= 18) {
            listaMayores.push(list[i]);
        }
    }
    let suma = 0;
    for (let i = 0; i < listaMayores.length; i++){
        suma += listaMayores[i];
    }
    let promedio = suma/listaMayores.length;
    console.log(listaMayores)
    console.log(promedio);
}

promedioMayores(listaEdades); */
