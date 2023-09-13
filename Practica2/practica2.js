const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

function mostrarMenu() {
  console.log("Selecciona una operación:");
  console.log("1. Torres de Hanoi");
  console.log("2. Fibonacci");
  console.log("3. Exponente");
  console.log("4. Mínimo Común Divisor (MCD)");
  console.log("5. Factorial");
  console.log("6.- Salir");

  rl.question('', (opcion) => {
    switch (parseInt(opcion)) {
      case 1:
        rl.question('Ingresa la cantidad de anillos: ', (txt1Input) => {
          const txt1 = parseInt(txt1Input);
          torresHanoiRecursivo(txt1, 1, 3, 2);

          rl.question('Presiona enter para volver al menu:', () => {
            console.clear();
            mostrarMenu();
          });  
          
        });
        break;
      case 2:
        rl.question("Ingresa la cantidad de términos: ", (txt2Input) => {
          const txt1 = parseInt(txt2Input);
        
          for (let i = 0; i < txt1; i++) {
            console.log("Fibonacci", (i + 1), "es:", fibonacciRecursivo(i));
          }

          rl.question('Presiona enter para volver al menu:', () => {
            console.clear();
            mostrarMenu();
          });  
        
        });
        break;
      case 3:
        rl.question('Ingresa la base: ', (baseInput) => {
          const x = parseFloat(baseInput);
          
          rl.question('Ingresa el exponente: ', (exponenteInput) => {
            const y = parseInt(exponenteInput);
        
            if (isNaN(x) || isNaN(y)) {
              console.error("Error: Debes ingresar números válidos para la base y el exponente.");
            } else {
              const resultado = exponenteRecursivo(x, y);
              console.log(`El resultado de ${x} elevado a la ${y} es: ${resultado}`);
            }
            
            rl.question('Presiona enter para volver al menu:', () => {
                console.clear();
                mostrarMenu();
              });  
          });
        });
        break;
      case 4:
        rl.question('Ingresa el primer número: ', (num1Input) => {
          const num1 = parseInt(num1Input);
          
          rl.question('Ingresa el segundo número: ', (num2Input) => {
            const num2 = parseInt(num2Input);
        
            if (isNaN(num1) || isNaN(num2) || num1 === 0 || num2 === 0) {
              console.error("Error: Debes ingresar números válidos distintos de cero.");
            } else {
              const resultado = mcdRecursivo(num1, num2);
              console.log(`El Mínimo Común Divisor de ${num1} y ${num2} es: ${resultado}`);
            }
            
            rl.question('Presiona enter para volver al menu:', () => {
                console.clear();
                mostrarMenu();
              });  

          });
        });
        break;

    
      case 5:
        rl.question('Ingresa un numero: ', (num) => {
            const num1 = parseInt(num);
            if (isNaN(num1)) {
                console.error("Error: Debes ingresar números válidos distintos de cero.");
              } else {
                const resultado = factorialRecursivo(num1);
                console.log(`El resultado es: ${resultado}`);
              }
              
              rl.question('Presiona enter para volver al menu:', () => {
                  console.clear();
                  mostrarMenu();
                }); 
            });   
        break;
        case 6:
            rl.close();
        break;
      default:
        console.log("Opción no válida. Por favor, selecciona una opción válida.");
        mostrarMenu();
    }
  });
}

mostrarMenu();

function torresHanoiRecursivo(n, origen, destino, auxiliar) {
  if (n === 1) {
    console.log(`Mueve un anillo desde la torre ${origen} hasta la torre ${destino}`);
  } else {
    torresHanoiRecursivo(n - 1, origen, auxiliar, destino);
    console.log(`Mueve un anillo desde la torre ${origen} hasta la torre ${destino}`);
    torresHanoiRecursivo(n - 1, auxiliar, destino, origen);
  }
}

function fibonacciRecursivo(f) {
  if (f === 0) {
    return 0;
  } else if (f === 1) {
    return 1;
  } else {
    return fibonacciRecursivo(f - 1) + fibonacciRecursivo(f - 2);
  }
}

function exponenteRecursivo(x, y) {
  if (y === 0) {
    return 1;
  } else {
    return x * exponenteRecursivo(x, y - 1);
  }
}


function factorialRecursivo(num){
    if (num == 0){
        return 1;
        
    }else{
        return num * factorialRecursivo(num-1);
    }
}

function mcdRecursivo(a, b) {
  if (b === 0) {
    return a;
  } else {
    return mcdRecursivo(b, a % b);
  }
}

