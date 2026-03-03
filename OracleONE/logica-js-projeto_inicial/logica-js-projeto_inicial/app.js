alert("Bem Vindo ao jogo do número secreto!")
let max = 50
let numeroSecreto = parseInt(Math.random()*max+1)
console.log(numeroSecreto)
let chute
let tentativas = 1

while(numeroSecreto != chute){
    
    chute = prompt(`Insira um numero entre 1 e ${max}`)

    if(numeroSecreto > chute){
        alert(`Você Errou! :( - O número secreto é maior que ${chute}`)
    }else{
        if(numeroSecreto < chute){
        alert(`Você Errou! :( - O numero secreto é menor que ${chute}`)
        }else{
            break;
    }
    }
    tentativas ++
}

let palavraTentativas = tentativas > 1 ? `foram necessarias ${tentativas} tentativas para acertar` : `foi necessaria ${tentativas} tentativa para acertar`
alert(`Você Acertou! :) - o número secreto é ${numeroSecreto} | ${palavraTentativas} `)



    